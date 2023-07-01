namespace PetTracker.Entity.DbEntities;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool IsDeleted { get; set; }
    public string Label { get; set; }
}