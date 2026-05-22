using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tutorial_5.Entity;

namespace Tutorial_5.Configurations;

public class ComponentTypeConfiguration : IEntityTypeConfiguration<ComponentType>
{
    public void Configure(EntityTypeBuilder<ComponentType> builder)
    {
        builder.HasData(new List<ComponentType>
        {
            new ComponentType
            {
                Id = 1,
                Abbreviation = "CPU",
                Name = "Central Processing Unit"
            },
            new ComponentType
            {
                Id = 2,
                Abbreviation = "GPU",
                Name = "Graphics Processing Unit"
            },
            new ComponentType
            {
                Id = 3,
                Abbreviation = "RAM",
                Name = "Random Access Memory"
            }
        });
    }
}