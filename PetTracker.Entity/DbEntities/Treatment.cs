using PetTracker.Entity.Enums;

namespace PetTracker.Entity.DbEntities;

public class Treatment : BaseEntity
{
    public TreatmentType Type { get; set; }
    public DateTime Date { get; set; }
    public string Vet { get; set; }
    public string Description { get; set; }

    public ICollection<TreatmentDocument> Documents { get; set; }
}