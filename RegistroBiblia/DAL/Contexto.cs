using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using RegistroBiblia.Entidades;

namespace RegistroBiblia.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Libros> libros { get; set; }

        public Contexto() : base("ConStr")
        { }
    }
}
