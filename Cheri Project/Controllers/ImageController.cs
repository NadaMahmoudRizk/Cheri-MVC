
﻿using Cheri_Project.Models;
using Cheri_Project.Services;
﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Security.Claims;
using System.Linq;

namespace Cheri_Project.Controllers
{
    public class ImageController : Controller
    {
        private readonly Cheri Context;
        private readonly IHostingEnvironment hosting;
        IRepository<Image> imageRepository;

        public ImageController(Cheri _Context, IHostingEnvironment hosting, IRepository<Image> imageRep)
        {
            Context = _Context;
            this.hosting = hosting;
            this.imageRepository = imageRep;
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
        public IActionResult Insert(IFormFile File, Image Newobj)
        {
            if (File != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "ProductImages");
                string filename = File.FileName;
                string fullpath = Path.Combine(uploads, filename);
                File.CopyTo(new FileStream(fullpath, FileMode.Create));
                Newobj.ImageName = filename;
            }

            if (ModelState.IsValid == true)
            {
                imageRepository.Insert(Newobj);
                return Redirect($"http://localhost:8681/Product/Details/{Newobj.Product_ID}");
            }
            return View("New", Newobj);
        }
    }
}
