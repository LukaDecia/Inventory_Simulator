using Ejercicio316.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio316.Models
{
    public class Simulacion
    {
        #region Campos
        public string Evento { get; set; }
        public double Reloj { get; set; }
        public double RndLlegada { get; set; }
        public double DemoraLlegada { get; set; }
        public double TiempoLlegada { get; set; }
        public int Stock { get; set; }
        public int PedidosPerdidosAC { get; set; }
        public string LlegadaProductos { get; set; }
        public int CantidadPedidosLlegaron { get; set; }

        private readonly ParametrosSimulacion Parametros;

        // Campos Métrica

        public static int nroSimulacion = 0;
        public static string CapacidadDeposito1 { get; set; }
        public static string CapacidadDeposito2 { get; set; }
        public static string PedidosPerdidos1 { get; set; }
        public static string PedidosPerdidos2 { get; set; }

        #endregion
        public Simulacion(ParametrosSimulacion parametros)
        {
            Parametros = parametros;
            IniciarSimulacion();
        }
        public Simulacion()
        {

        }

        private void IniciarSimulacion()
        {
            Evento = Models.Evento.Inicio.ToString();
            Reloj = 0;
            RndLlegada = new Random().NextDouble();
            DemoraLlegada = Generador.GenerarExponencial(Parametros.PedidosPorMes, RndLlegada);
            TiempoLlegada = Reloj + DemoraLlegada;
            Stock = Parametros.Stock;
            PedidosPerdidosAC = 0;
            LlegadaProductos = "";
        }

        public Simulacion Clonar()
        {
            return (Simulacion)this.MemberwiseClone();
        }
    }

    public enum Evento
    {
        Inicio,
        LlegadaPedido,
        LlegadaProducto,
    }
}
