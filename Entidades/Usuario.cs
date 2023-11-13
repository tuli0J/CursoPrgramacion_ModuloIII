using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        [Required(ErrorMessage ="El codigoes Obligatorio")]
        public string Codigo { get; set; } = string.Empty;
        [Required(ErrorMessage ="El Nombre es Obligatorio")]
        public string Nombre {  get; set; } = string.Empty;
        public string? Correo {  get; set; }
        public string? Clave { get; set; }
        public byte[]? Foto { get; set; }
        public string Rol { get; set; } = string.Empty;
        public bool EstaActivo { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigo, string nombre, string? correo, string? clave, byte[]? foto, string rol, bool estaActivo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Correo = correo;
            Clave = clave;
            Foto = foto;
            Rol = rol;
            EstaActivo = estaActivo;
        }
    }
}
