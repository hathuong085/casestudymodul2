using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopbalo.Models
{
    public class AppDbConText : IdentityDbContext<ApplicationUser>
    {
        public AppDbConText(DbContextOptions<AppDbConText> options) : base(options)
        {

        }
        public DbSet<Advertise> Advertises { get; set; }
        public DbSet<Balo> Balos { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
