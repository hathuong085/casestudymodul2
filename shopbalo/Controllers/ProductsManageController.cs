using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using shopbalo.Models;
using shopbalo.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace shopbalo.Controllers
{
    public class ProductsManageController:Controller
    {
        private readonly IBaloRepository baloRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IAdvertisesRepository advertisesRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProductsManageController(IBaloRepository baloRepository,
                                ICategoryRepository categoryRepository,
                                IAdvertisesRepository advertisesRepository,
                                IWebHostEnvironment webHostEnvironment)
        {
            this.baloRepository = baloRepository;
            this.categoryRepository = categoryRepository;
            this.advertisesRepository = advertisesRepository;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Balo> balos = baloRepository.Gets().ToList();
            ViewBag.Categories = GetCategories();
            return View(balos);
        }

        public IActionResult Productofcategory(int id)
        {
            var category = categoryRepository.Get(id);
            if (category == null)
            {
                ViewBag.Id = id;
                return View("~/Views/Error/ProductNotFound.cshtml");
            }
            if (category != null)
            {
                List<Balo> balos = (from balo in baloRepository.Gets() where balo.CategoryId == category.CategoryId select balo).ToList();
                ViewBag.Categories = GetCategories();
                ViewBag.CategoryName = category.CategoryName;
                return View(balos);
            }
            ViewBag.Categories = GetCategories();
            return View();
        }

        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.Categories = GetCategories();
            return View();
        }

        [HttpPost]
        public IActionResult Create(HomeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var balo = new Balo()
                {
                    BaloName = model.BaloName,
                    Trademark=model.Trademark,
                    Size=model.Size,
                    Material=model.Material,
                    Description = model.Description,
                    Price = model.Price,
                    CategoryId = model.CategoryId,
                    Color = model.Color,
                    Sale=model.Sale,
                    KeySearch = $"{model.BaloName.ToLower()} {model.Description.ToLower()} {model.Trademark.ToLower()} " +
                    $"{categoryRepository.Get(model.CategoryId).CategoryName.ToLower()}" 
                };
                var fileName = string.Empty;
                if (model.Image != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/balos");
                    fileName = $"{Guid.NewGuid()}_{model.Image.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Image.CopyTo(fs);
                    }
                }
                balo.Image = fileName;
                var newEmp = baloRepository.Create(balo);
                ViewBag.Categories = GetCategories();
                return RedirectToAction("Index", "ProductsManage");
            }
            ViewBag.Categories = GetCategories();
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var balo = baloRepository.Get(id);
            if (balo == null)
            {
                ViewBag.Id = id;
                return View("~/Views/Error/ProductNotFound.cshtml");
            }
            if (balo != null)
            {
                var edit = new EditViewHome()
                {
                    Id=balo.BaloId,
                    BaloName = balo.BaloName,
                    Trademark = balo.Trademark,
                    Size = balo.Size,
                    Material = balo.Material,
                    Description = balo.Description,
                    Price = balo.Price,
                    CategoryId = balo.CategoryId,
                    Color = balo.Color,
                    Sale = balo.Sale,
                    AvatarPath=balo.Image
                };
                ViewBag.Categories = GetCategories();
                return View(edit);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Edit(EditViewHome model)
        {
            if (ModelState.IsValid)
            {
                var balo = new Balo()
                {
                    BaloId=model.Id,
                    BaloName = model.BaloName,
                    Trademark = model.Trademark,
                    Size = model.Size,
                    Material = model.Material,
                    Description = model.Description,
                    Price = model.Price,
                    CategoryId = model.CategoryId,
                    Color = model.Color,
                    Sale = model.Sale,
                    KeySearch = $"{model.BaloName.ToLower()} {model.Description.ToLower()} {model.Trademark.ToLower()}" +
                    $" {categoryRepository.Get(model.CategoryId).CategoryName.ToLower()}"
                };
                var fileName = string.Empty;
                if (model.Image != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/balos");
                    fileName = $"{Guid.NewGuid()}_{model.Image.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Image.CopyTo(fs);
                    }
                    balo.Image = fileName;
                    if (!string.IsNullOrEmpty(model.AvatarPath))
                    {
                        string delFile = Path.Combine(webHostEnvironment.WebRootPath,
                                            "images/balos", model.AvatarPath);
                        System.IO.File.Delete(delFile);
                    }
                }
                else
                {
                    fileName = model.AvatarPath;
                }
                balo.Image = fileName;
                var editEmp = baloRepository.Edit(balo);
                if (editEmp != null)
                {
                    return RedirectToAction("Index", "ProductsManage");
                }
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            var product = baloRepository.Get(id);
            if (product == null)
            {
                ViewBag.Id = id;
                return View("~/Views/Error/ProductNotFound.cshtml");
            }
            if (product != null)
            {
                baloRepository.Delete(id);
                string delFile = Path.Combine(webHostEnvironment.WebRootPath,
                                           "images/balos", product.Image);
                System.IO.File.Delete(delFile);
                ViewBag.Categories = GetCategories();
                return RedirectToAction("Index", "ProductsManage");
            }
            return View();
        }

        public List<Category> GetCategories()
        {
            return categoryRepository.Gets().ToList();
        }
    }
}
