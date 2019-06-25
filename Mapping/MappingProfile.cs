using AutoMapper;
using DRF.Controllers.Resources;
using DRF.Models;

namespace DRF.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}