using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutorial_5.Entity;

public class Component
{
    [Column(TypeName = "char(10)")]
    [Key]
    public string Code { get; set; }

    [MaxLength(300)]
    [Required]
    public string Name { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string Description { get; set; }

    public int ComponentManufacturersId { get; set; }

    [ForeignKey(nameof(ComponentManufacturersId))]
    public ComponentManufactures ComponentManufactures { get; set; }

    public int ComponentTypesId { get; set; }

    [ForeignKey(nameof(ComponentTypesId))]
    public ComponentType ComponentType { get; set; }

    public ICollection<PCComponents> PCsComponents { get; set; } = [];
}