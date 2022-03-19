
﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Cheri_Project.Models;
namespace Cheri_Project.Services
{
    public class ProductServices : IRepository<Product>
    {
        Cheri Context;
        public ProductServices(Cheri _Context)
        {
            Context = _Context;
        }
        public int Delete(int id)
        {
            Product old = Context.Products.FirstOrDefault(d => d.ID == id);
            Context.Products.Remove(old);
            int raw = Context.SaveChanges();
            return raw;
        }

        public List<Product> GetAll()
        {
            List<Product> products = Context.Products.Include(p=>p.Category).Include(p=>p.SubCategory).ToList();
            return products;

        }

        public Product GetById(int id)
        {
            return Context.Products.FirstOrDefault(d => d.ID == id);
        }

        public int Insert(Product Newobj)
        {
            Context.Products.Add(Newobj);
            int raw = Context.SaveChanges();
            return raw;
        }

        public int Update(int id, Product Newobj)
        {
            Product old = Context.Products.FirstOrDefault(d => d.ID == id);
            old.ProductName = Newobj.ProductName;
            old.ProductDescription = Newobj.ProductDescription;
            old.ProductPrice= Newobj.ProductPrice;
            old.Discount = Newobj.Discount;
            old.Category_ID= Newobj.Category_ID;
            old.SubCategory_ID= Newobj.SubCategory_ID;
            int raw = Context.SaveChanges();
            return raw;
        }
    }
}

