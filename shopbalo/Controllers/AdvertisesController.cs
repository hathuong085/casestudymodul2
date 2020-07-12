using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shopbalo.Models;
using shopbalo.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace shopbalo.Controllers
{
    public class AdvertisesController:Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        public AppDbConText ConText { get; }

        public AdvertisesController(IWebHostEnvironment webHostEnvironment,
            AppDbConText conText)
        {
            this.webHostEnvironment = webHostEnvironment;
            ConText = conText;
        }

        public IActionResult Index()
        {
            List<Advertise> advertises = ConText.Advertises.ToList();
            return View(advertises);
        }
        public IActionResult Edit(int id)
        {
            var advert = ConText.Advertises.Find(id);
            if (advert == null)
            {
                ViewBag.Id = id;
                return View("~/Views/Error/AdvertisesNotFound.cshtml");
            }
            if (advert != null)
            {
                var model = new EditAdvertises()
                {
                    AdvertiseId=advert.AdvertiseId,
                    Description_1=advert.Description_1,
                    Description_2=advert.Description_2,
                    Image=advert.Image
                };
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Edit(EditAdvertises model)
        {
            if (ModelState.IsValid)
            {
                var adver = new Advertise()
                {
                    Description_1 = model.Description_1,
                    Description_2 = model.Description_2,
                    AdvertiseId=model.AdvertiseId,
                    Image = model.Image
                };
                var fileName = string.Empty;
                if (model.ImageParth != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/ImgAdvertises");
                    fileName = $"{Guid.NewGuid()}_{model.ImageParth.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.ImageParth.CopyTo(fs);
                    }
                    adver.Image = fileName;
                    if (!string.IsNullOrEmpty(model.Image))
                    {
                        string delFile = Path.Combine(webHostEnvironment.WebRootPath,
                                            "images/ImgAdvertises", model.Image);
                        System.IO.File.Delete(delFile);
                    }
                }
                else
                {
                    fileName = model.Image;
                }
                adver.Image = fileName;
                var edit = ConText.Advertises.Attach(adver);
                edit.State = EntityState.Modified;
                ConText.SaveChanges();
                if (adver != null)
                {
                    return RedirectToAction("Index", "Advertises");
                }
            }
            return View();
        }

    }
}
