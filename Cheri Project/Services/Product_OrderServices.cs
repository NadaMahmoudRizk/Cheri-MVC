using Cheri_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Cheri_Project.Services
{
    public class Product_OrderServices : IRepository<Product_Order>
    {
        Cheri Context;
        public Product_OrderServices(Cheri _Context)
        {
            Context = _Context;
        }
        public int Delete(int id)
        {
            Product_Order old = Context.Product_Orders.FirstOrDefault(d => d.OrderID == id);
            Context.Product_Orders.Remove(old);
            int raw = Context.SaveChanges();
            return raw;
        }

        public List<Product_Order> GetAll()
        {
            List<Product_Order> products = Context.Product_Orders.ToList();
            return products;
        }

        public Product_Order GetById(int id)
        {
            return Context.Product_Orders.FirstOrDefault(d => d.OrderID == id);

        }

        public int Insert(Product_Order Newobj)
        {
            Context.Product_Orders.Add(Newobj);
            int raw = Context.SaveChanges();
            return raw;
        }

        public int Update(int id, Product_Order Newobj)
        {
            Product_Order old = Context.Product_Orders.FirstOrDefault(d => d.OrderID == id);
            old.Size = Newobj.Size;
            old.Color = Newobj.Color;
            old.Product_ID = Newobj.Product_ID;
            old.TotalStock = Newobj.TotalStock;
            old.TotalPrice = Newobj.TotalPrice;
            int raw = Context.SaveChanges();
            return raw;
        }
    }
}
