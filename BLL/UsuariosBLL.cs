using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

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
                db.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }
        
        public static void Eliminar(int ID)
        {
            var db = new UsuariosDB();
            Usuarios usuario = Buscar(ID);
            db.Usuario.Remove(usuario);
            db.SaveChanges(); 
        }

        public static Usuarios Buscar(int ID)
        {
            var db = new UsuariosDB();

            return db.Usuario.Find(ID);
        }

        public static List <Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new UsuariosDB();

            lista = db.Usuario.ToList();

            return lista;
        }

        public static List <Usuarios> GetLista(int usuarioID)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new UsuariosDB();

            lista = db.Usuario.Where(p => p.UsuarioID == usuarioID).ToList();

            return lista;
        }

    }
}
