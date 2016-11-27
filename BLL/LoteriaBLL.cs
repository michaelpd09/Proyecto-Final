using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace BLL
{
   public  class LoteriaBLL
    {
        public static bool Guardar(Loteria loteria)
        {
            bool retorno = false;
            try
            {
                BancaDB db = new BancaDB();
                db.loteria.Add(loteria);
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
            var db = new BancaDB();
            Loteria loteria = Buscar(ID);
            if (loteria != null)
            {
                db.Entry(loteria).State = EntityState.Deleted;
                db.SaveChanges();
                retorno = true;
            }
            return retorno;
        }

        public static Loteria Buscar(int ID)
        {
            var db = new BancaDB();

            return db.loteria.Find(ID);

        }

        public static void Modificar(Loteria loteria)
        {
            var db = new BancaDB();
            db.Entry(loteria).State = EntityState.Modified;
            db.SaveChanges();

        }

        //public static List<Usuarios> GetLista()
        //{
        //    List<Usuarios> lista = new List<Usuarios>();

        //    var db = new BancaDB();

        //    lista = db.usuarios.ToList();

        //    return lista;
        //}

        //public static List<Usuarios> GetListaUsuarioID(int usuarioID)
        //{
        //    List<Usuarios> lista = new List<Usuarios>();

        //    var db = new BancaDB();

        //    lista = db.usuarios.Where(p => p.UsuarioID == usuarioID).ToList();

        //    return lista;
        //}

       
    }
}
