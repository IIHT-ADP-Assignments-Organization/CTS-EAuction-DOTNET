using EAuction_Updated.BusinessLayer.Services;
using EAuction_Updated.DataLayer.NHibernateConfiguration;
using EAuction_Updated.Entities;
using EAuction_Updated.Test.Exceptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EAuction_Updated.Test.TestCases
{
  public  class ExceptionTest
    {

        private readonly UserServices _Userservice;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {
            _Userservice = new UserServices(_session);

        }
        [Fact]
        public void ExceptionTestFor_EmailAlreadyExist()
        {
            User user = new User()
            {
                Email = "example@gmail.com"
            };
            //Assert
            var ex = Assert.Throws<EmailAlreadyExistException>(() => _Userservice.Register(user));
            Assert.Equal("Email Already Exist ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_UserNotFound()
        {
            User user = new User()
            {
                UserName = "abc",
                Password = "123"

            };
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _Userservice.Login(user.UserName, user.Password));
            Assert.Equal("User Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_FieldsCannotblankforUser()
        {
            User user = new User()
            {
                UserName = "",
                FirstName = "abc",
                Lastname = "",
                Password = "123",
                ReEnterpassword = "123",
                Address = "gadag",
                City = "",
               
                Pin = 768766,
                PhoneNumber = "8987656778",
                Email = "example@gmail.com",
                PaypalAccount = 3,

            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _Userservice.Register(user));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_ProductNotFound()
        {
            Product product = new Product()
            {
                Category = ""
            };
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _Userservice.SearchProduct(product.Category));
            Assert.Equal("User Not Found ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_FieldsCannotblankforProduct()
        {
            Product product = new Product()
            {
                ProductName = "",
                ShortDescription = "abc",
                DetailedDescription = "",
                Category = "",
                StartingPrice = 1500,
                BidEnddate = DateTime.Now,
                FinalPrice = 5000,
                BuyerId = 3,
                SellerId = 5

            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _Userservice.AddProduct(product));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }

  }
}
