using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Detalles
    {
        [Key]

        public int IdDetalle { get; set; }
        public int IdTicket { get; set; }
        public int Jugada { get; set; }
        public int Precio { get; set; }
       
    }
}
