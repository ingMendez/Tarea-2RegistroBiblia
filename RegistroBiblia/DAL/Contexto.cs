using System.Data.Entity;
using RegistroBiblia.UI.Registros;
using RegistroLibroBiblia.Entidades;

namespace RegistroBiblia.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Libros> libros { get; set; }

        public Contexto() : base("ConStr")
        { }
    }
}
