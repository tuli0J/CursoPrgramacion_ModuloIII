using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstadoFactura
    {
        [Required(ErrorMessage ="El Codigo es Obligatorio")]
        public string Codigo { get; set; } = string .Empty;
        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        public string Nombre {  get; set; } = string .Empty;

        public EstadoFactura()
        {
        }

        public EstadoFactura(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }
    }



}
