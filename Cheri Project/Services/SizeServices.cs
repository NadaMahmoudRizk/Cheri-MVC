using Cheri_Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cheri_Project.Services
{
    public class SizeServices : IRepository<Size>
    {
        private readonly Cheri Context;

        public SizeServices(Cheri _Context)
        {
            Context = _Context;
        }
        public int Delete(int id)
        {
            Size oldSize = Context.Sizes.FirstOrDefault(d => d.ID == id);
            Context.Sizes.Remove(oldSize);
            int raw = Context.SaveChanges();
            return raw;
        }

        public List<Size> GetAll()
        {
            List<Size> Size = Context.Sizes.ToList();
            return Size;
        }

        public Size GetById(int id)
        {
            return Context.Sizes.FirstOrDefault(d => d.ID == id);
        }

        public int Insert(Size Newobj)
        {
            Context.Sizes.Add(Newobj);
            int raw = Context.SaveChanges();
            return raw;
        }

        public int Update(int id, Size Newobj)
        {
            Size oldSize = Context.Sizes.FirstOrDefault(d => d.ID == id);
            oldSize.SizeName = Newobj.SizeName;
            oldSize.Product_ID = Newobj.Product_ID;
            int raw = Context.SaveChanges();
            return raw;
        }
    }
}
