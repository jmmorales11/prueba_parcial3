using System.ComponentModel.DataAnnotations;
using System.Data;

namespace ProyectoMVC.Models
{
    public class ClienteSql
    {
        public int Codigo { get; set; }

        [Required]
        [StringLength(10)]
        public string Cedula { get; set; }
        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public Boolean Estado { get; set; }
        public float Saldo { get; set; }    
    }
}
