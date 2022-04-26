using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces;

public interface IUsuarioRepositorio
{
    Task<IEnumerable <Usuario>> GetLista();

    Task<Usuario> GetPorCodigo(string codigo);
    Task<bool> ValidaUsuario(Login login);
}
