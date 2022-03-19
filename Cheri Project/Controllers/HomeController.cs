using Cheri_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cheri_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Cheri Context;

        public HomeController(ILogger<HomeController> logger,Cheri _Context)
        {
            _logger = logger;
            Context = _Context;
        }
        [Authorize]
        public IActionResult Index()
        {
            ViewData["Women"]=Context.Products.Where(p=>p.Category_ID==1).ToList();
            ViewData["Men"]=Context.Products.Where(p=>p.Category_ID==2).ToList();
            ViewData["Kid"]=Context.Products.Where(p=>p.Category_ID==3).ToList();
            ViewData["SubCategory"] = Context.SubCategories.ToList();
            ViewData["Category"] = Context.Categories.ToList();
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Product_Orders.Where(p => p.User_ID == userID).Count();
            return View("_MainLayout");
        }
        public IActionResult HeaderFooter()
        {
            ViewData["SubCategory"] = Context.SubCategories.ToList();
            ViewData["Category"] = Context.Categories.ToList();
            return View("_HeaderFooterLayout");
        }
        public IActionResult LoginPage()
        {
            return Redirect("http://localhost:8681/Account/Login");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
