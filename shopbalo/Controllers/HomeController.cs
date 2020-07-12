using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using shopbalo.Models;
using shopbalo.ViewModel;

namespace shopbalo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBaloRepository baloRepository;
        private readonly IAdvertisesRepository advertisesRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ICategoryRepository categoryRepository { get; }

        public HomeController(IBaloRepository baloRepository,
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
            List<Balo> balos = baloRepository.Gets().Take(20).ToList();
            List<Balo> balossale = (from balo in baloRepository.Gets() where balo.Sale > 0 select balo).Take(10).ToList();
            var model = new ViewHome()
            {
                balos = balos,
                balossale = balossale
            };
            List<Category> categories = GetCategories();
            ViewBag.Advertises = advertisesRepository.Gets();
            ViewBag.Categories = categories;
            return View(model);
        }

        public List<Category> GetCategories()
        {
            return categoryRepository.Gets().ToList();
        }

        public IActionResult Detail(int id)
        {
            Balo balo = baloRepository.Get(id);
            if (balo == null)
            {
                return View("~/Views/Error/ProductNotFound.cshtml", id);
            }
            List<Balo> balos= (from b in baloRepository.Gets() where b.CategoryId==balo.CategoryId select b).Take(10).ToList();
            var model = new ViewHome()
            {
                balo = balo,
                balos = balos
            };
            List<Category> categories = GetCategories();
            ViewBag.Categories = categories;
            return View(model);
        }

        public IActionResult Balos(int id)
        {
            var catory = categoryRepository.Get(id);
            if (catory == null)
            {
                return View("~/Views/Error/CategoryNotFound.cshtml", id);
            }
            List<Balo> balos = (from balo in baloRepository.Gets() where balo.CategoryId==catory.CategoryId select balo).ToList();
            List<Balo> balossale = (from balo in baloRepository.Gets() where balo.Sale > 0 select balo).Take(10).ToList();
            var model = new ViewHome()
            {
                balos = balos,
                balossale = balossale
            };
            List<Category> categories = GetCategories();
            ViewBag.Advertises = advertisesRepository.Gets();
            ViewBag.category = catory;
            ViewBag.Categories = categories;
            return View(model);
        }
        [HttpPost]
        public  IActionResult Search(ViewHome model)
        {
            if (model.key == null)
            {
                return RedirectToAction("index", "home");
            }
            List<Balo> balos = (from balo in baloRepository.Gets() where balo.KeySearch.Contains(model.key.ToLower()) select balo).ToList();
            List<Balo> balossale = (from balo in baloRepository.Gets() where balo.Sale > 0 select balo).Take(10).ToList();
            var modelreturl = new ViewHome()
            {
                balos = balos,
                balossale = balossale
            };
            List<Category> categories = GetCategories();
            ViewBag.Advertises = advertisesRepository.Gets();
            ViewBag.Categories = categories;
            return View(modelreturl);
        }

    }
}
