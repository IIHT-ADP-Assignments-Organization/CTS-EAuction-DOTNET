using System;
using System.Collections.Generic;
using System.Text;

namespace EAuction_Updated.Entities
{
   public class Product
    {
        public virtual int ProductId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string ShortDescription { get; set; }
        public virtual string DetailedDescription { get; set; }
        public virtual string Category { get; set; }
        public virtual double StartingPrice { get; set; }
        public virtual DateTime BidEnddate { get; set; }
        public virtual double FinalPrice { get; set; }
        public virtual int BuyerId { get; set; }
        public virtual int SellerId { get; set; }
    }
}
