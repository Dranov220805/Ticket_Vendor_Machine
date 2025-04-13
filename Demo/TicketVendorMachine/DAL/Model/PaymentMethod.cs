using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PaymentMethod
    {
        public string PaymentId { get; set; }
        public string QrCodeId { get; set; }
        public string CreditCardId { get; set; }
        public virtual QRCode QRCode { get; set; }
        public virtual CreditCard CreditCard { get; set; }
    }
}
