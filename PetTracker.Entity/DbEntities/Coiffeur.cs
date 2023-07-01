using System.ComponentModel.DataAnnotations.Schema;
using PetTracker.Entity.Enums;

namespace PetTracker.Entity.DbEntities;

public class Coiffeur : BaseEntity
{
    [ForeignKey("Pet")]
    public Guid PetId { get; set; }
    public Pet Pet { get; set; }
    public DateTime Date { get; set; }
    public CoiffeurOperationType OperationType { get; set; }
    public string CoiffeurName { get; set; }
    public string Comment { get; set; }
}