using ColegioData.Context;
using ColegioDomain.DTO;
using ColegioDomain.Repositories;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ColegioInfrastructure.Repositories
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        //private readonly ColegioDbContext _context;
        private readonly DapperContext _dapperContext;
        public UsuarioRepositorio(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }
        public async Task<UsuarioDTO> ActualizarUsuario(UsuarioDTO usuario)
        {
            using (var connetion = _dapperContext.createConnection())
            {
                var parametros = new DynamicParameters();
                usuario.Id = Guid.NewGuid();
                parametros.Add("@Id", usuario.Id);
                parametros.Add("@Nombres", usuario.Nombres);
                parametros.Add("@Apellidos", usuario.Apellidos);
                parametros.Add("@FechaNacimiento", usuario.FechaNacimiento);
                parametros.Add("@Celular", usuario.Celular);
                parametros.Add("@Rol", usuario.Rol);
                parametros.Add("@FechaIngreso", usuario.FechaIngreso);
                parametros.Add("@Estado", usuario.Estado);
                await connetion.ExecuteAsync("ActualizarUsuario", parametros, commandType: CommandType.StoredProcedure);
                    return usuario;
            }

        }

        public async Task<UsuarioDTO> CrearUsuario(UsuarioDTO usuario)
        {
            using (var connetion = _dapperContext.createConnection())
            {
                var parametros = new DynamicParameters();
                usuario.Id = Guid.NewGuid();
                parametros.Add("@Id", usuario.Id);
                parametros.Add("@Nombres", usuario.Nombres);
                parametros.Add("@Apellidos", usuario.Apellidos);
                parametros.Add("@FechaNacimiento", usuario.FechaNacimiento);
                parametros.Add("@Celular", usuario.Celular);
                parametros.Add("@Rol", usuario.Rol);
                parametros.Add("@FechaIngreso", usuario.FechaIngreso);
                parametros.Add("@Estado", usuario.Estado);
                await connetion.ExecuteAsync("CrearUsuario", parametros, commandType: CommandType.StoredProcedure);
                return usuario;
            }
        }

        public async Task<bool> EliminarUsuario(Guid id)
        {
            using (var connection = _dapperContext.createConnection())
            {
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                await connection.ExecuteAsync("EliminarUsuarioPorId", parametros, commandType: CommandType.StoredProcedure);
                return true;
            }
            
        }

        public async Task<IEnumerable<UsuarioDTO>> ObtenerUsuarios()
        {
            using (var connection = _dapperContext.createConnection())
            {
                var usuarios = await connection.QueryAsync<UsuarioDTO>(
                    sql: "ObtenerUsuarios",
                    commandType: CommandType.StoredProcedure);
                return usuarios.ToList();
            }
        }

        public async Task<IEnumerable<UsuarioDTO>> ObtenerUsuariosActivos()
        {
            using (var connection = _dapperContext.createConnection())
            {
                var usuarios = await connection.QueryAsync<UsuarioDTO>(
                    sql: "ObtenerUsuariosActivos",
                    commandType: CommandType.StoredProcedure);
                return usuarios.ToList();
            }
        }
        
        public async Task<IEnumerable<UsuarioDTO>> ObtenerUsuariosPorNombre(string nombre)
        {
            using (var connection = _dapperContext.createConnection())
            {
                var parametros = new DynamicParameters();
                parametros.Add("@Nombre", nombre);
                var usuarios = await connection.QueryAsync<UsuarioDTO>("ObtenerUsuariosPorNombre", parametros,
                    commandType: CommandType.StoredProcedure);
                return usuarios.ToList();
            }

        }
        
        public async Task<IEnumerable<UsuarioDTO>> ObtenerUsuariosPorRol(string rol)
        {
            using (var connection = _dapperContext.createConnection())
            {
                var parametros = new DynamicParameters();
                parametros.Add("@Rol", rol);
                var usuarios = await connection.QueryAsync<UsuarioDTO>("ObtenerUsuariosPorRol", parametros, 
                commandType: CommandType.StoredProcedure);
                return usuarios.ToList();
            }

        }
        //Adicionales
        public async Task<IEnumerable<UsuarioDTO>> ObtenerUsuariosInactivos()
        {
            using (var connection = _dapperContext.createConnection())
            {
                var usuarios = await connection.QueryAsync<UsuarioDTO>(
                    sql: "ObtenerUsuariosInactivos",
                    commandType: CommandType.StoredProcedure);
                return usuarios.ToList();
            }

        }

        public async Task<UsuarioDTO> ObtenerUsuarioPorId(Guid id)
        {
            using (var connection = _dapperContext.createConnection())
            {
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var usuario = await connection.QueryFirstAsync<UsuarioDTO>("ObtenerUsuarioPorId", parametros,
                commandType: CommandType.StoredProcedure);
                return usuario;
            }
        }

    }
}
