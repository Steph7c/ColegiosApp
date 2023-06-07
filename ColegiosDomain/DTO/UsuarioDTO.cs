using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioDomain.DTO
{
    public class UsuarioDTO
    {
        public Guid Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Celular { get; set; }
        public string Rol { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
    }
}

