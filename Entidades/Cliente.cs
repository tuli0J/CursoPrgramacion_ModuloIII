using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        [Required(ErrorMessage ="La Identidad es Requerida")]
        public  string Identidad { get; set; } = string.Empty;
        [Required(ErrorMessage ="El Nombre es Requerido")]
        public  string Nombre { get; set;} = string.Empty;
        public string? Direccion { get; set;}
        public DateOnly FechadeNacimiento { get; set;}
        public string? Telefono { get; set; }
        public string? Correo { get; set;}
        public byte[]? Foto { get; set;}
        public bool EstaActivo { get; set;}

        public Cliente()
        {
        }

        public Cliente(string identidad, string nombre, string? direccion, DateOnly fechadeNacimiento, string? telefono, string? correo, byte[]? foto, bool estaActivo)
        {
            Identidad = identidad;
            Nombre = nombre;
            Direccion = direccion;
            FechadeNacimiento = fechadeNacimiento;
            Telefono = telefono;
            Correo = correo;
            Foto = foto;
            EstaActivo = estaActivo;
        }
    }
}
