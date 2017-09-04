using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CadastroPessoas.Models
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        {
        }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}