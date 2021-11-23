using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using TrenCR.Data;
using System.Threading.Tasks;

namespace TrenCR.Model
{
    public class Boletos
    {
        [Key]
        public int Id { get; set; }
        public string Horario { get; set; }
        public string Fecha { get; set; }
        public string Cantidad { get; set; }
        public string User { get; set; }
        public string Ruta { get; set; }
    }
}
