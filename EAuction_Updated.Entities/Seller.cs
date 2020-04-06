using System;
using System.Collections.Generic;
using System.Text;

namespace EAuction_Updated.Entities
{
   public class Seller
    {
        public virtual int SellerId { get; set; }
        public virtual string SellerName { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
    }
}
