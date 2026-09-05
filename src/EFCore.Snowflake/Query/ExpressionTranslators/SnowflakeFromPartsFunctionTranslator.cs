using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Storage;

namespace EFCore.Snowflake.Query.ExpressionTranslators;

internal class SnowflakeFromPartsFunctionTranslator : IMethodCallTranslator
{
    private static readonly MethodInfo DateFromPartsMethodInfo = typeof(SnowflakeDbFunctionsExtensions)
        .GetRuntimeMethod(
            nameof(SnowflakeDbFunctionsExtensions.DateFromParts),
            [typeof(DbFunctions), typeof(int), typeof(int), typeof(int)])!;

    private readonly ISqlExpressionFactory _sqlExpressionFactory;
    private readonly IRelationalTypeMappingSource _typeMappingSource;

    public SnowflakeFromPartsFunctionTranslator(
        ISqlExpressionFactory sqlExpressionFactory,
        IRelationalTypeMappingSource typeMappingSource)
    {
        _sqlExpressionFactory = sqlExpressionFactory;
        _typeMappingSource = typeMappingSource;
    }

    public SqlExpression? Translate(
        SqlExpression? instance,
        MethodInfo method,
        IReadOnlyList<SqlExpression> arguments,
        IDiagnosticsLogger<DbLoggerCategory.Query> logger)
        => DateFromPartsMethodInfo.Equals(method)
            ? _sqlExpressionFactory.Function(
                "DATE_FROM_PARTS",
                arguments.Skip(1),
                nullable: true,
                argumentsPropagateNullability: [true, true, true],
                method.ReturnType,
                _typeMappingSource.FindMapping(method.ReturnType))
            : null;
}
