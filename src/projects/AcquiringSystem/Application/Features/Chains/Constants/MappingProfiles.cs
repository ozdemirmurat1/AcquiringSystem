using Application.Features.Chains.Models;
using Application.Features.Chains.Queries.GetByIdWithMerchant;
using Application.Features.Chains.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Chains.Constants
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {

            CreateMap<IPaginate<Chain>, GetListResponse<GetListChainQueryResponse>>().ReverseMap();
            CreateMap<Chain,GetByIdWithMercantChainQueryResponse>().ReverseMap();
            CreateMap<Merchant, MerchantDto>().ReverseMap();
        }
    }
}
