using Application.Features.Merchants.Commands.Create;
using Application.Features.Merchants.Commands.Update;
using Application.Features.Merchants.Models;
using Application.Features.Merchants.Queries.GetById;
using Application.Features.Merchants.Queries.GetByIdChainAndTerminals;
using Application.Features.Merchants.Queries.GetList;
using Application.Features.Merchants.Queries.GetListChainAndTerminals;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Merchants.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<IPaginate<Merchant>, GetListResponse<GetListMerchantWithAllQueryResponse>>().ReverseMap();
            CreateMap<IPaginate<Merchant>, GetListResponse<GetListMerchantQueryResponse>>().ReverseMap();
            CreateMap<Merchant, GetListMerchantWithAllQueryResponse>().ReverseMap();
            CreateMap<Merchant, GetListMerchantQueryResponse>().ReverseMap();
            CreateMap<Merchant, GetByIdMerchantQueryResponse>().ReverseMap();
            CreateMap<Merchant,CreateMerchantCommand>().ReverseMap();
            CreateMap<Merchant,UpdateMerchantCommand>().ReverseMap();
            CreateMap<Merchant, GetByIdMerchantWithAllQueryResponse>().ReverseMap();
            CreateMap<Terminal, TerminalDto>().ReverseMap();
            CreateMap<Chain, ChainDto>().ReverseMap();
            
        }
    }
}
