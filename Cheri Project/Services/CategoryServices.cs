using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Cheri_Project.Models;
namespace Cheri_Project.Services
{
    public class CategoryServices : IRepository<Categories>
    {
        Cheri Context;
        public CategoryServices(Cheri _Context)
        {
            Context = _Context;
        }
        public int Delete(int id)
        {
            Categories oldCrs = Context.Categories.FirstOrDefault(d => d.ID == id);
            Context.Categories.Remove(oldCrs);
            int raw = Context.SaveChanges();
            return raw;
        }

        public List<Categories> GetAll()
        {
            List<Categories> Category = Context.Categories.ToList();
            return Category;

        }
        //public List<Categories> GetAllWithSubCategory()
        //{
        //    List<Categories> Category = Context.Categories.Include(c=>c.SubCategories).ToList();
        //    return Category;

        //}
        //public List<Categories> GetAllWithProduct()
        //{
        //    List<Categories> Category = Context.Categories.Include(c => c.Products).ToList();
        //    return Category;

        //}

        public Categories GetById(int id)
        {
            return Context.Categories.FirstOrDefault(d => d.ID == id);
        }

        public int Insert(Categories Newobj)
        {
            Context.Categories.Add(Newobj);
            int raw = Context.SaveChanges();
            return raw;
        }

        public int Update(int id, Categories Newobj)
        {
            Categories oldCategory = Context.Categories.FirstOrDefault(d => d.ID == id);
            oldCategory.CategoryName = Newobj.CategoryName;
            oldCategory.CategoryImage = Newobj.CategoryImage;
            int raw = Context.SaveChanges();
            return raw;
        }
    }
}

