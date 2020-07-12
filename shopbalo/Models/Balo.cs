using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopbalo.Models
{
    public class Balo
    {
        public int BaloId { get; set; }
        [Required]
        public string BaloName { get; set; }
        [Required]
        public string Image { get; set; }
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
        public Category Category { get; set; }
        [Required]
        public float Sale { get; set; }
        [Required]
        public float Price { get; set; }
        public string KeySearch { get; set; }
    }
}   