using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tutorial_5.Entity;

namespace Tutorial_5.Configurations;

public class CompontentConfiguration : IEntityTypeConfiguration<Component>
{
    public void Configure(EntityTypeBuilder<Component> builder)
    {
        builder.HasData(new List<Component>
        {
            new Component
            {
                Code = "CPU0000001",
                Name = "Intel Core i9-13900K",
                Description = "24-core (8P+16E) desktop processor, up to 5.8 GHz",
                ComponentManufacturersId = 1,
                ComponentTypesId = 1
            },
            new Component
            {
                Code = "GPU0000001",
                Name = "NVIDIA GeForce RTX 4090",
                Description = "Flagship Ada Lovelace GPU with 24 GB GDDR6X memory",
                ComponentManufacturersId = 3,
                ComponentTypesId = 2
            },
            new Component
            {
                Code = "RAM0000001",
                Name = "AMD Radeon DDR5 32GB 6000MHz",
                Description = "Dual-channel DDR5 memory kit, 2x16GB, CL30",
                ComponentManufacturersId = 2,
                ComponentTypesId = 3
            }
        });
    }
}