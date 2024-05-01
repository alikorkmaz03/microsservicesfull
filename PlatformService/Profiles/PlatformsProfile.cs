using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            //Sourece -> Target 
            CreateMap<Platform,PlatformReadDto>();
            CreateMap<PlatformCreateDto,Platform>(); 
            CreateMap<PlatformReadDto,PlatformPublishedDto>();          
        }
    }
}