using EAuction_Updated.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EAuction_Updated.BusinessLayer.Interface
{
    public interface IUserServices
    {
        bool Register(User user);
        bool Login(string UserName, string Password);
        bool AddProduct(Product product);
        List<Product> SearchProduct(string Category);
        List<Product> GetProduct(string Category);

        bool BidProduct(int BidPrice, Buyer buyer);
        List<Product> ViewProductsPurchased(int BuyerId);
        List<Product> ViewProductsSold(int SellerId);
    }
}
