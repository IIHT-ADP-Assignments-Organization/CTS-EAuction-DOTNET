using System;
using System.Collections.Generic;
using System.Text;

namespace EAuction_Updated.Entities
{
   public class Transaction
    {
        public virtual int TransactionId { get; set; }
        public virtual int BuyerId { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual int BidPrice { get; set; }
        public virtual DateTime BidDate { get; set; }
    }
}
