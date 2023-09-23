using OneMVCEFApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using FirstMVCefApp.Models;

namespace OneMVCEFApp.Models
{
    public class HospitalDbContext:DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String conString = @"server=200411LTP2773\SQLEXPRESS;database=HospitaDB;
                integrated security=true;Encrypt=false;";
            optionsBuilder.UseSqlServer(conString);
        }
    }
}
