using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopbalo.Models
{
    public class AdvertisesRepository : IAdvertisesRepository
    {
        private readonly AppDbConText conText;

        public AdvertisesRepository(AppDbConText conText)
        {
            this.conText = conText;
        }
        public bool Edit(Advertise advertise)
        {
            var edit = conText.Advertises.Attach(advertise);
            edit.State = EntityState.Modified;
            conText.SaveChanges();
            return true;
        }

        public List<Advertise> Gets()
        {
            return conText.Advertises.ToList();
        }
    }
}
