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
    
    [HttpPut("UpdatePet")]
    [ProducesResponseType(statusCode:200,type:typeof(BaseResponse<UpdatePetResponse>))]
    public async Task<IActionResult> UpdatePet(UpdatePetRequest request)
    {
        var result = await _petService.UpdatePet(request);
        var response = new BaseResponse<CreatePetResponse>(result.IsSuccess,result.Messages);

        if (!result.IsSuccess)
            return BadRequest(response);
        
        return Ok(response);
    }
    
    [HttpDelete("DeletePet")]
    [ProducesResponseType(statusCode:200,type:typeof(BaseResponse<DeletePetResponse>))]
    public async Task<IActionResult> DeletePet([FromQuery]Guid id)
    {
        var result = await _petService.DeletePet(id);
        var response = new BaseResponse<DeletePetResponse>(result.IsSuccess,result.Messages);

        if (!result.IsSuccess)
            return BadRequest(response);
        
        return Ok(response);
    }

}