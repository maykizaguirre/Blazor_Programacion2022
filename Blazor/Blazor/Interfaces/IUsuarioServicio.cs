using Modelos;

namespace Blazor.Interfaces
{
    public interface IUsuarioServicio
    {
        
        Task<IEnumerable<Usuario>> GetLista();

        Task<Usuario> GetPorCodigo(string codigo);
    }
}
