using Cheri_Project.Models;
using System.Collections.Generic;

namespace Cheri_Project.Services
{
    public interface IProductServices
    {
        int Add(Product p);
        int Delete(int id);
        int Edit(int id, Product p);
        List<Product> GetAllProducts();
        Product GetProductByID(int id);
        Product GetProductByName(string name);
    }
}