using Microsoft.EntityFrameworkCore.Diagnostics;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore;

/// <summary>
/// Provides CLR methods that get translated to Snowflake database functions when used in LINQ queries.
/// The methods on this class are accessed via <see cref="EF.Functions" />.
/// </summary>
public static class SnowflakeDbFunctionsExtensions
{
    #region DateDiffYear

    public static int DateDiffYear(this DbFunctions _, DateTime startDate, DateTime endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffYear)));

    public static int? DateDiffYear(this DbFunctions _, DateTime? startDate, DateTime? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffYear)));

    public static int DateDiffYear(this DbFunctions _, DateTimeOffset startDate, DateTimeOffset endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffYear)));

    public static int? DateDiffYear(this DbFunctions _, DateTimeOffset? startDate, DateTimeOffset? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffYear)));

    public static int DateDiffYear(this DbFunctions _, DateOnly startDate, DateOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffYear)));

    public static int? DateDiffYear(this DbFunctions _, DateOnly? startDate, DateOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffYear)));

    #endregion DateDiffYear

    #region DateDiffMonth

    public static int DateDiffMonth(this DbFunctions _, DateTime startDate, DateTime endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMonth)));

    public static int? DateDiffMonth(this DbFunctions _, DateTime? startDate, DateTime? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMonth)));

    public static int DateDiffMonth(this DbFunctions _, DateTimeOffset startDate, DateTimeOffset endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMonth)));

    public static int? DateDiffMonth(this DbFunctions _, DateTimeOffset? startDate, DateTimeOffset? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMonth)));

    public static int DateDiffMonth(this DbFunctions _, DateOnly startDate, DateOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMonth)));

    public static int? DateDiffMonth(this DbFunctions _, DateOnly? startDate, DateOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMonth)));

    #endregion DateDiffMonth

    #region DateDiffDay

    public static int DateDiffDay(this DbFunctions _, DateTime startDate, DateTime endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffDay)));

    public static int? DateDiffDay(this DbFunctions _, DateTime? startDate, DateTime? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffDay)));

    public static int DateDiffDay(this DbFunctions _, DateTimeOffset startDate, DateTimeOffset endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffDay)));

    public static int? DateDiffDay(this DbFunctions _, DateTimeOffset? startDate, DateTimeOffset? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffDay)));

    public static int DateDiffDay(this DbFunctions _, DateOnly startDate, DateOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffDay)));

    public static int? DateDiffDay(this DbFunctions _, DateOnly? startDate, DateOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffDay)));

    #endregion DateDiffDay

    #region DateDiffHour

    public static int DateDiffHour(this DbFunctions _, DateTime startDate, DateTime endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffHour)));

    public static int? DateDiffHour(this DbFunctions _, DateTime? startDate, DateTime? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffHour)));

    public static int DateDiffHour(this DbFunctions _, DateTimeOffset startDate, DateTimeOffset endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffHour)));

    public static int? DateDiffHour(this DbFunctions _, DateTimeOffset? startDate, DateTimeOffset? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffHour)));

    public static int DateDiffHour(this DbFunctions _, TimeSpan startDate, TimeSpan endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffHour)));

    public static int? DateDiffHour(this DbFunctions _, TimeSpan? startDate, TimeSpan? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffHour)));

    public static int DateDiffHour(this DbFunctions _, TimeOnly startDate, TimeOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffHour)));

    public static int? DateDiffHour(this DbFunctions _, TimeOnly? startDate, TimeOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffHour)));

    public static int DateDiffHour(this DbFunctions _, DateOnly startDate, DateOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffHour)));

    public static int? DateDiffHour(this DbFunctions _, DateOnly? startDate, DateOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffHour)));

    #endregion DateDiffHour

    #region DateDiffMinute

    public static int DateDiffMinute(this DbFunctions _, DateTime startDate, DateTime endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMinute)));

    public static int? DateDiffMinute(this DbFunctions _, DateTime? startDate, DateTime? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMinute)));

    public static int DateDiffMinute(this DbFunctions _, DateTimeOffset startDate, DateTimeOffset endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMinute)));

    public static int? DateDiffMinute(this DbFunctions _, DateTimeOffset? startDate, DateTimeOffset? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMinute)));

    public static int DateDiffMinute(this DbFunctions _, TimeSpan startDate, TimeSpan endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMinute)));

    public static int? DateDiffMinute(this DbFunctions _, TimeSpan? startDate, TimeSpan? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMinute)));

    public static int DateDiffMinute(this DbFunctions _, TimeOnly startDate, TimeOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMinute)));

    public static int? DateDiffMinute(this DbFunctions _, TimeOnly? startDate, TimeOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMinute)));

    public static int DateDiffMinute(this DbFunctions _, DateOnly startDate, DateOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMinute)));

    public static int? DateDiffMinute(this DbFunctions _, DateOnly? startDate, DateOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMinute)));

    #endregion DateDiffMinute

    #region DateDiffSecond

    public static int DateDiffSecond(this DbFunctions _, DateTime startDate, DateTime endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffSecond)));

    public static int? DateDiffSecond(this DbFunctions _, DateTime? startDate, DateTime? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffSecond)));

    public static int DateDiffSecond(this DbFunctions _, DateTimeOffset startDate, DateTimeOffset endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffSecond)));

    public static int? DateDiffSecond(this DbFunctions _, DateTimeOffset? startDate, DateTimeOffset? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffSecond)));

    public static int DateDiffSecond(this DbFunctions _, TimeSpan startDate, TimeSpan endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffSecond)));

    public static int? DateDiffSecond(this DbFunctions _, TimeSpan? startDate, TimeSpan? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffSecond)));

    public static int DateDiffSecond(this DbFunctions _, TimeOnly startDate, TimeOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffSecond)));

    public static int? DateDiffSecond(this DbFunctions _, TimeOnly? startDate, TimeOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffSecond)));

    public static int DateDiffSecond(this DbFunctions _, DateOnly startDate, DateOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffSecond)));

    public static int? DateDiffSecond(this DbFunctions _, DateOnly? startDate, DateOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffSecond)));

    #endregion DateDiffSecond

    #region DateDiffMillisecond

    public static int DateDiffMillisecond(this DbFunctions _, DateTime startDate, DateTime endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMillisecond)));

    public static int? DateDiffMillisecond(this DbFunctions _, DateTime? startDate, DateTime? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMillisecond)));

    public static int DateDiffMillisecond(this DbFunctions _, DateTimeOffset startDate, DateTimeOffset endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMillisecond)));

    public static int? DateDiffMillisecond(this DbFunctions _, DateTimeOffset? startDate, DateTimeOffset? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMillisecond)));

    public static int DateDiffMillisecond(this DbFunctions _, TimeSpan startDate, TimeSpan endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMillisecond)));

    public static int? DateDiffMillisecond(this DbFunctions _, TimeSpan? startDate, TimeSpan? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMillisecond)));

    public static int DateDiffMillisecond(this DbFunctions _, TimeOnly startDate, TimeOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMillisecond)));

    public static int? DateDiffMillisecond(this DbFunctions _, TimeOnly? startDate, TimeOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMillisecond)));

    public static int DateDiffMillisecond(this DbFunctions _, DateOnly startDate, DateOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMillisecond)));

    public static int? DateDiffMillisecond(this DbFunctions _, DateOnly? startDate, DateOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMillisecond)));

    #endregion DateDiffMillisecond

    #region DateDiffMicrosecond

    public static int DateDiffMicrosecond(this DbFunctions _, DateTime startDate, DateTime endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMicrosecond)));

    public static int? DateDiffMicrosecond(this DbFunctions _, DateTime? startDate, DateTime? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMicrosecond)));

    public static int DateDiffMicrosecond(this DbFunctions _, DateTimeOffset startDate, DateTimeOffset endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMicrosecond)));

    public static int? DateDiffMicrosecond(this DbFunctions _, DateTimeOffset? startDate, DateTimeOffset? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMicrosecond)));

    public static int DateDiffMicrosecond(this DbFunctions _, TimeSpan startDate, TimeSpan endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMicrosecond)));

    public static int? DateDiffMicrosecond(this DbFunctions _, TimeSpan? startDate, TimeSpan? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMicrosecond)));

    public static int DateDiffMicrosecond(this DbFunctions _, TimeOnly startDate, TimeOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMicrosecond)));

    public static int? DateDiffMicrosecond(this DbFunctions _, TimeOnly? startDate, TimeOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMicrosecond)));

    public static int DateDiffMicrosecond(this DbFunctions _, DateOnly startDate, DateOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMicrosecond)));

    public static int? DateDiffMicrosecond(this DbFunctions _, DateOnly? startDate, DateOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffMicrosecond)));

    #endregion DateDiffMicrosecond

    #region DateDiffNanosecond

    public static int DateDiffNanosecond(this DbFunctions _, DateTime startDate, DateTime endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffNanosecond)));

    public static int? DateDiffNanosecond(this DbFunctions _, DateTime? startDate, DateTime? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffNanosecond)));

    public static int DateDiffNanosecond(this DbFunctions _, DateTimeOffset startDate, DateTimeOffset endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffNanosecond)));

    public static int? DateDiffNanosecond(this DbFunctions _, DateTimeOffset? startDate, DateTimeOffset? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffNanosecond)));

    public static int DateDiffNanosecond(this DbFunctions _, TimeSpan startDate, TimeSpan endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffNanosecond)));

    public static int? DateDiffNanosecond(this DbFunctions _, TimeSpan? startDate, TimeSpan? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffNanosecond)));

    public static int DateDiffNanosecond(this DbFunctions _, TimeOnly startDate, TimeOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffNanosecond)));

    public static int? DateDiffNanosecond(this DbFunctions _, TimeOnly? startDate, TimeOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffNanosecond)));

    public static int DateDiffNanosecond(this DbFunctions _, DateOnly startDate, DateOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffNanosecond)));

    public static int? DateDiffNanosecond(this DbFunctions _, DateOnly? startDate, DateOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffNanosecond)));

    #endregion DateDiffNanosecond

    #region DateDiffWeek

    public static int DateDiffWeek(this DbFunctions _, DateTime startDate, DateTime endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffWeek)));

    public static int? DateDiffWeek(this DbFunctions _, DateTime? startDate, DateTime? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffWeek)));

    public static int DateDiffWeek(this DbFunctions _, DateTimeOffset startDate, DateTimeOffset endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffWeek)));

    public static int? DateDiffWeek(this DbFunctions _, DateTimeOffset? startDate, DateTimeOffset? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffWeek)));

    public static int DateDiffWeek(this DbFunctions _, DateOnly startDate, DateOnly endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffWeek)));

    public static int? DateDiffWeek(this DbFunctions _, DateOnly? startDate, DateOnly? endDate)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateDiffWeek)));

    #endregion DateDiffWeek

    #region DateFromParts

    public static DateOnly DateFromParts(this DbFunctions _, int year, int month, int day)
        => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(DateFromParts)));

    #endregion DateFromParts
}
