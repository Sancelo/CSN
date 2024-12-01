//using Microsoft.EntityFrameworkCore;
//using CSN.Models;
//using Microsoft.EntityFrameworkCore.SqlServer;
//#nullable disable

//namespace CSN.Models
//{
//    public partial class dbCSNContext : DbContext
//    {
//        public dbCSNContext(DbContextOptions<dbCSNContext> options)
//            : base(options)
//        {
//        }

//        //Thu thập thông tin làm phần mềm
//        //public virtual DbSet<tbCongViec> tbCongViecs { get; set; }
        

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//                IConfigurationRoot configuration = new ConfigurationBuilder()
//                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
//                    .AddJsonFile("appsettings.json")
//                    .Build();

//                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DBConnection"), p => p.EnableRetryOnFailure());

//            }
//        }

//        //protected override void OnModelCreating(ModelBuilder modelBuilder)
//        //{
//        //    modelBuilder.Entity<tbCongViec>(entity =>
//        //    {
//        //        entity.Property(e => e.IdCongViec).ValueGeneratedNever();
//        //    });

//        //    OnModelCreatingPartial(modelBuilder);
//        //}
//        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}