using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio316.Models
{
    public class ParametrosSimulacion
    {
        public int CantidadSimulaciones { get; set; }
        public int SimularDesde { get; set; }
        public int Stock { get; set; }
        public int PedidosPorMes { get; set; }
        public double DemoraProducto { get; set; }

        public ParametrosSimulacion()
        {
            CantidadSimulaciones = 1000;
            SimularDesde = 1;
            Stock = 10;
            PedidosPorMes = 15;
            DemoraProducto = 0.5;
        }
    }
}
