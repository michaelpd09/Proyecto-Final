﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;

namespace DAL
{
   public class BancaDB : DbContext
    {
        public BancaDB() : base("name=ConStr")
        {

        }
        public virtual DbSet<Usuarios> usuarios { get; set; }
        public virtual DbSet<Tickets> tickets { get; set;  }
        public virtual DbSet<Loterias> loterias { get; set; }
        public virtual DbSet<Detalles> detalles { get; set; }
    }
}
