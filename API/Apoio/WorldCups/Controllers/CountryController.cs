using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorldCups.Dtos.Country;
using WorldCups.Models;
using WorldCups.Services.CountryService;

namespace WorldCups.Controllers;


[ApiController]
[Route("api/[controller]")]
public class CountryController : ControllerBase
{
    public ICountryService _countryService { get; }

    public CountryController(ICountryService countryService)
    {
        _countryService = countryService;
    }

    //[HttpGet("GetAll")]
    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<GetCountryDto>>>> Get()
    {
        return Ok(await _countryService.GetAllCountries());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<GetCountryDto>>> Get(int id)
    {
        return Ok(await _countryService.GetCountryById(id));
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<GetCountryDto>>> Create(AddCountryDto newCountry)
    {
        return Ok(await _countryService.AddCountry(newCountry));
    }

    [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetCountryDto>>> UpdateCharacter(UpdateCountryDto updateCountry)
        {
            var response = await _countryService.UpdateCountry(updateCountry);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCountryDto>>>> Delete(int id)
        {
            var response = await _countryService.DeleteCountry(id);
            if (!response.Success)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
}
