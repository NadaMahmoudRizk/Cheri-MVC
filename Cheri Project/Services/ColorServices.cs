using Cheri_Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cheri_Project.Services
{
    public class ColorServices : IRepository<Color>
    {
        private readonly Cheri Context;

        public ColorServices(Cheri _Context)
        {
            Context = _Context;
        }
        public int Delete(int id)
        {
            Color oldColor = Context.Colors.FirstOrDefault(d => d.ID == id);
            Context.Colors.Remove(oldColor);
            int raw = Context.SaveChanges();
            return raw;
        }

        public List<Color> GetAll()
        {
            List<Color> color = Context.Colors.ToList();
            return color;
        }

        public Color GetById(int id)
        {
            return Context.Colors.FirstOrDefault(d => d.ID == id);
        }

        public int Insert(Color Newobj)
        {
            Context.Colors.Add(Newobj);
            int raw = Context.SaveChanges();
            return raw;
        }

        public int Update(int id, Color Newobj)
        {
            Color oldColor = Context.Colors.FirstOrDefault(d => d.ID == id);
            oldColor.ColorName = Newobj.ColorName;
            oldColor.Product_ID = Newobj.Product_ID;
            int raw = Context.SaveChanges();
            return raw;
        }
    }
}
