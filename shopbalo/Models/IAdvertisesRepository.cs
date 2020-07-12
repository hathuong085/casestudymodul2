using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopbalo.Models
{
    public interface IAdvertisesRepository
    {
        List<Advertise> Gets();
        bool Edit(Advertise advertise);
    }
}
