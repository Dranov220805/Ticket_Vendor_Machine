using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Ticket
    {
        public string TicketId { get; set; }
        public string CustomerId { get; set; }
        public string MachineId { get; set; }
        public string RouteName { get; set; }
        public string DescStart { get; set; }
        public string DescEnd { get; set; }
        public string VehicleType { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual TicketVendorMachine TicketVendorMachine { get; set; }
        public virtual ICollection<LogTicket> LogTickets { get; set; }
    }
}
