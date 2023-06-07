using AutoMapper;
using ColegioAPI.Models;
using ColegioDomain.DTO;

namespace ColegioAPI.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UsuarioModel, UsuarioDTO>()
                .ForMember(u => u.Id,
                opt => opt.MapFrom(src => Guid.Parse(src.Id)));

            CreateMap<UsuarioDTO, UsuarioModel>()
                .ForMember(u => u.Id,
                opt => opt.MapFrom(src => src.Id.ToString()));
        }
    }
}
