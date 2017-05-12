using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace robotTR.Models
{
    public class moneda
    {
        public moneda()
        {

        }
   
        public long idMoneda { get; set; }
        public string  nombre {get; set;}
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }

        public ICollection<monedaValores> monedaValores { get; set; }

    }
}