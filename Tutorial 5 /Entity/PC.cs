namespace Tutorial_5.Entity;

public class PCs
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Weight { get; set; }
    public int Warranty { get; set; }
    public DateTime Date { get; set; }
    public int stock { get; set; }
    
    public ICollection<PCComponents> PCsComponents { get; set; }
    
}