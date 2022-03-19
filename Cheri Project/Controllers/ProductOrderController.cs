using Cheri_Project.Models;
using Cheri_Project.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;

namespace Cheri_Project.Controllers
{
    public class ProductOrderController : Controller
    {
        private readonly Cheri Context;
        IRepository<Product_Order> OrderRepository;
        public ProductOrderController(IRepository<Product_Order> OrderRep, Cheri _Context)
        {
            Context=_Context;
            OrderRepository=OrderRep;
        }
        public IActionResult Insert(int id,int totalprice,Product_Order newObj)
        {
            newObj.Product_ID = id;
            newObj.User_ID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            newObj.TotalStock = 1;
           newObj.TotalPrice= Context.Products.Where(p => p.ID == id).Select(p => p.ProductPrice).FirstOrDefault();
            OrderRepository.Insert(newObj);
            return Redirect($"http://localhost:8681/Product/Details/{newObj.Product_ID}");
        }
        public IActionResult ProductCart()
        {
            ViewData["SubCategory"] = Context.SubCategories.ToList();
            ViewData["Category"] = Context.Categories.ToList();
            var userID= User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Product_Orders.Where(p=>p.User_ID== userID).Count();
            var Cart=Context.Product_Orders.Where(p => p.User_ID == userID).Include(p=>p.Product).ToList();
            return View(Cart);
        }

        public IActionResult Delete(int id)
        {
            OrderRepository.Delete(id);
            return RedirectToAction("ProductCart");
        }
    }
}
