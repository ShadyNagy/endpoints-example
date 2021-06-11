using Ardalis.Endpoints.Core.Entities;
using Ardalis.Endpoints.Examples.Dtos;
using AutoMapper;

namespace Ardalis.Endpoints.Examples.MappingProfiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDto>();
        }
    }
}
