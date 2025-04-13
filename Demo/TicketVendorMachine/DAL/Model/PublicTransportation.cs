using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PublicTransportation
    {
        public string VehicleId { get; set; }
        public string VehicleType { get; set; }
        public virtual ICollection<Destination> Destinations { get; set; }
    }
}
