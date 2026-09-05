using System.Text.RegularExpressions;
using EFCore.Snowflake.FunctionalTests.TestUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.TestUtilities;

namespace EFCore.Snowflake.FunctionalTests.Query;

public class FunctionsQueryTest : IClassFixture<FunctionsQueryTest.FunctionsQueryFixture>
{
    public FunctionsQueryTest(FunctionsQueryFixture fixture)
    {
        Fixture = fixture;
    }

    protected FunctionsQueryFixture Fixture { get; }

    [ConditionalFact]
    public virtual void Regex_IsMatch()
    {
        using FunctionsQueryContext context = CreateContext();
        TableItem item = context.TableItems.Single(i => Regex.IsMatch(i.Value, "^T.*$"));
        Assert.Equal(1, item.Id);
    }

    [ConditionalFact]
    public virtual void Regex_IsMatch_Returns_No_Results_When_Not_Matching()
    {
        using FunctionsQueryContext context = CreateContext();
        bool any = context.TableItems.Any(i => Regex.IsMatch(i.Value, "^Z.*$"));
        Assert.False(any);
    }

    protected FunctionsQueryContext CreateContext() => Fixture.CreateContext();

    public class TableItem
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
    }

    public class FunctionsQueryContext : PoolableDbContext
    {
        public FunctionsQueryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<TableItem> TableItems { get; set; } = null!;
    }

    public class FunctionsQueryFixture : SharedStoreFixtureBase<FunctionsQueryContext>
    {
        protected override async Task SeedAsync(FunctionsQueryContext context)
        {
            context.AddRange(
                new TableItem { Id = 1, Value = "TOMSB" },
                new TableItem { Id = 2, Value = "ALFKI" });

            await context.SaveChangesAsync();
        }

        protected override string StoreName => "FunctionsQuery";
        protected override ITestStoreFactory TestStoreFactory
            => SnowflakeTestStoreFactory.Instance;
    }
}
