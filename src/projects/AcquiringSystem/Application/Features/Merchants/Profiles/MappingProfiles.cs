using Application.Features.Merchants.Commands.Create;
using Application.Features.Merchants.Commands.Update;
using Application.Features.Merchants.Models;
using Application.Features.Merchants.Queries.GetByIdChainAndTerminals;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Merchants.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Merchant,CreateMerchantCommand>().ReverseMap();
            CreateMap<Merchant,UpdateMerchantCommand>().ReverseMap();
            CreateMap<Merchant, GetByIdMerchantQueryResponse>().ReverseMap();
            CreateMap<Terminal, TerminalDto>().ReverseMap();
            CreateMap<Chain, ChainDto>().ReverseMap();
        }
    }
}
