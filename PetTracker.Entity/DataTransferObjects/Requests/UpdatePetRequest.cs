using PetTracker.Entity.Enums;

namespace PetTracker.Entity.DataTransferObjects.Requests;

public class UpdatePetRequest
{
    public Guid PetId { get; set; }
    public string Name { get; set; }
    public PetType Type { get; set; }
    public PetGender Gender { get; set; }
    public PetKind Kind { get; set; }
    public DateTime BirthDate { get; set; }
    public byte[]? ImageFile { get; set; } 
    public ImageExtension ImageExtension { get; set; }
}