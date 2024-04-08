using LoginApplication1.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoginApplication1.Entity
{
    public class CreateContext : DbContext
    {
        public DbSet<Create> Logindetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=NANDUHARI;initial catalog=MyApplication;trusted_connection=true;TrustServerCertificate=True");
        }

    }
}
