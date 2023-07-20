using PetTracker.Entity.DataTransferObjects.Requests;
using PetTracker.Entity.DataTransferObjects.Responses;
using PetTracker.Entity.Messages;

namespace PetTracker.Business.Abstraction;

public interface IPetService
{
    Task<BaseResult<CreatePetResponse>> CreatePet(CreatePetRequest request);
    Task<BaseResult<UpdatePetResponse>> UpdatePet(UpdatePetRequest request);
}