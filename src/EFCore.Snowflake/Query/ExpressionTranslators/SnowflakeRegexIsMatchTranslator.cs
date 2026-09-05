using System.Reflection;
using System.Text.RegularExpressions;
using EFCore.Snowflake.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace EFCore.Snowflake.Query.ExpressionTranslators;

/// <remarks>
/// https://docs.snowflake.com/en/sql-reference/functions/regexp_like
/// </remarks>
internal class SnowflakeRegexIsMatchTranslator : IMethodCallTranslator
{
    private static readonly MethodInfo IsMatch =
        typeof(Regex).GetRuntimeMethod(nameof(Regex.IsMatch), [typeof(string), typeof(string)])!;

    private readonly ISqlExpressionFactory _sqlExpressionFactory;

    public SnowflakeRegexIsMatchTranslator(ISqlExpressionFactory sqlExpressionFactory)
    {
        _sqlExpressionFactory = sqlExpressionFactory;
    }

    public SqlExpression? Translate(
        SqlExpression? instance,
        MethodInfo method,
        IReadOnlyList<SqlExpression> arguments,
        IDiagnosticsLogger<DbLoggerCategory.Query> logger)
    {
        if (method != IsMatch)
        {
            return null;
        }

        var input = arguments[0];
        var pattern = arguments[1];
        var typeMapping = ExpressionExtensions.InferTypeMapping(input, pattern);

        input = _sqlExpressionFactory.ApplyTypeMapping(input, typeMapping);
        pattern = _sqlExpressionFactory.ApplyTypeMapping(pattern, typeMapping);

        return _sqlExpressionFactory.Function(
            "REGEXP_LIKE",
            [input, pattern],
            nullable: true,
            argumentsPropagateNullability: Statics.TrueArrays[2],
            typeof(bool));
    }
}
