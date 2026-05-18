using System.ComponentModel;

namespace Tutorial_5.Entity;

public class Components
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int ComponentManufacturersId { get; set; }
    public int ComponentTypesId { get; set; }

    public ICollection<PCComponents> PCsComponents { get; set; } = [];
    
}