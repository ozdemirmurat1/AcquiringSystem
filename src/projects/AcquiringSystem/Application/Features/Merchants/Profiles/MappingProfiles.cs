using Application.Features.Merchants.Commands.Create;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Merchants.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Merchant,CreateMerchantCommand>().ReverseMap();
        }
    }
}
