using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tutorial_5.Entity;

public class ComponentType
{
    [Key]
    public int Id { get; set; }
    [MaxLength(30)]
    [Required]
    public string Abbreviation { get; set; }
    [MaxLength(150)]
    [Required]
    public string Name { get; set; }

    public ICollection<Component> Components { get; set; } = [];

}