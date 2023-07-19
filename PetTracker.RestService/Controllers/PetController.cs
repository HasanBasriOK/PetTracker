using Microsoft.AspNetCore.Mvc;
using PetTracker.Business.Abstraction;
using PetTracker.Entity.DataTransferObjects.Requests;
using PetTracker.Entity.DataTransferObjects.Responses;

namespace PetTracker.RestService.Controllers;

public class PetController : BaseController
{
    private readonly IPetService _petService;

    public PetController(IPetService petService)
    {
        _petService = petService;
    }
    [HttpPost("CreatePet")]
    [ProducesResponseType(statusCode:200,type:typeof(BaseResponse<CreatePetResponse>))]
    public async Task<IActionResult> CreatePet(CreatePetRequest request)
    {
        var result = await _petService.CreatePet(request);
        var response = new BaseResponse<CreatePetResponse>(result.IsSuccess,result.Messages);

        if (!result.IsSuccess)
            return BadRequest(response);
        
        return Ok(response);
    }

}