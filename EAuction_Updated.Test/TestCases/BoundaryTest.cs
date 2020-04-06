using EAuction_Updated.BusinessLayer.Services;
using EAuction_Updated.DataLayer.NHibernateConfiguration;
using EAuction_Updated.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EAuction_Updated.Test.TestCases
{
   public class BoundaryTest
    {
        private readonly UserServices _Userservice;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public BoundaryTest()
        {
            _Userservice = new UserServices(_session);

        }

        [Fact]
        public void BoundaryTest_ForPincode_Length()
        {

            User user = new User()
            {
                Pin = 111456
            };
            var MinLength = 6;
            var MaxLength = 6;

            //Action
            var actualLength = user.Pin.ToString().Length;


            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForPhoneNo_Length()
        {
            User user = new User()
            {
                PhoneNumber = "981114564"
            };
            var MinLength = 10;
            var MaxLength = 10;

            //Action
            var actualLength = user.PhoneNumber.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForBuyerPhoneNo_Length()
        {
            Buyer buyer = new Buyer()
            {
                PhoneNumber = "981114564"
            };
            var MinLength = 10;
            var MaxLength = 10;

            //Action
            var actualLength = buyer.PhoneNumber.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForBidEndDate()
        {

            Product product = new Product()
            {
                BidEnddate = DateTime.Now
            };

            //Action
            var DatePattern = product.BidEnddate.ToString();


            //Assert
            Assert.Matches(DatePattern, "dd-mm-yyyy");
        }

    }
}
