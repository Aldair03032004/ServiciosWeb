using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventoryManagement.Controllers
{
    public class StockLogController : Controller
    {
        private readonly AppDbContext _context;

        public StockLogController(AppDbContext context)
        {
            _context = context;
        }

        // GET: StockLog
        public async Task<IActionResult> Index()
        {
            var stockLogs = _context.StockLogs.Include(s => s.Producto);
            return View(await stockLogs.ToListAsync());
        }

        // GET: StockLog/Create
        public IActionResult Create()
        {
            ViewData["ProductoId"] = new SelectList(_context.Productos, "Id", "Nombre");
            return View();
        }

        // POST: StockLog/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductoId,Cantidad")] StockLog stockLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stockLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductoId"] = new SelectList(_context.Productos, "Id", "Nombre", stockLog.ProductoId);
            return View(stockLog);
        }
    }
}
