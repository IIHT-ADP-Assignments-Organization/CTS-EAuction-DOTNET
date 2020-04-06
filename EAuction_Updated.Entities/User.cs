using System;
using System.Collections.Generic;
using System.Text;

namespace EAuction_Updated.Entities
{
   public class User
    {
        public virtual int UserId { get; set; }
        public virtual string UserName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Password { get; set; }
        public virtual string ReEnterpassword { get; set; }
        public virtual string Address { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual double PaypalAccount { get; set; }
        public virtual string City { get; set; }
        public virtual int Pin { get; set; }

    }
}
