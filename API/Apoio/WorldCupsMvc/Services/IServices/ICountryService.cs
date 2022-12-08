using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCupsMvc.Models.Dtos.Country;

namespace WorldCupsMvc.Services.IServices
{
    public interface ICountryService
    {
        Task<T> GetAll<T>();
        Task<T> GetById<T>(int id);
        Task<T> Create<T>(AddCountryDto dto);
        Task<T> Update<T>(UpdateCountryDto dto);
        Task<T> Delete<T>(int id);
    }
}