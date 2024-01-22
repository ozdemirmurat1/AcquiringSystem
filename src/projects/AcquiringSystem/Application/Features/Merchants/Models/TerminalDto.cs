using Core.Application.Dtos;

namespace Application.Features.Merchants.Models
{
    public class TerminalDto: IDto
    {
        public string TerminalIdentification { get; set; }
        public string InformationMessage { get; set; }
        public string DeviceBrand { get; set; }
        public string DeviceModel { get; set; }

        public string MerchantId { get; set; }
    }
}
