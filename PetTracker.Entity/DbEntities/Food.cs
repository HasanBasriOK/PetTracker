namespace PetTracker.Entity.DbEntities;

public class Food : BaseEntity
{
    public string Brand { get; set; }
    public DateTime StartOfUseDate { get; set; }
    public string Description { get; set; }
    public string Comment { get; set; }
    public double Rate { get; set; }
}