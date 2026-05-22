using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Tutorial_5.Entity;


[PrimaryKey(nameof(PCId), nameof(ComponentCode))]
public class PCComponents
{

    public int PCId { get; set; }
    [Column(TypeName = "char(10)")]
    public string ComponentCode { get; set; }
    public int Amount { get; set; }
    [ForeignKey(nameof(PCId))]
    public PC Pc { get; set; }
    [ForeignKey(nameof(ComponentCode))]
    public Component Component { get; set; }
}