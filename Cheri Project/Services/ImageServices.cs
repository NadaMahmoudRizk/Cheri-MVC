using Cheri_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Cheri_Project.Services

{
    public class ImageServices : IImageServices
    {
        Cheri dp;
        public ImageServices(Cheri _dp)
        {
            dp = _dp;
        }
        public List<Image> GetAllImages()
        {
            List<Image> images = dp.Images.Include(s=>s.Product).ToList();
            return images;
        }
        public Image GetImageById(int id)
        {
            Image image = dp.Images.FirstOrDefault(s => s.ID == id);
            return image;
        }
        public Image GetImageByName(string name)
        {
            Image image = dp.Images.FirstOrDefault(s => s.ImageName == name);
            return image;
        }
        public int Add(Image i)
        {
            dp.Images.Add(i);
            int row = dp.SaveChanges();
            return row;
        }
        public int Edit(int id, Image i)
        {
            Image image = dp.Images.FirstOrDefault(s => s.ID == id);
            image.ID = i.ID;
            image.ImageName = i.ImageName;
            image.Product_ID = i.Product_ID;
            int row = dp.SaveChanges();
            return row;
        }
        public int Delete(int id)
        {
            Image image = dp.Images.FirstOrDefault(s => s.ID == id);
            dp.Remove(image);
            int row = dp.SaveChanges();
            return row;
        }
    }
}
