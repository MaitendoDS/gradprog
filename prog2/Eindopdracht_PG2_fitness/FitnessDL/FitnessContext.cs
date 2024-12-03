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

        public DbSet<CyclingSession> CyclingSession { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Members> Members { get; set; }
        public DbSet<Program> Program { get; set; }
        public DbSet<ProgramMembers> ProgramMembers { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<RunningSession_Detail> Runningsession_Detail { get; set; }
        public DbSet<RunningSession_Main> Runningsession_Main { get; set; }
        public DbSet<Time_Slot> Time_Slot { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Data Source = HP - MAITE\SQLEXPRESS; Initial Catalog = Gym; Integrated Security = True; Encrypt = True; Trust Server Certificate = True");
            //Niet vergeten om de connectiestring aan te passen
        }
    }
}
