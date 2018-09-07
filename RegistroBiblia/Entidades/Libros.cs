using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RegistroLibroBiblia.Entidades
{
    public class Libros
    {
        [Key]
        public int LibroId { get; set; }

        public string Descripcion { get; set; }

        public string Siglas { get; set; }

        public string TipoId { get; set; }

        //public DateTime Fechas { get; set;}

        public Libros()
        {
            LibroId = 0;
            Descripcion = string.Empty;
            Siglas = string.Empty;
            TipoId = string.Empty;
           // Fechas = DateTime.Now;

        }
    }
}
