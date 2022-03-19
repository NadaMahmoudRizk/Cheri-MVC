using Cheri_Project.Models;
using System.Collections.Generic;

namespace Cheri_Project.Services
{
    public interface IProduct_OrderServices
    {
        int Add(Product_Order po);
        int Delete(int id);
        int Edit(int id, Product_Order po);
        List<Product_Order> GetAllProduct_Orders();
        Product_Order GetProductByID(int id);
        Product_Order GetProductBySize(string size);
    }
}