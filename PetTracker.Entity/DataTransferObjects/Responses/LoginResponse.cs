namespace PetTracker.Entity.DataTransferObjects.Responses;

public class LoginResponse
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
    public string Email { get; set; }
    public Guid UserId { get; set; }
}