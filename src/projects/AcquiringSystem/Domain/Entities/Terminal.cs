using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Terminal : Entity<string>
    {
        public string TerminalIdentification { get; set; }
        public string InformationMessage { get; set; }
        public string DeviceBrand { get; set; }
        public string DeviceModel{ get; set; }

        public string MerchantId { get; set; }
        public Merchant Merchant { get; set; }

        public Terminal()
        {
            
        }

        public Terminal(string id,string terminalIdentification, string ınformationMessage):base(id)
        {
            TerminalIdentification = terminalIdentification;
            InformationMessage = ınformationMessage;

        }
    }
}
