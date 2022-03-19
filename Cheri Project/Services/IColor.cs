using Cheri_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheri_Project.Services
{
  public  interface IColor
    {
        public List<Color> getAll();
        public Color getById(int id);
        public Color getByName(string name);
        public int add(Color c);
        public int update(int id, Color c);
        public int delete(int id);

    }
}
