using System.ComponentModel.DataAnnotations;

namespace WEPAPPRAzor.Modelos
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }

        [Required]
        [Display(Name = "Nombre del curso")]
        public string? Nombre { get; set; }

        [Display(Name = "Cantidad de capitulos")]
        public int Cantidad { get; set; }

        [Display(Name = "Precio en pesos UY")]
        public int Precio { get; set; }

        [Display(Name = "Fecha de creación")]
        public DateTime Fecha { get; set; }
    }
}
