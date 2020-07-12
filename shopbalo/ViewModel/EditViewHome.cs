using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopbalo.ViewModel
{
    public class EditViewHome
    {
        [Required]
        public string BaloName { get; set; }
        public IFormFile Image { get; set; }
        [Required]
        public string Trademark { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string Material { get; set; }
        public string Description { get; set; }
        [Required]
        public string Color { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public float Sale { get; set; }
        [Required]
        public float Price { get; set; }
        public int Id { get; set; }
        public string AvatarPath { get; set; }
    }
}
