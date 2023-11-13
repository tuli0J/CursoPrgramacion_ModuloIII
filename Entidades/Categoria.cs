using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        [Required(ErrorMessage = "El codigo es obligatorio")]
        public string Codigo {get; set;} = string.Empty;
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public  string Nombre { get; set;} = string.Empty;
        public bool EstaActivo { get; set;}

        public Categoria() { }

        public Categoria(string codigo, string nombre, bool estaActivo)
        {
            Codigo = codigo;
            Nombre = nombre;
            EstaActivo = estaActivo;
        }
    }
}
