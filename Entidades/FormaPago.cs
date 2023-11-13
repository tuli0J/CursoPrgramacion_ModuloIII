using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FormaPago
    {
        [Required(ErrorMessage ="El Id es Obligatorio")]
        public int Id { get; set; }
        [Required(ErrorMessage ="El Nombre es Obligatorio")]
        public string Nombre { get; set;} = string.Empty;
        public bool EstaActivo { get; set; }

        public FormaPago()
        {
        }

        public FormaPago(int id, string nombre, bool estaActivo)
        {
            Id = id;
            Nombre = nombre;
            EstaActivo = estaActivo;
        }
    }
}
