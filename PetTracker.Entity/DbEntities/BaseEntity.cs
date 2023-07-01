using System.ComponentModel.DataAnnotations;

namespace PetTracker.Entity.DbEntities;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool IsDeleted { get; set; }
    public string Label { get; set; }
}