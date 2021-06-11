using Ardalis.Endpoints.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ardalis.Endpoints.Infrastructure.Data.Config
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Companies").HasKey(x => x.CompanyId);

            builder.Property(c => c.Name)
                .HasMaxLength(ColumnConstants.DEFAULT_NAME_LENGTH);
        }
    }
}
