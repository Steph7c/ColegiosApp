using ColegioDomain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioDomain.Services
{
    public interface IUsuarioService
    {
        Task<UsuarioDTO> CrearUsuario(UsuarioDTO usuario);
        Task<UsuarioDTO> ActualizarUsuario(UsuarioDTO usuario);
        Task<bool> EliminarUsuario(Guid id);
        Task<IEnumerable<UsuarioDTO>> ObtenerUsuarios();
        Task<IEnumerable<UsuarioDTO>> ObtenerUsuariosActivos();
        Task<IEnumerable<UsuarioDTO>> ObtenerUsuariosPorNombre(string nombre);
        Task<IEnumerable<UsuarioDTO>> ObtenerUsuariosPorRol(string rol);
        //Adicionales
        Task<IEnumerable<UsuarioDTO>> ObtenerUsuariosInactivos();
        Task<UsuarioDTO> ObtenerUsuarioPorId(string id);

    }
}
