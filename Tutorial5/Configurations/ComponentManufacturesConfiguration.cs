using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tutorial_5.Entity;

namespace Tutorial_5.Configurations;

public class ComponentManufacturesConfiguration : IEntityTypeConfiguration<ComponentManufactures>
{
    public void Configure(EntityTypeBuilder<ComponentManufactures> builder)
    {
        builder.HasData(new List<ComponentManufactures>
        {
            new ComponentManufactures
            {
                Id = 1,
                Abbreviation = "Intel",
                FullName = "Intel Corporation",
                FoundationDate = new DateOnly(1968, 7, 18)
            },
            new ComponentManufactures
            {
                Id = 2,
                Abbreviation = "AMD",
                FullName = "Advanced Micro Devices, Inc.",
                FoundationDate = new DateOnly(1969, 5, 1)
            },
            new ComponentManufactures
            {
                Id = 3,
                Abbreviation = "NVIDIA",
                FullName = "NVIDIA Corporation",
                FoundationDate = new DateOnly(1993, 4, 5)
            }
        });
    }
    
}