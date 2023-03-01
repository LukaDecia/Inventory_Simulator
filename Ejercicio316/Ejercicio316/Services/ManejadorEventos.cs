using Ejercicio316.Controllers;
using Ejercicio316.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio316.Services
{
     class ManejadorEventos
    {
        private static Random RandomLlegadas = new Random();
        private Simulacion Simulacion;
        private readonly ParametrosSimulacion Parametros;
        private ControllerDeposito Controller;
        public Queue<Producto> LlegadaProductos;
        public ManejadorEventos(Simulacion simulacion, ParametrosSimulacion parametros, ControllerDeposito controller)
        {
            Simulacion = simulacion;
            Parametros = parametros;
            Controller = controller;
            LlegadaProductos = new Queue<Producto>();
        }
        public void LlegadaPedido(int id)
        {
            Simulacion.Evento = Evento.LlegadaPedido + " (" + id.ToString() + ")";
            Simulacion.Reloj = Simulacion.TiempoLlegada;
            GenerarProximaLlegada();
            
            if (Simulacion.Stock == 0)
            {
                Simulacion.PedidosPerdidosAC++;
                return;
            }
            else
            {
                Simulacion.Stock--;
                GenerarLlegadaProducto(id);
            }

            GenerarCeldaTiempoReposicionProd();
        }

        public void LlegadaProducto(int id, double tiempoLlegadaProd)
        {
            LlegadaProductos.Dequeue();
            Simulacion.Evento = Evento.LlegadaProducto + " (" + id.ToString() + ")";
            Simulacion.Reloj = tiempoLlegadaProd;
            Simulacion.RndLlegada = 0;
            Simulacion.DemoraLlegada = 0;

            Simulacion.Stock++;

            GenerarCeldaTiempoReposicionProd();
        }

        private void GenerarLlegadaProducto(int id)
        {
            Producto producto = new Producto()
            {
                LlegadaProducto = Simulacion.Reloj + Parametros.DemoraProducto,
                IdProducto = id
            };

            LlegadaProductos.Enqueue(producto);

        }

        private void GenerarProximaLlegada()
        {
            double rndLlegada = RandomLlegadas.NextDouble();
            double demora = Generador.GenerarExponencial(Parametros.PedidosPorMes, rndLlegada);
            double tiempoLlegada = Simulacion.Reloj + demora;

            Simulacion.RndLlegada = rndLlegada;
            Simulacion.DemoraLlegada = demora;
            Simulacion.TiempoLlegada = tiempoLlegada;
        }

        private void GenerarCeldaTiempoReposicionProd()
        {
            string celdaProductos = "";
            foreach (Producto producto in LlegadaProductos)
            {
                celdaProductos += "(" + producto.IdProducto + ") " + producto.LlegadaProducto + " | ";
            }
            Simulacion.LlegadaProductos = celdaProductos;
        }
        
    }
}
