using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopbalo.Models
{
    public class Advertise
    {
        public int AdvertiseId { get; set; }
        [Required]
        public string Image { get; set; }
        public string Description_1 { get; set; }
        public string Description_2 { get; set; }
    }
}
