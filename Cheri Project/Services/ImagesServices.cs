using Cheri_Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cheri_Project.Services
{
    public class ImagesServices : IRepository<Image>
    {
        private readonly Cheri Context;

        public ImagesServices(Cheri _Context)
        {
            Context = _Context;
        }
        public int Delete(int id)
        {
            Image oldImg = Context.Images.FirstOrDefault(d => d.ID == id);
            Context.Images.Remove(oldImg);
            int raw = Context.SaveChanges();
            return raw;
        }

        public List<Image> GetAll()
        {
            List<Image> Image = Context.Images.ToList();
            return Image;
        }

        public Image GetById(int id)
        {
            return Context.Images.FirstOrDefault(d => d.ID == id);
        }

        public int Insert(Image Newobj)
        {
            Context.Images.Add(Newobj);
            int raw = Context.SaveChanges();
            return raw;
        }

        public int Update(int id, Image Newobj)
        {
            Image oldImg = Context.Images.FirstOrDefault(d => d.ID == id);
            oldImg.ImageName = Newobj.ImageName;
            oldImg.Product_ID = Newobj.Product_ID;
            int raw = Context.SaveChanges();
            return raw;
        }
    }
}
