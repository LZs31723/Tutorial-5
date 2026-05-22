using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tutorial_5.Entity;

namespace Tutorial_5.Configurations;

public class PcConfiguration : IEntityTypeConfiguration<PC>
{
    public void Configure(EntityTypeBuilder<PC> builder)
    {
        builder.HasData(new List<PC>
        {
            new PC
            {
                Id = 1,
                Name = "Gaming Beast X",
                Weight = 12.5f,
                Warranty = 36,
                CreatedAt = new DateTime(2026, 5, 8, 9, 0, 0),
                Stock = 5
            },
            new PC
            {
                Id = 2,
                Name = "Office Mini Pro",
                Weight = 4.2f,
                Warranty = 24,
                CreatedAt = new DateTime(2026, 4, 15, 13, 30, 0),
                Stock = 12
            },
            new PC
            {
                Id = 3,
                Name = "Workstation Pro",
                Weight = 15.0f,
                Warranty = 48,
                CreatedAt = new DateTime(2026, 3, 10, 10, 15, 0),
                Stock = 8
            }
        });
    }
}