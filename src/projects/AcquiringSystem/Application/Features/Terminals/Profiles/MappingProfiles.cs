using Application.Features.Terminals.Commands.Create;
using Application.Features.Terminals.Commands.Update;
using Application.Features.Terminals.Models;
using Application.Features.Terminals.Queries.GetById;
using Application.Features.Terminals.Queries.GetByIdTerminalWithMerchant;
using Application.Features.Terminals.Queries.GetList;
using Application.Features.Terminals.Queries.GetListTerminalWithMerchant;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Terminals.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Terminal,CreateTerminalCommand>().ReverseMap();
            CreateMap<Terminal,UpdateTerminalCommand>().ReverseMap();
            CreateMap<Terminal,GetByIdTerminalQueryResponse>().ReverseMap();
            CreateMap<IPaginate<Terminal>, GetListResponse<GetListTerminalQueryResponse>>().ReverseMap();
            CreateMap<IPaginate<Terminal>, GetListResponse<GetListTerminalWithMerchantQueryResponse>>().ReverseMap();
            CreateMap<Terminal, GetListTerminalQueryResponse>().ReverseMap();
            CreateMap<Terminal, GetListTerminalWithMerchantQueryResponse>().ReverseMap();
            CreateMap<Terminal, GetByIdTerminalWithMerchantQueryResponse>().ReverseMap();
            CreateMap<MerchantDto, Merchant>().ReverseMap();
        }
    }
}
