using Cheri_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Cheri_Project.Services
{
    public class sizeservice :ISizeServices<Size>
    {
        Cheri Context;
        public sizeservice (Cheri _Context)
        {
            Context = _Context;
        }
        public int Delete(int id)
        {
            Size oldsize = Context.Sizes.FirstOrDefault(x =>x.ID== id);
            Context.Sizes.Remove(oldsize);
            int cc = Context.SaveChanges();
            return cc;
        }

        public List<Size> GetAll()
        {
            List<Size> size = Context.Sizes.Include(c => c.Product_ID).ToList();
            return size;
        }
        public Size GetById(int id)
        {
            return Context.Sizes.FirstOrDefault(d => d.ID == id);
        }
        public int Insert(Size Newsize)
        {
            Context.Sizes.Add(Newsize);
            int cc = Context.SaveChanges();
            return cc;
        }
        public int Update(int id, Size Newsize)
        {
            Size oldsize = Context.Sizes.FirstOrDefault(d => d.ID == id);
            oldsize.SizeName = Newsize.SizeName;
            int raw = Context.SaveChanges();
            return raw;
        }
    }
}
