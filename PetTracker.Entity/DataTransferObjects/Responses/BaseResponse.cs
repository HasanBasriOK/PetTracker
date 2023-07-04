namespace PetTracker.Entity.DataTransferObjects.Responses;

public class BaseResponse<T> where T : class
{
    public T Data { get; set; }
    public bool IsSuccess { get; set; }
    public List<string> Messages { get; set; }

    public BaseResponse(bool isSuccess,List<string> messages)
    {
        this.Messages = new List<string>();
    }
}