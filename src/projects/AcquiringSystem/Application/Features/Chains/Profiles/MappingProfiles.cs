using Application.Features.Chains.Models;
using Application.Features.Chains.Queries.GetByIdWithMerchant;
using Application.Features.Chains.Queries.GetList;
using Application.Features.Chains.Queries.GetListWithMerchant;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Chains.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {

            CreateMap<IPaginate<Chain>, GetListResponse<GetListChainQueryResponse>>().ReverseMap();
            CreateMap<Chain, GetListChainQueryResponse>().ReverseMap();
            CreateMap<IPaginate<Chain>, GetListResponse<GetListWithMerchantChainQueryResponse>>().ReverseMap();
            CreateMap<Chain, GetListWithMerchantChainQueryResponse>().ReverseMap();
            CreateMap<Chain, GetByIdWithMercantChainQueryResponse>().ReverseMap();
            CreateMap<Merchant, MerchantDto>().ReverseMap();

        }
    }
}
