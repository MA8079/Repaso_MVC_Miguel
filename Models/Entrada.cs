using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repaso_MVC_Miguel.Models
{
    public class Entrada
    {
        private int idEntrada;
        private int cantidad;
        private string fecha;
        private string hora;
        private int idProducto;
        public int IdEntrada { get; set; }
        public int Cantidad { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int IdProducto { get; set; }
    }
}