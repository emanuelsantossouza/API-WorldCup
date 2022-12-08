using System.Text;
using Newtonsoft.Json;
using WorldCupsMvc.Models;
using WorldCupsMvc.Services.IServices;

namespace WorldCupsMvc.Services;

public class BaseService : IBaseService
{
    public ServiceRequest responseModel { get; set; }
    private readonly IHttpClientFactory _httpClient;

    public BaseService(IHttpClientFactory httpClient)
    {
        this.responseModel = new();
        _httpClient = httpClient;
    }

    public async Task<T> SendAsync<T>(ServiceRequest serviceRequest)
    {
        try
        {
            var client = _httpClient.CreateClient("WorldCupsAPI");
            HttpRequestMessage message = new HttpRequestMessage();
            message.Headers.Add("Accept", "application/json");
            message.RequestUri = new Uri(serviceRequest.Url);
            if (serviceRequest.Data != null)
            {
                message.Content = new StringContent(JsonConvert.SerializeObject(serviceRequest.Data),
                    Encoding.UTF8, "application/json");
            }
            switch (serviceRequest.ApiType)
            {
                case ApiType.DELETE:
                    message.Method = HttpMethod.Delete;
                    break;
                case ApiType.POST:
                    message.Method = HttpMethod.Post;
                    break;
                case ApiType.PUT:
                    message.Method = HttpMethod.Put;
                    break;
                default:
                    message.Method = HttpMethod.Get;
                    break;
            }
            HttpResponseMessage apiReponse = null;
            apiReponse = await client.SendAsync(message);
            var apiContent = await apiReponse.Content.ReadAsStringAsync();
            var APIReponse = JsonConvert.DeserializeObject<T>(apiContent);
            return APIReponse;
        }
        catch (Exception e)
        {
            var dto = new ServiceResponse
            {
                Success = false,
                Message = string.Join("\n", e.Message)
            };
            var res = JsonConvert.SerializeObject(dto);
            var APIReponse = JsonConvert.DeserializeObject<T>(res);
            return APIReponse;
        }
    }
}
