using PetTracker.Entity.DataTransferObjects.Requests;
using PetTracker.Entity.DataTransferObjects.Responses;
using PetTracker.Entity.Messages;

namespace PetTracker.Business.Abstraction;

public interface IUserService
{
    Task<BaseResult<LoginResponse>> Login(LoginRequest request);
    Task<BaseResult<RegisterResponse>> Register(RegisterRequest request);
}