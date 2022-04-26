using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Usuario
{
    [Required(ErrorMessage = "El Campo Codigo es Obligatorio")]
    public string Codigo { get; set; }
    [Required(ErrorMessage = "El Campo Nombre es Obligatorio")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "El Campo Rol es Obligatorio")]
    public string Rol { get; set; }
    public string Clave { get; set; }
    public bool EstaActivo { get; set; }
}

/*
{
        [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

        private IEnumerable<Usuario> usuariosLista { get; set; }


        protected override async Task OnInitializedAsync()
        {
            usuariosLista = await _usuarioServicio.GetLista();
        }
*/