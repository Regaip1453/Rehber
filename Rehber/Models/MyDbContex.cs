using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Rehber.Models
{
    public class MyDbContex : DbContext
    {
       public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<KisiDetay>KisiDetaylar{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=REGAIP\\SQLEXPRESS;Database=RehberDB;Trusted_connection=true;trustservercertificate=true");
        }

    }
}
