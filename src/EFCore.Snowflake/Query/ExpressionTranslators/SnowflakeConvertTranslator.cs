using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Storage;

namespace EFCore.Snowflake.Query.ExpressionTranslators;

internal class SnowflakeConvertTranslator : IMethodCallTranslator
{
    private static readonly Type[] SupportedSourceTypes =
    [
        typeof(bool),
        typeof(byte),
        typeof(DateTime),
        typeof(decimal),
        typeof(double),
        typeof(float),
        typeof(int),
        typeof(long),
        typeof(short),
        typeof(string)
    ];

    private static readonly Dictionary<MethodInfo, Type> MethodTargetTypeMapping = BuildMethodTargetTypeMapping();

    private readonly ISqlExpressionFactory _sqlExpressionFactory;
    private readonly IRelationalTypeMappingSource _typeMappingSource;

    public SnowflakeConvertTranslator(ISqlExpressionFactory sqlExpressionFactory, IRelationalTypeMappingSource typeMappingSource)
    {
        _sqlExpressionFactory = sqlExpressionFactory;
        _typeMappingSource = typeMappingSource;
    }

    public SqlExpression? Translate(
        SqlExpression? instance,
        MethodInfo method,
        IReadOnlyList<SqlExpression> arguments,
        IDiagnosticsLogger<DbLoggerCategory.Query> logger)
        => MethodTargetTypeMapping.TryGetValue(method, out var targetType)
            ? _sqlExpressionFactory.Convert(arguments[0], targetType, _typeMappingSource.FindMapping(targetType))
            : null;

    private static Dictionary<MethodInfo, Type> BuildMethodTargetTypeMapping()
    {
        var targetTypesByMethodName = new Dictionary<string, Type>
        {
            [nameof(Convert.ToBoolean)] = typeof(bool),
            [nameof(Convert.ToByte)] = typeof(byte),
            [nameof(Convert.ToDecimal)] = typeof(decimal),
            [nameof(Convert.ToDouble)] = typeof(double),
            [nameof(Convert.ToInt16)] = typeof(short),
            [nameof(Convert.ToInt32)] = typeof(int),
            [nameof(Convert.ToInt64)] = typeof(long),
            [nameof(Convert.ToString)] = typeof(string)
        };

        var result = new Dictionary<MethodInfo, Type>();
        foreach (var (methodName, targetType) in targetTypesByMethodName)
        {
            foreach (var method in typeof(Convert).GetTypeInfo().GetDeclaredMethods(methodName))
            {
                var parameters = method.GetParameters();
                if (parameters.Length == 1 && SupportedSourceTypes.Contains(parameters[0].ParameterType))
                {
                    result[method] = targetType;
                }
            }
        }

        return result;
    }
}
