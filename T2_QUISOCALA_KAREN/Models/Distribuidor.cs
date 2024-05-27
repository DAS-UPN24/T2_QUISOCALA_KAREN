using System.ComponentModel.DataAnnotations;

namespace T2_QUISOCALA_KAREN.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El Nombre de Distribuidor es obligatorio.")]
        public string NombreDistribuidor { get; set; }
        [Required(ErrorMessage ="La Razon Social es obligatoria.")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage ="El telefono es obligatorio.")]
        public int Telefono {  get; set; }
        [Required(ErrorMessage ="El Año Inicio de Distribucion es obligatorio.")]
        [Range(1900,3000,ErrorMessage = "El Año Inicio de Distribucion debe ser entre 1900 a 3000.")]
        public int? AnioInicioOperacion { get; set; }
        [Required(ErrorMessage ="El Contacto es obligatorio.")]
        public string Contacto { get; set; }
    }
}
