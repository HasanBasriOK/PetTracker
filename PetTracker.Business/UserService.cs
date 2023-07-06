using Microsoft.EntityFrameworkCore;
using PetTracker.Business.Abstraction;
using PetTracker.DataAccess.EntityRepositories.Abstraction;
using PetTracker.Entity.Constants;
using PetTracker.Entity.DataTransferObjects.Requests;
using PetTracker.Entity.DataTransferObjects.Responses;
using PetTracker.Entity.DbEntities;
using PetTracker.Entity.Enums;
using PetTracker.Entity.Messages;
using PetTracker.Utilities;

namespace PetTracker.Business;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    { 
        _userRepository = userRepository;
    }

    public async Task<BaseResult<LoginResponse>> Login(LoginRequest request)
    {
        var decryptedClientPassword = Encrypter.Decrypt(request.Password, CryptoConstants.ClientEncryptionKey);
        var encryptedServerPassword = Encrypter.Encrypt(decryptedClientPassword, CryptoConstants.ServerEncryptionKey);
        var user = await _userRepository.Where(x => x.Email == request.Username && x.Password == encryptedServerPassword)
            .FirstOrDefaultAsync();

        if (user == null)
            return new FailResult<LoginResponse>(ApplicationMessageContants.UserNotFound);
        
        var loginResponse = new LoginResponse();
        loginResponse.Email = user.Email;
        loginResponse.UserId = user.Id;
        loginResponse.Name = user.Name;
        return new SuccessResult<LoginResponse>(loginResponse);
    }

    public async Task<BaseResult<RegisterResponse>> Register(RegisterRequest request)
    {
        var user = new User();
        user.Email = request.Email;
        user.Phone = request.Phone;
        user.State = UserState.Passive;
        user.BirthDate = request.BirthDate;
        user.CreatedDate = DateTime.Now;
        
        var decryptedClientPassword = Encrypter.Decrypt(request.Password, CryptoConstants.ClientEncryptionKey);
        var encryptedServerPassword = Encrypter.Encrypt(decryptedClientPassword, CryptoConstants.ServerEncryptionKey);
        user.Password = encryptedServerPassword;

        var createdUser = await _userRepository.AddAsync(user);
        var registerResponse = new RegisterResponse();
        registerResponse.UserId = createdUser.Id;

        return new SuccessResult<RegisterResponse>(registerResponse);
    }
}