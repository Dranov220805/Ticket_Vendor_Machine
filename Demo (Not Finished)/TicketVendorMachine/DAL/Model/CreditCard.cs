using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CreditCard
    {
        public string CreditCardId { get; set; }
        public string IsActive { get; set; }
        public string Field { get; set; }
        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; }
    }
}
