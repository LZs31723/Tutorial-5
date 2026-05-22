using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tutorial_5.Entity;

namespace Tutorial_5.Configurations;

public class PcCompontentsConfiguration : IEntityTypeConfiguration<PCComponents>
{
    public void Configure(EntityTypeBuilder<PCComponents> builder)
    {
        builder.HasData(new List<PCComponents>
        {
            new PCComponents
            {
                PCId = 1,
                ComponentCode = "CPU0000001",
                Amount = 1
            },
            new PCComponents
            {
                PCId = 1,
                ComponentCode = "GPU0000001",
                Amount = 1
            },
            new PCComponents
            {
                PCId = 2,
                ComponentCode = "RAM0000001",
                Amount = 2
            }
        });
    }
}