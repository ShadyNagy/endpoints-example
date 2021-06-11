using Ardalis.Endpoints.Core.Entities;
using Ardalis.Endpoints.Examples.Dtos;
using AutoMapper;

namespace Ardalis.Endpoints.Examples.MappingProfiles
{
    public class BranchProfile : Profile
    {
        public BranchProfile()
        {
            CreateMap<Branch, BranchDto>();
        }
    }
}
