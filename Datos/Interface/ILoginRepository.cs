using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interface
{
    public interface ILoginRepository
    {
        Task<bool> ValidarUsuarioAsync(Login login);
    }
}
