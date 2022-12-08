using WorldCupsMvc.Models;

namespace WorldCupsMvc.Services.IServices;

public interface IBaseService
{
    ServiceRequest responseModel { get; set; }
    Task<T> SendAsync<T>(ServiceRequest serviceRequest);
}
