using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TicketVendorMachine
    {
        public string MachineId { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<LogTicket> LogTickets { get; set; }
    }
}
