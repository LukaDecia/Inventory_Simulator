using Ejercicio316.Models;
using Ejercicio316.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio316.Controllers
{
     class ControllerDeposito
    {
        PantallaDeposito Pantalla;
        ParametrosSimulacion Parametros;
        Simulacion Simulacion;
        List<Simulacion> Simulaciones;
        ManejadorEventos ManejadorEventos;

        public ControllerDeposito(PantallaDeposito pantalla)
        {
            this.Pantalla = pantalla;
            Simulaciones = new List<Simulacion>();
        }

        public void Simular(ParametrosSimulacion parametros)
        {
            try
            {
                Parametros = parametros;
                Simulacion = new Simulacion(Parametros);
                ManejadorEventos = new ManejadorEventos(Simulacion, Parametros, this);
                Simulaciones.Add(Simulacion.Clonar());
                int contadorSimulaciones = 1;
                int contadorSimulacionesMostradas = 0;

                Boolean bandera = true;
                string cantPedidosPerdidos = "";
                
                while (contadorSimulaciones < Parametros.CantidadSimulaciones)
                {
                    DispararEvento();
                    if (contadorSimulaciones >= Parametros.SimularDesde && contadorSimulacionesMostradas < 400)
                    {
                        Simulaciones.Add(Simulacion.Clonar());
                        contadorSimulacionesMostradas++;
                    }
                    contadorSimulaciones++;

                    // Metrica
                    if (Simulacion.Reloj >= 12 && bandera == true)
                    {
                        cantPedidosPerdidos = Simulacion.PedidosPerdidosAC.ToString();
                        bandera = false;
                    }
                    if (contadorSimulaciones == Parametros.CantidadSimulaciones - 1 && bandera == true)
                    {
                        cantPedidosPerdidos = Simulacion.PedidosPerdidosAC.ToString();
                    }
                    


                }
                Simulaciones.Add(Simulacion.Clonar());
                Pantalla.MostrarSimulacion(Simulaciones);


                // Métrica
                if (Simulacion.nroSimulacion == 0)
                {
                    Simulacion.CapacidadDeposito1 = Parametros.Stock.ToString();
                    Simulacion.PedidosPerdidos1 = cantPedidosPerdidos;

                    string capacidadDeposito1 = "Capacidad Depósito : " + Simulacion.CapacidadDeposito1;
                    string pedidosPerdidos1 = "Pedidos Perdidos Por Año : " + Simulacion.PedidosPerdidos1;
                    string capacidadDeposito2 = "Capacidad Depósito : ";
                    string pedidosPerdidos2 = "Pedidos Perdidos Por Año : ";
                    string porcentajeVariacion = "Porcentaje Variación: ";
                    Pantalla.MostrarMetrica(pedidosPerdidos1, pedidosPerdidos2, capacidadDeposito1, capacidadDeposito2, porcentajeVariacion);

                    Simulacion.nroSimulacion++;
                }
                else
                 {
                    Simulacion.CapacidadDeposito2 = Simulacion.CapacidadDeposito1;
                    Simulacion.PedidosPerdidos2 = Simulacion.PedidosPerdidos1;
                    Simulacion.CapacidadDeposito1 = Parametros.Stock.ToString();
                    Simulacion.PedidosPerdidos1 = cantPedidosPerdidos;
                    string variacion = CalcularPorcentajeVariacion(Simulacion.PedidosPerdidos1, Simulacion.PedidosPerdidos2);
                    
                    string capacidadDeposito1 = "Capacidad Depósito : " + Simulacion.CapacidadDeposito1;
                    string pedidosPerdidos1 = "Pedidos Perdidos Por Año : " + Simulacion.PedidosPerdidos1;
                    string capacidadDeposito2 = "Capacidad Depósito : " + Simulacion.CapacidadDeposito2;
                    string pedidosPerdidos2 = "Pedidos Perdidos Por Año : " + Simulacion.PedidosPerdidos2;
                    string porcentajeVariacion = "Porcentaje Variación: " + variacion;
                    Pantalla.MostrarMetrica(pedidosPerdidos1, pedidosPerdidos2, capacidadDeposito1, capacidadDeposito2, porcentajeVariacion);

                    Simulacion.nroSimulacion++;
                }
                
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("Atención: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no controlado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CalcularPorcentajeVariacion(string perdidos1, string perdidos2)
        {
            int perdActual = int.Parse(perdidos1);
            int perdAnterior = int.Parse(perdidos2);

            if (perdAnterior != 0 && perdActual > perdAnterior)
            {
                return "aumentó un " + ((perdActual * 100 / perdAnterior) - 100).ToString() + "%";
            }
            else if (perdAnterior == 0 && perdActual > perdAnterior)
            {
                return "aumentó un " + (perdActual * 100).ToString() + "%";
            }
            else if (perdActual == 0 && perdAnterior > perdActual)
            {
                return "disminuyó un " + (perdAnterior * 100).ToString() + "%";
            }
            else if (perdActual < perdAnterior)
            {
                return "disminuyó un " + (perdActual * 100 / perdAnterior).ToString() + "%";
            }
            else
            {
                return "sin variación";
            }
        }

        private void DispararEvento()
        {
            List<double> tiempos = new List<double> { Simulacion.TiempoLlegada };
            Producto proxLlegadaProd;

            if (ManejadorEventos.LlegadaProductos.Count() != 0)
            {
                proxLlegadaProd = ManejadorEventos.LlegadaProductos.Peek();
                tiempos.Add(proxLlegadaProd.LlegadaProducto);

                tiempos.RemoveAll(x => x == 0);

                double proximoTiempo = tiempos.Min();

                // Llegada Pedido
                if (proximoTiempo == Simulacion.TiempoLlegada)
                {
                    Simulacion.CantidadPedidosLlegaron++;
                    ManejadorEventos.LlegadaPedido(Simulacion.CantidadPedidosLlegaron);
                }

                // Llegada del prox Producto
                else
                {
                    ManejadorEventos.LlegadaProducto(proxLlegadaProd.IdProducto, proxLlegadaProd.LlegadaProducto);
                }
            }
            else
            {
                ManejadorEventos.LlegadaPedido(Simulacion.CantidadPedidosLlegaron);
            }

            
        }

    }
}
