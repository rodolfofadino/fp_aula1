using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FiapNew.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public char Sexo { get; set; }
    }
}