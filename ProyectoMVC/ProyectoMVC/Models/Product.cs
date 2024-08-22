using System.ComponentModel.DataAnnotations;

namespace ProyectoMVC.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Nombre de Producto")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Categoría")]
        public string Category { get; set; }

        [Required]
        [Range(0.1, 1000000, ErrorMessage = "El precio debe estar entre 0.1 y 1,000,000.")]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad en stock debe ser al menos 1.")]
        [Display(Name = "Cantidad en Stock")]
        public int StockQuantity { get; set; }
    }
}
