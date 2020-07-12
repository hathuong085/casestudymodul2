using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopbalo.Models
{
    public interface IBaloRepository
    {
        IEnumerable<Balo> Gets();
        Balo Get(int id);
        Balo Create(Balo Balo);
        bool Delete(int id);
        Balo Edit(Balo Balo);
    }
}
