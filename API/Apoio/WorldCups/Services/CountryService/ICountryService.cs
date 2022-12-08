using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCups.Dtos.Country;
using WorldCups.Models;

namespace WorldCups.Services.CountryService
{
    public interface ICountryService
    {
        Task<ServiceResponse<List<GetCountryDto>>> GetAllCountries();

        Task<ServiceResponse<GetCountryDto>> GetCountryById(int id);

        Task<ServiceResponse<GetCountryDto>> AddCountry(AddCountryDto newCountry);

        Task<ServiceResponse<GetCountryDto>> UpdateCountry(UpdateCountryDto updateCountry);

        Task<ServiceResponse<GetCountryDto>> DeleteCountry(int id);
    }
}