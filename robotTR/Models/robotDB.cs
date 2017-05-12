using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace robotTR.Models
{
    public class robotDB : DbContext 

	{
        public robotDB()
            : base()
        {
        

        }

        public DbSet<moneda> Monedas { get; set; }
        public DbSet<monedaValores> monedaValores { get; set; }


	}
}