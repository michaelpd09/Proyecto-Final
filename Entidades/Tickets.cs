using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Tickets
    {
        [Key]

        public int IdTicket { get; set; }
        public int IdLoteria { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Comentario { get; set; }
        public bool Nulo { get; set; }


    }
}
