using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.BE
{
    public class Producto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        public int Stock { get; set; }

        public decimal Precio { get; set; }

        public int Vendidos { get; set; }
    }
}
