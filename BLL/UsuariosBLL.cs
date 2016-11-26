using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.Entity;

namespace BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            bool retorno = false;
            try
            {
                UsuariosDB db = new UsuariosDB();
                db.usuarios.Add(usuario);
                db.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }

            return retorno;
        }
        
        public static bool Eliminar(int ID)
        {
            bool retorno = false;
            var db = new UsuariosDB();
            Usuarios usuario = Buscar(ID);
            if (usuario != null)
            {
                db.Entry(usuario).State = EntityState.Deleted;
                db.SaveChanges();
                retorno = true;
            }
            return retorno;         
        }

        public static Usuarios Buscar(int ID)
        {
            var db = new UsuariosDB();

            return db.usuarios.Find(ID);

        }

        public static void Modificar(Usuarios usuario)
        {
            var db = new UsuariosDB();
            db.Entry(usuario).State = EntityState.Modified;
            db.SaveChanges();
            
        }

        public static List <Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new UsuariosDB();

            lista = db.usuarios.ToList();

            return lista;
        }

        public static List <Usuarios> GetListaUsuarioID(int usuarioID)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new UsuariosDB();

            lista = db.usuarios.Where(p => p.UsuarioID == usuarioID) .ToList();

            return lista;
        }

        public static List<Usuarios> GetListaUsuario(string Usuario)
        {
            List<Usuarios> lista = new List<Usuarios>();
            UsuariosDB db = new UsuariosDB();
            lista = db.usuarios.Where(p => p.Nombre == Usuario).ToList();
            return lista;
        }

        public static List<Usuarios> GetListaContrasena(string Clave)
        {
            List<Usuarios> lista = new List<Usuarios>();
            UsuariosDB db = new UsuariosDB();
            lista = db.usuarios.Where(p => p.Clave == Clave).ToList();
            return lista;
        }

    }
}
