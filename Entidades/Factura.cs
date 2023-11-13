using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Factura
    {
        [Required(ErrorMessage ="El Codigo es Obligatorio")]
        public string Codigo { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage ="La Identidad del Cliente es Obligatoria")]
        public string IndentidadCliente { get; set; } = string.Empty;
        [Required(ErrorMessage ="El Codigo del Usuario es Obligatorio")]
        public string CodigoUsuario { get; set; } = string.Empty;
        [Required(ErrorMessage ="El Codigo del Estado es Obligatorio")]
        public string CodigoEstado { get; set; } = string.Empty;
        public decimal SubTotal { get; set; }
        public decimal ISV { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        public Factura()
        {
        }

        public Factura(string codigo, DateTime fecha, string indentidadCliente, string codigoUsuario, string codigoEstado, decimal subTotal, decimal iSV, decimal descuento, decimal total)
        {
            Codigo = codigo;
            Fecha = fecha;
            IndentidadCliente = indentidadCliente;
            CodigoUsuario = codigoUsuario;
            CodigoEstado = codigoEstado;
            SubTotal = subTotal;
            ISV = iSV;
            Descuento = descuento;
            Total = total;
        }
    }
}
