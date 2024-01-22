using Application.Features.Merchants.Commands.Create;
using Application.Features.Merchants.Commands.Update;
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
        }
    }
}
