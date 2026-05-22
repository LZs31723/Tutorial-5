using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutorial_5.Entity;

public class ComponentManufactures
{
    [Key]
    public int Id { get; set; }
    [MaxLength(30)]
    [Required]
    public string Abbreviation { get; set; }
    [MaxLength(300)]
    [Required]
    public string FullName { get; set; }
    [Column(TypeName = "date")]
    public DateOnly FoundationDate { get; set; }
    
    public ICollection<Component> Components { get; set; } = [];
}