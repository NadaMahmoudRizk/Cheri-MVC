
﻿using Microsoft.AspNetCore.Mvc;
using Cheri_Project.Services;
using Cheri_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Cheri_Project.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        IRepository<SubCategory> Repository;
        IRepository<Categories> categoryRepository;
        IRepository<Product> productRepository;

        Cheri Context;
        private readonly IHostingEnvironment hosting;

        IRepository<Image> ImgRep;
        IRepository<Size> sizeRep;

        public ProductController(IRepository<SubCategory> SubCategoryRep, IRepository<Categories> CatRep, IRepository<Product> ProdRep, IHostingEnvironment hosting,Cheri _context,IRepository<Image> ImgRep,IRepository<Size> SizeRep)
        {
            Repository = SubCategoryRep;
            categoryRepository = CatRep;
            productRepository = ProdRep;
            this.hosting = hosting;
            Context = _context;
            this.ImgRep = ImgRep;
            this.sizeRep = SizeRep;
        }
        public IActionResult Delete(int id)
        {

            productRepository.Delete(id);
            return Redirect("http://localhost:8681/Home/Index");
        }
        public IActionResult Edit(int id)
        {
            ViewData["SubCategory"] = Context.SubCategories.ToList();
            ViewData["Category"] = Context.Categories.ToList();
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Product_Orders.Where(p => p.User_ID == userID).Count();
            List<Categories> cat = categoryRepository.GetAll();
            ViewData["cat"] = cat;
            List<SubCategory> sub = Repository.GetAll();
            ViewData["sub"] = sub;
            var Model = productRepository.GetById(id);

            return View(Model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(int id, Product newprod, IFormFile File)
        {
            if (File != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "ProductImages");
                string filename = File.FileName;
                string fullpath = Path.Combine(uploads, filename);
                File.CopyTo(new FileStream(fullpath, FileMode.Create));
                newprod.Image = filename;
            }

            if (ModelState.IsValid == true)
            {
                productRepository.Update(id, newprod);
                return Redirect("http://localhost:8681/Home/Index");
            }
            List<Categories> cat = categoryRepository.GetAll();
            ViewData["cat"] = cat;
            List<SubCategory> sub = Repository.GetAll();
            ViewData["sub"] = sub;
            return View("Edit", newprod);
        }
        public IActionResult Index()
        {
            var Products = productRepository.GetAll();
            return View(Products);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(Product Newobj, IFormFile File)
        {
            if (File != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "ProductImages");
                string filename = File.FileName;
                string fullpath = Path.Combine(uploads, filename);
                File.CopyTo(new FileStream(fullpath, FileMode.Create));
                Newobj.Image = filename;
            }

            if (ModelState.IsValid == true)
            {
                productRepository.Insert(Newobj);
                return Redirect("http://localhost:8681/Home/Index");
            }
            List<Categories> cat = categoryRepository.GetAll();
            ViewData["cat"] = cat;
            List<SubCategory> sub = Repository.GetAll();
            ViewData["sub"] = sub;
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
            List<SubCategory> sub = Repository.GetAll();
            ViewData["sub"] = sub;
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewData["SubCategory"] = Context.SubCategories.ToList();
            ViewData["Category"] = Context.Categories.ToList();
            ViewData["Img"]=Context.Images.Where(I=>I.Product_ID==id).ToList();
            ViewData["Size"]= Context.Sizes.Where(I => I.Product_ID == id).ToList();
            ViewData["Color"]= Context.Colors.Where(I => I.Product_ID == id).ToList();
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Product_Orders.Where(p => p.User_ID == userID).Count();
            var product =Context.Products.FirstOrDefault(p=>p.ID == id);
            return View(product);

        }

        public IActionResult ProductBySubcategory(int id)
        {
            ViewData["SubCategory"] = Context.SubCategories.ToList();
            ViewData["Category"] = Context.Categories.ToList();
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Product_Orders.Where(p => p.User_ID == userID).Count();
            var product = Context.Products.Where(p => p.SubCategory_ID == id).ToList();
            return View(product);
        }

        public IActionResult ProductBycategory(int id)
        {
            ViewData["SubCategory"] = Context.SubCategories.ToList();
            ViewData["Category"] = Context.Categories.ToList();
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Product_Orders.Where(p => p.User_ID == userID).Count();
            var product = Context.Products.Where(p => p.Category_ID == id).ToList();
            return View(product);
        }
    }
}

