using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace robotTR.Models
{
    interface IMonedaRepository
    {
        void Add(moneda item);
        IEnumerable<moneda> GetAll();
        moneda Find(long key);
        void Remove(long key);
        void Update(moneda  item);
    }
}
