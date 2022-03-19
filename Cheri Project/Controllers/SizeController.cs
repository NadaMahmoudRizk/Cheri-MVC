using Cheri_Project.Models;
using Cheri_Project.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Security.Claims;

namespace Cheri_Project.Controllers
{
    public class SizeController : Controller
    {
        private readonly Cheri Context;
        IRepository<Size> sizeRepository;

        public SizeController(Cheri _Context, IRepository<Size> sizeRep)
        {
            Context = _Context;
            this.sizeRepository = sizeRep;
        }
        public IActionResult New(int id)
        {
            ViewData["SubCategory"] = Context.SubCategories.ToList();
            ViewData["Category"] = Context.Categories.ToList();
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Product_Orders.Where(p => p.User_ID == userID).Count();
            var productID = Context.Products.FirstOrDefault(p => p.ID == id);
            return View(productID);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(Size Newobj)
        {
            
            if (ModelState.IsValid == true)
            {
                sizeRepository.Insert(Newobj);
                return Redirect($"http://localhost:8681/Product/Details/{Newobj.Product_ID}");
            }
            return View("New", Newobj);
        }
    }
}
