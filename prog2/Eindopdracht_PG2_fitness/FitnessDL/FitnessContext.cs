using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using FitnessDL.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
 

namespace FitnessDL
{
    public class FitnessContext: DbContext
    {

        public DbSet<CyclingSessionEF> CyclingSession { get; set; }
        public DbSet<EquipmentEF> Equipment { get; set; }
        public DbSet<MemberEF> Members { get; set; }
        public DbSet<ProgrammaEF> Programma { get; set; }
        public DbSet<ReservationEF> Reservations { get; set; }
        public DbSet<RunningSession_DetailEF> Runningsession_Detail { get; set; }
        public DbSet<RunningSession_MainEF> Runningsession_Main { get; set; }
        public DbSet<Time_SlotEF> Time_Slot { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=HP-MAITE\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
           
        }
    }
}
