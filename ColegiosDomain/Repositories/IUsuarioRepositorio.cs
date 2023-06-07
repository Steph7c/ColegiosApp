using ColegioDomain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioDomain.Repositories
{
    public interface IUsuarioRepositorio
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
        Task<UsuarioDTO> ObtenerUsuarioPorId(Guid id);

    }
}
