using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Destination
    {
        public string DestinationId { get; set; }
        public string VehicleId { get; set; }
        public string RouteId { get; set; }
        public virtual PublicTransportation PublicTransportation { get; set; }
        public virtual Route Route { get; set; }
    }
}
