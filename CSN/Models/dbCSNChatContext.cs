using Microsoft.EntityFrameworkCore;
using CSN.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
#nullable disable

namespace CSN.Models
{
    public partial class dbCSNChatContext : DbContext
    {
        public dbCSNChatContext(DbContextOptions<dbCSNChatContext> options)
            : base(options)
        {
        }
        public virtual DbSet<tbMsg> tbMsgs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DBConnection"), p => p.EnableRetryOnFailure());

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbMsg>(entity =>
            {
                entity.Property(e => e.IdMsg).ValueGeneratedOnAdd();

            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}