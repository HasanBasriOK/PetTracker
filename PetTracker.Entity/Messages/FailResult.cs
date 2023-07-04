namespace PetTracker.Entity.Messages;

public class FailResult<T> : BaseResult<T> where T:class
{
    public FailResult(params string[] messages)
    {
        this.Messages = new List<string>();
        this.Messages.AddRange(messages);

        this.IsSuccess = false;
    }
}