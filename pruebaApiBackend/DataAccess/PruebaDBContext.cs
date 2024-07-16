using Microsoft.EntityFrameworkCore;
using pruebaApiBackend.Models.DataModels;

namespace pruebaApiBackend.DataAccess
{
    public class PruebaDBContext : DbContext
    {
        public PruebaDBContext(DbContextOptions<PruebaDBContext> options) : base(options)
        {
        }
        // Se crea las tablas 
        public DbSet<Product>? Product { get; set; }
    }
}

