using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace InventoryManagement.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                // Ensure no duplicate data
                if (context.Productos.Any())
                {
                    return; // Data already exists
                }

                // Add example data
                context.Categorias.AddRange(
                    new Categoria { Nombre = "Electrónica" },
                    new Categoria { Nombre = "Hogar" }
                );

                context.StockLogs.AddRange(
                    new StockLog { ProductoId = 1, Cantidad = 10 }, // Example StockLog
                    new StockLog { ProductoId = 2, Cantidad = 5 }   // Example StockLog
                );

                context.Productos.AddRange(
                    new Producto { Nombre = "Televisor", CategoriaId = 1 },
                    new Producto { Nombre = "Aspiradora", CategoriaId = 2 }
                );

                context.SaveChanges();
            }
        }
    }
}
