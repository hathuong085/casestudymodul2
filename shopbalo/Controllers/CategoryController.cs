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
    public class CategoryController:Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ICategoryRepository categoryRepository;
        public IBaloRepository baloRepository { get; }

        public CategoryController(IWebHostEnvironment webHostEnvironment,
            IBaloRepository baloRepository,
            ICategoryRepository categoryRepository)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.baloRepository = baloRepository;
            this.categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var Categories = categoryRepository.Gets().ToList();
            return View(Categories);
        }
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var category = new Category()
                {
                    CategoryName = model.CategoryName

                };
                var fileName = string.Empty;
                if (model.CategoryImg != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/Category");
                    fileName = $"{Guid.NewGuid()}_{model.CategoryImg.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.CategoryImg.CopyTo(fs);
                    }
                }
                category.Image = fileName;
                var newEmp = categoryRepository.Create(category);
                ViewBag.Categories = categoryRepository.Gets();
                return RedirectToAction("Index", "Category");
            }
            ViewBag.Categories = categoryRepository.Gets();
            return View();
        }
        public ViewResult Edit(int id)
        {
            var category = categoryRepository.Get(id);
            if (category == null)
            {
                return View("~/Views/Error/EmployeeNotFound.cshtml", id);
            }
            var empEdit = new CategoryEditViewModel()
            {
                ImgParth = category.Image,
                CategoryName = category.CategoryName,
                CategoryId = category.CategoryId
            };
            return View(empEdit);
        }

        [HttpPost]
        public IActionResult Edit(CategoryEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var category = new Category()
                {
                    CategoryName = model.CategoryName,
                    CategoryId = model.CategoryId,
                    Image = model.ImgParth
                };
                var fileName = string.Empty;
                if (model.CategoryImg != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/Category");
                    fileName = $"{Guid.NewGuid()}_{model.CategoryImg.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.CategoryImg.CopyTo(fs);
                    }
                    category.Image = fileName;
                    if (!string.IsNullOrEmpty(model.ImgParth))
                    {
                        string delFile = Path.Combine(webHostEnvironment.WebRootPath,
                                            "images/Category", model.ImgParth);
                        System.IO.File.Delete(delFile);
                    }
                }
                else
                {
                    fileName = model.ImgParth;
                }
                category.Image = fileName;
                var editEmp = categoryRepository.Edit(category);
                if (editEmp != null)
                {
                    return RedirectToAction("Index", "Category");
                }
            }

            return View();
        }
        public IActionResult Delete(int id)
        {
            Category category = categoryRepository.Get(id);
            if (category == null)
            {
                ViewBag.Id = id;
                return View("~/Views/Error/CategoryNotFound.cshtml");
            }
            if (category != null)
            {
                var result = categoryRepository.Delete(id);
                return RedirectToAction("index", "Category");
            }
            return View();
        }
    }
}
