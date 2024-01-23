using Application.Features.Terminals.Commands.Create;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Terminals.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Terminal,CreateTerminalCommand>().ReverseMap();
        }
    }
}
