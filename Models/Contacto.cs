using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_final_Crud.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string direccion { get; set; }
        public string Email { get; set; }
        public bool Verificado { get; set; }
    }
}
