using Hospital.Entities;
using Microsoft.EntityFrameworkCore;
namespace Hospital.DbContextAndBuilders.ApiDbContext
{
    public class HospitalDbContext : DbContext
    {
        private string _connectionstring = "Server=LAPTOP-5PVPJG7V;Database=HospitalDb;Trusted_Connection=True;";

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Visit> Visits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .Property(d => d.Name)
                .IsRequired();

            modelBuilder.Entity<Patient>()
                .Property(p => p.Name)
                .IsRequired();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionstring);
        }
    }
}
