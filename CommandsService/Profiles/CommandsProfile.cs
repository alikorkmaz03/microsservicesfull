using AutoMapper;
using CommandsService.Dtos;
using CommandsService.Models;
using PlatformService;

namespace CommandsService.Profiles
{
    public class CommandsProfile : Profile{
        public CommandsProfile()
        {
            //Source -> Target
            CreateMap<Platform,PlatformReadDto>();
            CreateMap<CommandCreateDto,Command>();
            CreateMap<Command,CommandReadDto>();
            CreateMap<PlatformPublishedDto,Platform>()
                .ForMember(dest=>dest.ExternalId, opt=>opt.MapFrom(source=>source.Id));
            CreateMap<GrpcPlatformModel,Platform>()
                .ForMember(dest=>dest.ExternalId,opt=>opt.MapFrom(source=>source.PlatformId))
                .ForMember(dest=>dest.Name,opt=>opt.MapFrom(source=>source.Name))
                .ForMember(dest=>dest.Commands,opt=>opt.Ignore());
        }
    }
}