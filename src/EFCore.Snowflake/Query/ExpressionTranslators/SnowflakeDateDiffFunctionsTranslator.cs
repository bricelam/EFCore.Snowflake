using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace EFCore.Snowflake.Query.ExpressionTranslators;

/// <remarks>
/// https://docs.snowflake.com/en/sql-reference/functions/datediff
/// </remarks>
internal class SnowflakeDateDiffFunctionsTranslator : IMethodCallTranslator
{
    private static readonly Dictionary<string, string> DatePartsByMethodName = new()
    {
        [nameof(SnowflakeDbFunctionsExtensions.DateDiffYear)] = "year",
        [nameof(SnowflakeDbFunctionsExtensions.DateDiffMonth)] = "month",
        [nameof(SnowflakeDbFunctionsExtensions.DateDiffDay)] = "day",
        [nameof(SnowflakeDbFunctionsExtensions.DateDiffHour)] = "hour",
        [nameof(SnowflakeDbFunctionsExtensions.DateDiffMinute)] = "minute",
        [nameof(SnowflakeDbFunctionsExtensions.DateDiffSecond)] = "second",
        [nameof(SnowflakeDbFunctionsExtensions.DateDiffMillisecond)] = "millisecond",
        [nameof(SnowflakeDbFunctionsExtensions.DateDiffMicrosecond)] = "microsecond",
        [nameof(SnowflakeDbFunctionsExtensions.DateDiffNanosecond)] = "nanosecond",
        [nameof(SnowflakeDbFunctionsExtensions.DateDiffWeek)] = "week"
    };

    private static readonly HashSet<MethodInfo> DateDiffMethods =
        typeof(SnowflakeDbFunctionsExtensions).GetRuntimeMethods()
            .Where(m => DatePartsByMethodName.ContainsKey(m.Name))
            .ToHashSet();

    private readonly ISqlExpressionFactory _sqlExpressionFactory;

    public SnowflakeDateDiffFunctionsTranslator(ISqlExpressionFactory sqlExpressionFactory)
    {
        _sqlExpressionFactory = sqlExpressionFactory;
    }

    public SqlExpression? Translate(
        SqlExpression? instance,
        MethodInfo method,
        IReadOnlyList<SqlExpression> arguments,
        IDiagnosticsLogger<DbLoggerCategory.Query> logger)
    {
        if (!DateDiffMethods.Contains(method))
        {
            return null;
        }

        var datePart = DatePartsByMethodName[method.Name];
        var startDate = arguments[1];
        var endDate = arguments[2];
        var typeMapping = ExpressionExtensions.InferTypeMapping(startDate, endDate);

        startDate = _sqlExpressionFactory.ApplyTypeMapping(startDate, typeMapping);
        endDate = _sqlExpressionFactory.ApplyTypeMapping(endDate, typeMapping);

        return _sqlExpressionFactory.Function(
            "DATEDIFF",
            [_sqlExpressionFactory.Fragment(datePart), startDate, endDate],
            nullable: true,
            argumentsPropagateNullability: [false, true, true],
            method.ReturnType);
    }
}
