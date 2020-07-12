using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopbalo.Models
{
    public class BaloRepository:IBaloRepository
    {
        private readonly AppDbConText context;

        public BaloRepository(AppDbConText context)
        {
            this.context = context;
        }
        public Balo Create(Balo pd)
        {
            context.Balos.Add(pd);
            context.SaveChanges();
            return pd;
        }

        public bool Delete(int id)
        {
            var pd = Get(id);
            if (pd != null)
            {
                context.Balos.RemoveRange(pd);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Balo Edit(Balo pd)
        {
            var edit = context.Balos.Attach(pd);
            edit.State = EntityState.Modified;
            context.SaveChanges();
            return pd;
        }

        public Balo Get(int id)
        {
            return context.Balos.Find(id);
        }
        public IEnumerable<Balo> Gets()
        {
            return context.Balos;
        }
    }
}
