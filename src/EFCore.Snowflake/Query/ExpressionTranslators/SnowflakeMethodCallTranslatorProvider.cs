using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Storage;

namespace EFCore.Snowflake.Query.ExpressionTranslators;

public class SnowflakeMethodCallTranslatorProvider : RelationalMethodCallTranslatorProvider
{
    public SnowflakeMethodCallTranslatorProvider(
        RelationalMethodCallTranslatorProviderDependencies dependencies,
        IRelationalTypeMappingSource typeMappingSource)
        : base(dependencies)
    {
        ISqlExpressionFactory sqlExpressionFactory = dependencies.SqlExpressionFactory;

        AddTranslators(new IMethodCallTranslator[]
        {
            new SnowflakeByteArrayMethodTranslator(sqlExpressionFactory),
            new SnowflakeConvertTranslator(sqlExpressionFactory, typeMappingSource),
            new SnowflakeDateDiffFunctionsTranslator(sqlExpressionFactory),
            new SnowflakeDateOnlyMethodTranslator(sqlExpressionFactory),
            new SnowflakeDateTimeMethodTranslator(sqlExpressionFactory),
            new SnowflakeFromPartsFunctionTranslator(sqlExpressionFactory, typeMappingSource),
            new SnowflakeMathTranslator(sqlExpressionFactory),
            new SnowflakeObjectToStringTranslator(sqlExpressionFactory),
            new SnowflakeRegexIsMatchTranslator(sqlExpressionFactory),
            new SnowflakeStringMethodTranslator(sqlExpressionFactory),
            new SnowflakeTimeOnlyMethodTranslator(sqlExpressionFactory)
        });
    }
}
