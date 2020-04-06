using System;
using System.Collections.Generic;
using System.Text;

namespace EAuction_Updated.Entities
{
    public class Buyer
    {
        public virtual int BuyerId { get; set; }
        public virtual string BuyerName { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Address { get; set; }
    }
}
