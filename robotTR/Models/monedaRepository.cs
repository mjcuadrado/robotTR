using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace robotTR.Models
{
    public class monedaRepository  : IMonedaRepository

    {
        private readonly robotDB  _contexto;

        public monedaRepository(robotDB  contexto)
        {
            _contexto = contexto;

            if (_contexto.Monedas.Count() == 0)
                Add(new moneda { nombre = "Prueba" });
        }


        public void Add(moneda item)
        {
            _contexto.Monedas.Add(item);
        }

        public IEnumerable<moneda> GetAll()
        {
            return _contexto.Monedas.ToList();
        }

        public moneda Find(long idmoneda)
        {
            return _contexto.Monedas.FirstOrDefault(t => t.idMoneda  == idmoneda );
        }

        public void Remove(long key)
        {
            var entity = _contexto.Monedas.First(t => t.idMoneda == key);
            _contexto.Monedas.Remove(entity);
            _contexto.SaveChanges();
        }

        public void Update(moneda item)
        {
            var entity = _contexto.Monedas.First(t => t.idMoneda == item.idMoneda);
            entity = item;
            _contexto.SaveChanges();
        }
    }
}