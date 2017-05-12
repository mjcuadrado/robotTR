using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using robotTR.Models;

namespace robotTR.Controllers
{

    public class MonedaController : Controller
    {
        public readonly IMonedaRepository _moneda;
        public MonedaController(IMonedaRepository monedaRepositorio)
        {
            _moneda = monedaRepositorio;
        }

        [HttpGet]
        public IEnumerable<moneda> GetAll()
        {
            return _moneda.GetAll();
        }

        [HttpGet("{id}", Name = "GetMoneda")]
        public IActionResult GetById(long id)
        {
            var item = _moneda.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
