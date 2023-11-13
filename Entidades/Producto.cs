using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        [Required(ErrorMessage ="El codigo es Obligatorio")]
        public string Codigo { get; set; } = string.Empty;
        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public string Descripcion { get; set; } = string.Empty;
        public int Precio { get; set; }
        public int Existencia { get; set; }
        public byte[]? Foto { get; set; }
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "El CodigoCategoria es Obligatorio")]

        public string CodigoCategoria { get; set; } = string.Empty;
        [Required(ErrorMessage = "El Codigo Usuario es Obligatorio")]
        public string CodigoUsuario { get; set; } = string.Empty;
        public decimal ISV { get; set; }
        public bool EstaActivo { get; set; }

        public Producto()
        {
        }

        public Producto(string codigo, string descripcion, int precio, int existencia, byte[]? foto, DateTime fechaCreacion, string codigoCategoria, string codigoUsuario, decimal iSV, bool estaActivo)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Existencia = existencia;
            Foto = foto;
            FechaCreacion = fechaCreacion;
            CodigoCategoria = codigoCategoria;
            CodigoUsuario = codigoUsuario;
            ISV = iSV;
            EstaActivo = estaActivo;
        }
    }
}
