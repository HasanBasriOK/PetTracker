using System.ComponentModel.DataAnnotations.Schema;

namespace PetTracker.Entity.DbEntities;

public class MedicineDocument : BaseEntity
{
    public string Path { get; set; }
    [ForeignKey("Medicine")]
    public Guid MedicineId { get; set; }
    public Medicine Medicine { get; set; }
}