using System;

namespace InventoryManagement.Models
{
    public class StockLog
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; } = null!; // Added required modifier
        public int Cantidad { get; set; }
    }
}
