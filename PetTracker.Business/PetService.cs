using System.Drawing;
using System.Net.Mime;
using Microsoft.Extensions.Configuration;
using PetTracker.Business.Abstraction;
using PetTracker.DataAccess.EntityRepositories.Abstraction;
using PetTracker.Entity.Constants;
using PetTracker.Entity.DataTransferObjects.Requests;
using PetTracker.Entity.DataTransferObjects.Responses;
using PetTracker.Entity.DbEntities;
using PetTracker.Entity.Enums;
using PetTracker.Entity.Messages;

namespace PetTracker.Business;

public class PetService : IPetService
{
    private readonly IPetRepository _petRepository;
    private readonly IConfiguration _configuration;

    public PetService(IPetRepository petRepository,IConfiguration configuration)
    {
        _petRepository = petRepository;
        _configuration = configuration;
    }

    public async Task<BaseResult<CreatePetResponse>> CreatePet(CreatePetRequest request)
    {
        var pet = new Pet();
        pet.Id = new Guid();
        pet.Gender = request.Gender;
        pet.Kind = request.Kind;
        pet.Name = request.Name;
        pet.Type = request.Type;
        pet.BirthDate = request.BirthDate;
        pet.ImagePath = SavePetImage(pet.Id, request.ImageFile, request.ImageExtension);
        pet.OwnerId = request.OwnerId;
        pet.CreatedDate = DateTime.Now;

        var createdPet = await _petRepository.AddAsync(pet);
        var response = new SuccessResult<CreatePetResponse>(new CreatePetResponse());
        response.Messages.Add(ApplicationMessageConstants.PetCreatedSuccessfully);

        return response;
    }

    public async Task<BaseResult<UpdatePetResponse>> UpdatePet(UpdatePetRequest request)
    {
        var pet = await _petRepository.GetById(request.PetId);

        if (pet == null)
            return new FailResult<UpdatePetResponse>(ApplicationMessageConstants.PetCouldntFount);

        pet.Gender = request.Gender;
        pet.Kind = request.Kind;
        pet.Name = request.Name;
        pet.Type = request.Type;
        pet.BirthDate = request.BirthDate;
        
        if(request.ImageFile != null)
            pet.ImagePath = SavePetImage(pet.Id, request.ImageFile, request.ImageExtension);
        
        _petRepository.Update(pet);

        var response = new SuccessResult<UpdatePetResponse>(new UpdatePetResponse());
        response.Messages.Add(ApplicationMessageConstants.PetUpdatedSuccessfully);

        return response;
    }

    private string SavePetImage(Guid petId,byte[] image,ImageExtension extension)
    {
        MemoryStream ms = new MemoryStream(image);
        System.Drawing.Image imageFile = System.Drawing.Image.FromStream(ms);
        var imageName = $"{petId}{extension.ToString()}";
        var imagePath = Path.Combine(_configuration.GetSection("ImagePath").Value!, imageName );
        
        if(File.Exists(imagePath))
            imagePath = Path.Combine(_configuration.GetSection("ImagePath").Value!, imageName + DateTime.Now.ToString("yyyyMMddHHmmss"));
        
        imageFile.Save(imagePath);

        return imagePath;
    }
}