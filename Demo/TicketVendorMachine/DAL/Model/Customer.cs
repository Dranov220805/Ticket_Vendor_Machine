using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<LogTicket> LogTickets { get; set; }
    }
}
