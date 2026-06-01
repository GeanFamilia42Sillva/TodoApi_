using TodoApi.Models.Entities;

namespace TodoApi.Models.DTOs.UsuarioDto
{
    public class UsuarioMapper
    {
        public static UsuarioResponseDTO ToResponse(this Usuario u) => new()
        {
            Id = u.Id,
            Nome = u.Nome,
            Email = u.Email
        };
        public static Usuario ToEntity(this UsuarioCreateDto dto) => new()
        {
            Id = Guid.NewGuid(),
            Nome = dto.Nome.Trim(),
            Email = dto.Email.Trim().ToLower()
        };
    }
}