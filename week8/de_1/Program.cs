using Microsoft.EntityFrameworkCore;

namespace de_1
{
    internal class Book
    {
        public int Id { get; set; }
        public string? TenSach { get; set; }
        public decimal Price { get; set; }
        public int SoLuong { get; set; }
        public string? MoTa { get; set; }
    }
    internal class BookDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"SERVER=DESKTOP-VLGFN5B\SQLEXPRESS;Database=dtc225180321_1;Trusted_Connection=True;TrustServerCertificate=True;ConnectRetryCount=0");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(x => x.Price).HasColumnType("decimal(18,2)");
        }
        public DbSet<Book> Books { get; set; }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}