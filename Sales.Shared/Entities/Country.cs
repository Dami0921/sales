using System.ComponentModel.DataAnnotations;

namespace Sales.Shared.Entities
{
    public class Country
    {
        // propiedad ID
        public int Id { get; set; }

        // atributo name pais
        [Display(Name = "País")]
        // atributo pais obligatorio
        [Required(ErrorMessage = "El campo {0} es obligatorrio.")]
        // atributo carateres maximos para el pais
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]

        // propiedad nombre pais
        public string Name { get; set; } = null!;
    }
}
