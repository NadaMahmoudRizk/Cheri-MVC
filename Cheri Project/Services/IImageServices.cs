using Cheri_Project.Models;
using System.Collections.Generic;

namespace Cheri_Project.Services
{
    public interface IImageServices
    {
        int Add(Image i);
        int Delete(int id);
        int Edit(int id, Image i);
        List<Image> GetAllImages();
        Image GetImageById(int id);
        Image GetImageByName(string name);
    }
}