using AutoMapper;
using WorldCupsMvc.Models.Dtos.Country;

namespace WorldCupsMvc
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<GetCountryDto, AddCountryDto>().ReverseMap();
            CreateMap<GetCountryDto, UpdateCountryDto>().ReverseMap();
        }
    }
}