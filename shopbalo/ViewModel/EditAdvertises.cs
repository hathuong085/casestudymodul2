using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopbalo.ViewModel
{
    public class EditAdvertises
    {
        public int AdvertiseId { get; set; }
        public string Image { get; set; }
        public string Description_1 { get; set; }
        public string Description_2 { get; set; }
        public IFormFile ImageParth { get; set; }
    }
}
