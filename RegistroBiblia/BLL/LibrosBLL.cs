using System;
using System.Data.Entity;
using RegistroBiblia.DAL;
using RegistroBiblia.UI.Registros;

namespace RegistroBiblia.BLL

{
    public class LibrosBLL
    {

        public static bool Guardar(rLibros libros)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.libros.Add(libros) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(rLibros libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(libro).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                rLibros libro = new rLibros();
                contexto.libros.Remove(libro);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        /*
        public static Libros Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Libros libro = new Libros();

            try
            {
                libro = contexto.libros.Find(id);
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return libro;
        }

        public static List<Libros> GetList(Expression<Func<Libros, bool>> expression)
        {
            List<Libros> libros = new List<Libros>();
            Contexto contexto = new Contexto();

            try
            {
                libros = contexto.libros.Where(expression).ToList();
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return libros;
        }
        */
    }
}
