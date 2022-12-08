using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WorldCups.Data;
using WorldCups.Dtos.Country;
using WorldCups.Models;

namespace WorldCups.Services.CountryService
{
    public class CountryService : ICountryService
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _db;
        public CountryService(IMapper mapper, AppDbContext db)
        {
            _db = db;
            _mapper = mapper;
            
        }

        public async Task<ServiceResponse<GetCountryDto>> AddCountry(AddCountryDto newCountry)
        {
            var response = new ServiceResponse<GetCountryDto>();
            Country country = _mapper.Map<Country>(newCountry);
            await _db.Countries.AddAsync(country);
            await _db.SaveChangesAsync();
            response.Data = _mapper.Map<GetCountryDto>(country);
            return response;
        }

        public async Task<ServiceResponse<GetCountryDto>> DeleteCountry(int id)
        {
            var response = new ServiceResponse<GetCountryDto>();
            try
            {
                Country country = await _db.Countries
                    .FirstOrDefaultAsync(c => c.Id == id);
                if (country != null)
                {
                    _db.Countries.Remove(country);
                    await _db.SaveChangesAsync();
                    response.Data = null;
                    response.Message = "País Excluído com Sucesso";
                }
                else
                {
                    response.Success = false;
                    response.Message = "País não encontrado";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetCountryDto>>> GetAllCountries()
        {
            var response = new ServiceResponse<List<GetCountryDto>>();
            var countries = await _db.Countries
                .Include(c => c.WorldCups)
                .ToListAsync();
            response.Data = _mapper.Map<List<GetCountryDto>>(countries);
            return response;
        }

        public async Task<ServiceResponse<GetCountryDto>> GetCountryById(int id)
        {
            var response = new ServiceResponse<GetCountryDto>();
            var country = await _db.Countries
                .Include(c => c.WorldCups)
                .FirstOrDefaultAsync(c => c.Id == id);
            response.Data = _mapper.Map<GetCountryDto>(country);
            return response;
        }

        public async Task<ServiceResponse<GetCountryDto>> UpdateCountry(UpdateCountryDto updateCountry)
        {
            var response = new ServiceResponse<GetCountryDto>();
            try
            {
                Country country = await _db.Countries
                    .FirstOrDefaultAsync(c => c.Id == updateCountry.Id);
                if (country != null)
                {
                    country.Name = updateCountry.Name;
                    country.Flag = updateCountry.Flag;
                    await _db.SaveChangesAsync();
                    response.Data = _mapper.Map<GetCountryDto>(country);
                }
                else
                {
                    response.Success = false;
                    response.Message = "País não encontrado";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}