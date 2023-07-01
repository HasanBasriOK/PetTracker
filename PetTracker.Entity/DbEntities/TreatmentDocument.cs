using System.ComponentModel.DataAnnotations.Schema;

namespace PetTracker.Entity.DbEntities;

public class TreatmentDocument : BaseEntity
{
    public string Path { get; set; }
    [ForeignKey("Treatment")]
    public Guid TreatmentId { get; set; }
    public Treatment Treatment { get; set; }
}