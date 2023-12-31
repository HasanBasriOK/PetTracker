using PetTracker.Entity.Enums;

namespace PetTracker.Entity.DataTransferObjects.Requests;

public class CreatePetRequest
{
    public string Name { get; set; }
    public PetType Type { get; set; }
    public PetGender Gender { get; set; }
    public PetKind Kind { get; set; }
    public DateTime BirthDate { get; set; }
    public Guid OwnerId { get; set; }
    public byte[] ImageFile { get; set; }
    public ImageExtension ImageExtension { get; set; }

}