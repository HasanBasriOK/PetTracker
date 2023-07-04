
namespace PetTracker.Entity.Messages;

public class SuccessResult<T> : BaseResult<T> where T:class
{
    public SuccessResult(T data = default)
    {
        this.IsSuccess = true;
        this.Data = data;
    }
}