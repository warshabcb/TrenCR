using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrenCR.Model;
using TrenCR.Data;

namespace TrenCR.Controllers
{
    public class BoletosController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BoletosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Create(string Horario, string Fecha, string Cantidad, string User, String Ruta)
        {
            Boletos Boletos = new Boletos();
            Boletos.Horario = Horario;
            Boletos.Fecha = Fecha;
            Boletos.Cantidad = Cantidad;
            Boletos.Ruta = Ruta;
            Boletos.User = User;
            _context.Add(Boletos);
            _context.SaveChanges();
            return Boletos.Id.ToString();
        }
    }
}
