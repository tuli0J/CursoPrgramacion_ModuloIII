﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {
        [Required(ErrorMessage ="Ingrese el Usuario")]
        public string Codigo { get; set; } = string.Empty;
        [Required(ErrorMessage ="Ingrese la Contraseña")]
        public string Clave {  get; set; } = string.Empty;

        public Login()
        {
        }

        public Login(string codigo, string clave)
        {
            Codigo = codigo;
            Clave = clave;
        }
    }
}
