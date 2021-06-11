using System;
using System.Threading.Tasks;
using Ardalis.Endpoints.Core.Entities;
using Ardalis.Endpoints.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Ardalis.Endpoints.Examples
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            await using var dbContext = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());
            PopulateTestData(dbContext);

            if (!await dbContext.Companies.AnyAsync(x => x.CompanyId == Guid.Parse("b451745c-d070-41a4-b7a8-c1ebeb3cf666")))
            {
                await dbContext.Companies.AddAsync(new Company(Guid.Parse("b451745c-d070-41a4-b7a8-c1ebeb3cf666"), "Test Company1"));
                await dbContext.SaveChangesAsync();
            }

            if (!await dbContext.Branches.AnyAsync(x => x.BranchId == Guid.Parse("6cc031cd-627f-40b3-a28d-d80631313fcb")))
            {
                await dbContext.Branches.AddAsync(new Branch(Guid.Parse("6cc031cd-627f-40b3-a28d-d80631313fcb"),
                    Guid.Parse("b451745c-d070-41a4-b7a8-c1ebeb3cf666"), "Test Branch1"));
                await dbContext.SaveChangesAsync();
            }
        }

        public static void PopulateTestData(AppDbContext dbContext)
        {
            dbContext.SaveChanges();
        }
    }
}
