﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor
    {
        [Required(ErrorMessage ="El codigo es Obligatorio")]
        public string Codigo { get; set; } = string.Empty;
        [Required(ErrorMessage ="El Nombre es Obligatorio")]
        public string Nombre { get; set; } = string.Empty;
        public string? Direccion {  get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool EstaActivo { get; set; }

        public Proveedor()
        {
        }

        public Proveedor(string codigo, string nombre, string? direccion, string? telefono, string? correo, DateTime fechaCreacion, bool estaActivo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
            FechaCreacion = fechaCreacion;
            EstaActivo = estaActivo;
        }
    }
}
