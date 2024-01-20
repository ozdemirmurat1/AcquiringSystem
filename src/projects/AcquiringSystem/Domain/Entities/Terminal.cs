﻿using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Terminal : Entity<Guid>
    {
        public string TerminalIdentification { get; set; }

        public Terminal()
        {
            
        }

        public Terminal(string terminalIdentification)
        {
            TerminalIdentification = terminalIdentification;
        }
    }
}
