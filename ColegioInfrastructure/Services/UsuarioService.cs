using ColegioDomain.DTO;
using ColegioDomain.Repositories;
using ColegioDomain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioInfrastructure.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepositorio _repositorio;

        public UsuarioService(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<UsuarioDTO> ActualizarUsuario(UsuarioDTO usuario)
        {
            return await _repositorio.ActualizarUsuario(usuario);
        }

        public async Task<UsuarioDTO> CrearUsuario(UsuarioDTO usuario) => await _repositorio.CrearUsuario(usuario);

        public async Task<bool> EliminarUsuario(Guid id) => await _repositorio.EliminarUsuario(id);

        public async Task<IEnumerable<UsuarioDTO>> ObtenerUsuarios() => await _repositorio.ObtenerUsuarios();

        public async Task<IEnumerable<UsuarioDTO>> ObtenerUsuariosActivos() => await _repositorio.ObtenerUsuariosActivos();

        public async Task<IEnumerable<UsuarioDTO>> ObtenerUsuariosPorNombre(string nombre) => await _repositorio.ObtenerUsuariosPorNombre(nombre);


        public async Task<IEnumerable<UsuarioDTO>> ObtenerUsuariosPorRol(string rol) => await _repositorio.ObtenerUsuariosPorRol(rol);

        //Adicionales
        public async Task<IEnumerable<UsuarioDTO>> ObtenerUsuariosInactivos() => await _repositorio.ObtenerUsuariosInactivos();
        public async Task<UsuarioDTO> ObtenerUsuarioPorId(string id)
        {
            return await _repositorio.ObtenerUsuarioPorId(Guid.Parse(id));
        } 



    }
}
