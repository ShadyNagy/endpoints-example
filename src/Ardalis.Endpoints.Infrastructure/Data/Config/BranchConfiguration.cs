using Ardalis.Endpoints.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ardalis.Endpoints.Infrastructure.Data.Config
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branches").HasKey(x => x.BranchId);

            builder.Property(c => c.Name)
                .HasMaxLength(ColumnConstants.DEFAULT_NAME_LENGTH);

            builder.Property(c => c.CompanyId);
        }
    }
}
