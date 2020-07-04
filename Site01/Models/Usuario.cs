using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo 'E-mail' é obrigatório!")]
        [EmailAddress(ErrorMessage = "O campo 'E-mail' é inválido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo 'Senha' é obrigatório!")]
        public string Senha { get; set; }
    }
}
