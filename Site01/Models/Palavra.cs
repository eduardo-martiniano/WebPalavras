using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Models
{
    public class Palavra
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo 'Nome' é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O campo 'Nome' deve conter o máximo de 50 caracteres!")]
        public string Nome { get; set; }

        public byte Dificuldade { get; set; }
    }
}
