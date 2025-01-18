using Microsoft.EntityFrameworkCore;
using InventoryManagement.Models;
using Pomelo.EntityFrameworkCore.MySql;

namespace InventoryManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<StockLog> StockLogs { get; set; }
    }
}
