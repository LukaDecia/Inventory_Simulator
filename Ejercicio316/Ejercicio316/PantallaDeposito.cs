using Ejercicio316.Controllers;
using Ejercicio316.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio316
{
    public partial class PantallaDeposito : Form
    {
        ControllerDeposito Controller;
        ParametrosSimulacion Parametros;

        public PantallaDeposito()
        {
            InitializeComponent();
            Parametros = new ParametrosSimulacion();
            IniciarParametros();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            Simular();
        }

        private void Simular()
        {
            dgvDeposito.Rows.Clear();
            Controller = new ControllerDeposito(this);
            SetearParametros();
            Controller.Simular(Parametros);
        }

        private void SetearParametros()
        {
            Parametros.CantidadSimulaciones = (int)CantSimulaciones.Value;
            Parametros.SimularDesde = (int)SimularDesde.Value;
            Parametros.Stock = (int)StockDeposito.Value;
            Parametros.PedidosPorMes = (int)PedidosPorMes.Value;
            Parametros.DemoraProducto = (double)DemoraProducto.Value;
        }

        private void IniciarParametros()
        {
            CantSimulaciones.Value = Parametros.CantidadSimulaciones;
            SimularDesde.Value = Parametros.SimularDesde;
            StockDeposito.Value = Parametros.Stock;
            PedidosPorMes.Value = Parametros.PedidosPorMes;
            DemoraProducto.Value = (decimal)Parametros.DemoraProducto;
        }

        public void MostrarSimulacion(List<Simulacion> simulaciones)
        {
            bsSimulacion.DataSource = simulaciones;
        }

        public void MostrarMetrica(string perdidos1, string perdidos2, string capacidad1, string capacidad2, string variacion)
        {
            lblPedidosPerdidos1.Text = perdidos1;
            lblPedidosPerdidos2.Text = perdidos2;
            lblCapacidadDeposito1.Text = capacidad1;
            lblCapacidadDeposito2.Text = capacidad2;
            lblPorcentajeVariacion.Text = variacion;
        }

        private void PantallaDeposito_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                Simular();
            }
        }

        private void PantallaDeposito_Load(object sender, EventArgs e)
        {
            dgvDeposito.Columns[0].DefaultCellStyle.BackColor = Color.Gainsboro;
            dgvDeposito.Columns[2].DefaultCellStyle.BackColor = Color.Gainsboro;
            dgvDeposito.Columns[4].DefaultCellStyle.BackColor = Color.Gainsboro;
            dgvDeposito.Columns[6].DefaultCellStyle.BackColor = Color.Gainsboro;
            dgvDeposito.Columns[7].DefaultCellStyle.BackColor = Color.Gainsboro;
        }

    }
}
