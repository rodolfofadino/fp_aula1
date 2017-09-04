using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroPessoas.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Coloca o nome, poxa")]
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public char Sexo { get; set; }
    }
}