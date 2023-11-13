using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interface
{
    public interface IClienteRepository
    {
        Task<Cliente> GetPorIdentidadAsync(string identidad);
        Task<bool> NuevoAsync(Cliente cliente);
        Task<bool> ActualizarAsync(Cliente cliente);
        Task<bool> EliminarAsync(string identidad);
        Task<IEnumerable<Cliente>> GetListaAsync();
    }
}
