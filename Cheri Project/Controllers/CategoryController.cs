using Microsoft.AspNetCore.Mvc;
using Cheri_Project.Services;
using Cheri_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Linq;
using System.Security.Claims;

namespace Cheri_Project.Controllers
{
    public class CategoryController : Controller
    {
        IRepository<Categories> categoryRepository;
        private readonly IHostingEnvironment hosting;
        private readonly Cheri Context;

        public CategoryController(IRepository<Categories> CategoryRep, IHostingEnvironment hosting,Cheri _Context)
        {
            categoryRepository = CategoryRep;
            this.hosting = hosting;
            Context = _Context;
        }
        public IActionResult Delete(int id)
        {

            categoryRepository.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            ViewData["SubCategory"] = Context.SubCategories.ToList();
            ViewData["Category"] = Context.Categories.ToList();
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Product_Orders.Where(p => p.User_ID == userID).Count();
            var InstructorModel = categoryRepository.GetById(id);

            return View(InstructorModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(int id, Categories newcat, IFormFile File)
        {
            if (File != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Images");
                string filename = File.FileName;
                string fullpath = Path.Combine(uploads, filename);
                File.CopyTo(new FileStream(fullpath, FileMode.Create));
                newcat.CategoryImage = filename;
            }

            if (ModelState.IsValid == true)
            {
                categoryRepository.Update(id, newcat);
                return Redirect($"http://localhost:8681");
            }
            return View("Edit", newcat);
        }
        public IActionResult Index()
        {
            var Category = categoryRepository.GetAll();
            return View(Category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(IFormFile File,Categories Newobj)
        {
            if (File != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Images");
                string filename = File.FileName;
                string fullpath = Path.Combine(uploads, filename);
                File.CopyTo(new FileStream(fullpath, FileMode.Create));
                Newobj.CategoryImage = filename;
            }

            if (ModelState.IsValid == true)
            {
                categoryRepository.Insert(Newobj);
                return Redirect($"http://localhost:8681");
            }
            return View("New", Newobj);
        }
        public IActionResult New()
        {
            ViewData["SubCategory"] = Context.SubCategories.ToList();
            ViewData["Category"] = Context.Categories.ToList();
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Product_Orders.Where(p => p.User_ID == userID).Count();
            return View();
        }
    }
}
