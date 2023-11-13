using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interface
{
    public interface ICategoriaRepository
    {
        Task<Categoria> GetPorCodigoAsync(string codigo);
        Task<bool> NuevaAsync(Categoria categoria);
        Task<bool> ActualizarAsync(Categoria categoria);
        Task<bool> EliminarAsync(string codigo);
        Task<IEnumerable<Categoria>> GetListaAsync();
    }
}
