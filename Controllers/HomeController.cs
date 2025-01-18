using InventoryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; // Ensure to include this for IEnumerable

namespace InventoryManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Retrieve the list of products from the data source
            var model = GetProducts(); // Replace with actual data retrieval logic
            return View(model);
        }

        private IEnumerable<Producto> GetProducts()
        {
            // This method should return a list of Producto objects
            // For now, returning an empty list as a placeholder
            return new List<Producto>();
        }

        public IActionResult Stock()
        {
            // Logic for Stock view
            return View(); // Devolverá la vista Stock/Index.cshtml
        }

        public IActionResult Categoria()
        {
            // Logic for Categoria view
            return View(); // Devolverá la vista Categoria/Index.cshtml
        }

        public IActionResult Error()
        {
            var requestId = HttpContext.TraceIdentifier;
            return View(new ErrorViewModel { RequestId = requestId });
        }
    }
}
