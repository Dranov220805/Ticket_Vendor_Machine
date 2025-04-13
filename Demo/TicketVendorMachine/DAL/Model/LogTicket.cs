using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LogTicket
    {
        public string LogTicketId { get; set; }
        public string MachineId { get; set; }
        public string CustomerId { get; set; }
        public string TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual TicketVendorMachine TicketVendorMachine { get; set; }
    }
}
