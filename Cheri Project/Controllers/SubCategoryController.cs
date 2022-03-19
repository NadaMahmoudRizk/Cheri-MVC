using Microsoft.AspNetCore.Mvc;
using Cheri_Project.Services;
using Cheri_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Cheri_Project.Controllers
{
    public class SubCategoryController : Controller
    {
        IRepository<SubCategory> Repository;
        IRepository<Categories> categoryRepository;
        private readonly Cheri Context;

        public SubCategoryController(IRepository<SubCategory> SubCategoryRep, IRepository<Categories> CatRep,Cheri _Context)
        {
            Repository = SubCategoryRep;
            categoryRepository= CatRep;
            Context = _Context;
        }
        public IActionResult Delete(int id)
        {

            Repository.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            ViewData["SubCategory"] = Context.SubCategories.ToList();
            ViewData["Category"] = Context.Categories.ToList();
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Product_Orders.Where(p => p.User_ID == userID).Count();
            List<Categories> cat = categoryRepository.GetAll();
            ViewData["cat"] = cat;
            var Model = Repository.GetById(id);

            return View(Model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(int id, SubCategory newSub)
        {

            if (ModelState.IsValid == true)
            {
                Repository.Update(id, newSub);
                return Redirect($"http://localhost:8681/Home/Index");
            }
            List<Categories> cat = categoryRepository.GetAll();
            ViewData["cat"] = cat;
            return View("Edit", newSub);
        }
        public IActionResult Index()
        {
            var subCategories = Repository.GetAll();
            return View(subCategories);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(SubCategory Newobj)
        {

            if (ModelState.IsValid == true)
            {
                Repository.Insert(Newobj);
                return Redirect($"http://localhost:8681/Home/Index");
            }
            List<Categories> cat = categoryRepository.GetAll();
            ViewData["cat"] = cat;
            return View("New", Newobj);
        }
        public IActionResult New()
        {
            ViewData["SubCategory"] = Context.SubCategories.ToList();
            ViewData["Category"] = Context.Categories.ToList();
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Product_Orders.Where(p => p.User_ID == userID).Count();
            List<Categories> cat = categoryRepository.GetAll();
            ViewData["cat"] = cat;
            return View();
        }
    }
}
