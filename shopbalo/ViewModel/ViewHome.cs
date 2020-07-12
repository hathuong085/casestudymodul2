using shopbalo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopbalo.ViewModel
{
    public class ViewHome:Search
    {
        public List<Balo> balos { get; set; }
        public List<Balo> balossale { get; set; }
        public Balo balo { get; set; }
    }
}
