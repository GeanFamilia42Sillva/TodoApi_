using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models.DTOs.UsuarioDto
{
    public class UsuarioCreateDto
    {
        [Required, MinLength(3), MaxLength(50)]
        public string Nome { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(8), MaxLength(16)]
        public string Senha { get; set; }
    }
}