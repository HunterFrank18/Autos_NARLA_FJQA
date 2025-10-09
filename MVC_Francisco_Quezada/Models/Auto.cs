using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Francisco_Quezada.Models
{
    public class Auto
    {
        public int AutoID { get; set; }

        public int Codigo { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AñoFabricacion { get; set; }
        public int AñoProduccion { get; set; }
        public decimal Cilindraje { get; set; }
        public string TipoVehiculo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal DescuentoAplicado { get; set; }
        public int CategoriaID { get; set; }
        public int ProveedorID { get; set; }
        public int Stock { get; set; }
    }
}
