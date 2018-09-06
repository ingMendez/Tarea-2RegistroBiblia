using System.Data.Entity;
using RegistroBiblia.UI.Registros;

namespace RegistroBiblia.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<rLibros> libros { get; set; }

        public Contexto() : base("ConStr")
        { }
    }
}
