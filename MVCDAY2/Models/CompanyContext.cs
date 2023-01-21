using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace MVCDAY2.Models
{
    public class CompanyContext:DbContext
    {
        public virtual DbSet<dependent> Dependents { get; set; }
        public virtual DbSet<department> Departments { get; set; }
        public virtual DbSet<employee> Employees { get; set; }
        public virtual DbSet<project> Projects { get; set; }
        public virtual DbSet<locations> Locations { get; set; }
        public virtual DbSet<works_on> Works { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SGU21BB\\SS17;Initial Catalog=Company.net;Integrated Security=True;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<works_on>().HasKey("ESSN", "Pnum");//composite primary key
            modelBuilder.Entity<locations>().HasKey("deptnum", "location");
            //modelBuilder.Entity<employee>().HasOne(s=>s.super);

        }


    }
}
