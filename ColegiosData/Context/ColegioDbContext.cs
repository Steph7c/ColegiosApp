
using ColegioDomain.DTO;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioData.Context
{
    public class ColegioDbContext : IdentityDbContext

    {
        public DbSet<UsuarioDTO> Usuarios { get; set; }

        public ColegioDbContext(DbContextOptions options): base(options)
        {
            
        }
    }

   
}
