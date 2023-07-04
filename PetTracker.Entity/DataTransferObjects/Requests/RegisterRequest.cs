namespace PetTracker.Entity.DataTransferObjects.Requests;

public class RegisterRequest
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public DateTime BirthDate { get; set; }
}