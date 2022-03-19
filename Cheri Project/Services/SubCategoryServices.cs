using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Cheri_Project.Models;
namespace Cheri_Project.Services
{
    public class SubCategoryServices : IRepository<SubCategory>
    {
        Cheri Context;
        public SubCategoryServices(Cheri _Context)
        {
            Context = _Context;
        }
        public int Delete(int id)
        {
            SubCategory oldCat = Context.SubCategories.FirstOrDefault(d => d.ID == id);
            Context.SubCategories.Remove(oldCat);
            int raw = Context.SaveChanges();
            return raw;
        }

        public List<SubCategory> GetAll()
        {
            List<SubCategory> SubCategory = Context.SubCategories.Include(c=>c.Categories).ToList();
            return SubCategory;

        }
        public List<SubCategory> GetByCategoriy(int id)
        {
            List<SubCategory> SubCategory = Context.SubCategories.Where(c => c.Category_ID == id).ToList();
            return SubCategory;

            }
            //public List<SubCategory> GetAllWithProduct()
            //{
            //    List<SubCategory> Category = Context.SubCategories.Include(c => c.Products).ToList();
            //    return Category;

            //}

            public SubCategory GetById(int id)
        {
            return Context.SubCategories.FirstOrDefault(d => d.ID == id);
        }

        public int Insert(SubCategory Newobj)
        {
            Context.SubCategories.Add(Newobj);
            int raw = Context.SaveChanges();
            return raw;
        }

        public int Update(int id, SubCategory Newobj)
        {
            SubCategory oldCategory = Context.SubCategories.FirstOrDefault(d => d.ID == id);
            oldCategory.SubCategoryName = Newobj.SubCategoryName;
            int raw = Context.SaveChanges();
            return raw;
        }
    }
}

