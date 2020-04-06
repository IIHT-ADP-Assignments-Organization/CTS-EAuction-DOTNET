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
   public class FunctionalTest
    {
        private readonly UserServices _Userservice;
      
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
            _Userservice = new UserServices(_session);
           
        }

        [Fact]
        public void Test_for_Register()
        {
            User user = new User()
            {
                UserId = 1,
                Address="aa",
                Email = "aa@gmail.com",
                Password = "1234",
                PaypalAccount = 11,
                City="ss",
                FirstName="aa",
                Lastname="ss",
                PhoneNumber="11111",
                Pin=12345,
                ReEnterpassword="1234",
                UserName="ss"

            };
            var Result = _Userservice.Register(user);
            Assert.True(Result);
        }

        [Fact]
        public void Test_for_Login()
        {
            User user = new User()
            {
                UserName = "ss",
                Password = "1234",
                
              

            };
            var Result = _Userservice.Login(user.UserName,user.Password);
            Assert.True(Result);
        }

        [Fact]
        public void Test_for_AddProduct()
        {
            Product product = new Product()
            {
                ProductId=1,
                ProductName="aa",
                Category="dd",
                DetailedDescription="dd",
                ShortDescription="dd",
                BidEnddate=DateTime.Now,
                BuyerId=1,
                FinalPrice=11,
                SellerId=2,
                StartingPrice=33,

            };
            var Result = _Userservice.AddProduct(product);
            Assert.True(Result);
        }


        [Fact]
        public void Test_for_SearchProduct()
        {
            Product product = new Product()
            {
                
                Category = "dd",
                
            };

          
            var Result = _Userservice.SearchProduct(product.Category);
            var GetProducts = _Userservice.GetProduct(product.Category);
            Assert.Equal(GetProducts,Result);
        }

        [Fact]
        public void Test_for_BidProduct()
        {
            Transaction transaction = new Transaction()
            {

               BidPrice=11,

            };

            Buyer buyer = new Buyer()
            {
                BuyerId = 1,
                Address = "dd",
                BuyerName = "dd",
                Email = "D@gmail.com",
                PhoneNumber = "111"
            };


            var Result = _Userservice.BidProduct(transaction.BidPrice,buyer);
          
            Assert.True( Result);
        }




    }
}
