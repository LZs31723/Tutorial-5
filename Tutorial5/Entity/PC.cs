using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutorial_5.Entity;

public class PC
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    [Required]
    public string Name { get; set; }
    [MaxLength(5)]
    public float Weight { get; set; }
    public int Warranty { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }
    public int Stock { get; set; }

    public ICollection<PCComponents> PCsComponents { get; set; } = [];

}