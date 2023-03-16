using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using PageBE.Helper;

namespace PageBE.DataModel
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<StatusStudenta> statusStudentas { get; set; }
        public virtual DbSet<Studenti> Studentis { get; set; }
        public virtual DbSet<Kurs> Kurs { get; set; }
        public virtual DbSet<KursStudenta> KursStudentas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PageDB1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedStatus();
            modelBuilder.SeedKurs();
            modelBuilder.SeedStudenta();
            modelBuilder.SeedKursStudenta();
        }
    }
}
