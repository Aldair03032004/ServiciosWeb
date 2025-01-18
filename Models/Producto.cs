namespace InventoryManagement.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int CategoriaId { get; set; } // This property can be made required
        public Categoria Categoria { get; set; } = null!; // Added required modifier
    }
}
