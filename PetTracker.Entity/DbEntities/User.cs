using PetTracker.Entity.Enums;

namespace PetTracker.Entity.DbEntities;

public class User : BaseEntity
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public DateTime BirthDate { get; set; }
    public string Password { get; set; }
    public UserState State { get; set; }

    public ICollection<Pet> Pets { get; set; }
}