using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JogadorCRUD.Entity.Models
{
    public class Contexto : DbContext
    {
        public Contexto() : base(System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString) { }
        public DbSet<Jogador> jogador { get; set; }

    }
}