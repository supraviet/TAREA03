using System.ComponentModel.DataAnnotations;

namespace TAREA_semana3.Models
{
    public class ProductoMascota
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(0.01, 9999.99, ErrorMessage = "Precio inválido")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La categoría es obligatoria")]
        public string? Categoria { get; set; }
    }
}
