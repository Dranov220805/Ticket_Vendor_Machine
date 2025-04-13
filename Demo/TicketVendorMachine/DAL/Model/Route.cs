using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DAL
{
    public class Route
    {
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public string DescStart { get; set; }
        public string DescEnd { get; set; }
        public DateTime Duration { get; set; }
        public virtual ICollection<Destination> Destinations { get; set; }
    }
}
