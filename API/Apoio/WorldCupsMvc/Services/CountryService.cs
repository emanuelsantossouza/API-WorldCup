using WorldCupsMvc.Models;
using WorldCupsMvc.Models.Dtos.Country;
using WorldCupsMvc.Services.IServices;

namespace WorldCupsMvc.Services
{
    public class CountryService : BaseService, ICountryService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string countryUrl;

        public CountryService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            countryUrl = configuration.GetValue<string>("ServiceUrl:WorldCupAPI");
        }
        public Task<T> Create<T>(AddCountryDto dto)
        {
            return SendAsync<T>(new ServiceRequest()
            {
                ApiType = ApiType.POST,
                Data = dto,
                Url = countryUrl + "/api/Country"
            });
        }

        public Task<T> Delete<T>(int id)
        {
            return SendAsync<T>(new ServiceRequest()
            {
                ApiType = ApiType.DELETE,
                Url = countryUrl + "/api/Country/" + id
            });
        }

        public Task<T> GetAll<T>()
        {
            return SendAsync<T>(new ServiceRequest()
            {
                ApiType = ApiType.GET,
                Url = countryUrl + "/api/Country"
            });
        }

        public Task<T> GetById<T>(int id)
        {
            return SendAsync<T>(new ServiceRequest()
            {
                ApiType = ApiType.GET,
                Url = countryUrl + "/api/Country/" + id
            });
        }

        public Task<T> Update<T>(UpdateCountryDto dto)
        {
            return SendAsync<T>(new ServiceRequest()
            {
                ApiType = ApiType.PUT,
                Data = dto,
                Url = countryUrl + "/api/Country"
            });
        }
    }
}