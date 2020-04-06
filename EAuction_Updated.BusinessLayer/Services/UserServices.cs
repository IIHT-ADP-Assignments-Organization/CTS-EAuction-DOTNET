using EAuction_Updated.BusinessLayer.Interface;
using EAuction_Updated.DataLayer.NHibernateConfiguration;
using EAuction_Updated.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EAuction_Updated.BusinessLayer.Services
{
    public class UserServices : IUserServices
    {

        private readonly IMapperSession _session;

        public UserServices(IMapperSession session)
        {
            _session = session;
        }

        public bool AddProduct(Product product)
        {
            return true;
        }

        public bool BidProduct(int BidPrice, Buyer buyer)
        {
            return true;
        }

        public List<Product> GetProduct(string Category)
        {
            List<Product> products = new List<Product>();
            return products;
        }

        public bool Login(string UserName, string Password)
        {
            return true;
        }

        public bool Register(User user)
        {
            return true;
        }

        public List<Product> SearchProduct(string Category)
        {
            List<Product> products = new List<Product>();
            return products;
        }

        public List<Product> ViewProductsPurchased(int BuyerId)
        {
            List<Product> products = new List<Product>();
            return products;
        }

        public List<Product> ViewProductsSold(int SellerId)
        {
            List<Product> products = new List<Product>();
            return products;
        }
    }
}
