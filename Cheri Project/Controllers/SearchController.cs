using Cheri_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace Cheri_Project.Controllers
{
    public class SearchController : Controller
    {
        private readonly Cheri Context;

        public SearchController(Cheri _Context)
        {
            Context = _Context;
        }
        public IActionResult Index(string Search)
        {
            ViewData["SubCategory"] = Context.SubCategories.ToList();
            ViewData["Category"] = Context.Categories.ToList();
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Product_Orders.Where(p => p.User_ID == userID).Count();
            var products = Context.Products
                .Where(x => x.ProductName.Contains(Search)).ToList();
            if(products.Count!=0)
            {
            return View(products);
            }
            else
            {
                ViewData["SubCategory"] = Context.SubCategories.ToList();
                ViewData["Category"] = Context.Categories.ToList();
                return View("NoContent");
            }
                

        }
    }
}
