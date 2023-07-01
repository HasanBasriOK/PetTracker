using PetTracker.Entity.Enums;

namespace PetTracker.Entity.DbEntities;

public class Vaccine : BaseEntity
{
    public DateTime Date { get; set; }
    public VaccineType Type { get; set; }
    public string Description { get; set; }
    public string Vet { get; set; }
}