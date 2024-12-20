using Microsoft.EntityFrameworkCore;
using StripsDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL
{
    public class StripsContext : DbContext
    {

        public DbSet<AuteurEF> Auteur { get; set; }
        public DbSet<ReeksEF> Reeks { get; set; }
        public DbSet<StripEF> Strip { get; set; }
        public DbSet<UitgeverijEF> Uitgeverij { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=HP-MAITE\SQLEXPRESS;Initial Catalog=Strips;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        }
    }
}
