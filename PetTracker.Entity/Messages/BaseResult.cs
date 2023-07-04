namespace PetTracker.Entity.Messages;

public class BaseResult<T>  where T: class
{
    public T Data { get; set; }
    public bool IsSuccess { get; set; }
    public List<string> Messages { get; set; }
}