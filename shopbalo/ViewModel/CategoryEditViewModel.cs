using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopbalo.ViewModel
{
    public class CategoryEditViewModel
    {
        public int CategoryId { get; set; }
        public string ImgParth { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public IFormFile CategoryImg { get; set; }
    }
}
