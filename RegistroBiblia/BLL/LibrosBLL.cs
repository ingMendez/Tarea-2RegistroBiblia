using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using RegistroBiblia.DAL;
using RegistroBiblia.Entidades;
using System.Linq.Expressions;

namespace RegistroBiblia.BLL

{
    public class LibrosBLL
    {

        public static bool Guardar(Libros libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.libros.Add(libro) != null)
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

        public static bool Modificar(Libros libro)
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
                Libros libro = new Libros();
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
