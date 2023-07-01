using System.ComponentModel.DataAnnotations.Schema;
using PetTracker.Entity.Enums;

namespace PetTracker.Entity.DbEntities;

public class Pet : BaseEntity
{
    public string Name { get; set; }
    public PetType Type { get; set; }
    public PetGender Gender { get; set; }
    public PetKind Kind { get; set; }
    public DateTime BirthDate { get; set; }
    [ForeignKey("Owner")]
    public Guid OwnerId { get; set; }
    public User Owner { get; set; }
}