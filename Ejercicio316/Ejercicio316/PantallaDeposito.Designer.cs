namespace Ejercicio316
{
    partial class PantallaDeposito
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDeposito));
            this.CantSimulaciones = new System.Windows.Forms.NumericUpDown();
            this.SimularDesde = new System.Windows.Forms.NumericUpDown();
            this.PedidosPorMes = new System.Windows.Forms.NumericUpDown();
            this.StockDeposito = new System.Windows.Forms.NumericUpDown();
            this.DemoraProducto = new System.Windows.Forms.NumericUpDown();
            this.dgvDeposito = new System.Windows.Forms.DataGridView();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemoraProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidosPerdidosAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LlegadaProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Espacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSimulacion = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblCapacidadDeposito1 = new System.Windows.Forms.Label();
            this.lblPedidosPerdidos1 = new System.Windows.Forms.Label();
            this.lblPedidosPerdidos2 = new System.Windows.Forms.Label();
            this.lblCapacidadDeposito2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblPorcentajeVariacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CantSimulaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimularDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosPorMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemoraProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSimulacion)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimular)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // CantSimulaciones
            // 
            this.CantSimulaciones.Location = new System.Drawing.Point(19, 22);
            this.CantSimulaciones.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.CantSimulaciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantSimulaciones.Name = "CantSimulaciones";
            this.CantSimulaciones.Size = new System.Drawing.Size(88, 21);
            this.CantSimulaciones.TabIndex = 6;
            this.CantSimulaciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SimularDesde
            // 
            this.SimularDesde.Location = new System.Drawing.Point(19, 63);
            this.SimularDesde.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.SimularDesde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SimularDesde.Name = "SimularDesde";
            this.SimularDesde.Size = new System.Drawing.Size(88, 21);
            this.SimularDesde.TabIndex = 9;
            this.SimularDesde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PedidosPorMes
            // 
            this.PedidosPorMes.Location = new System.Drawing.Point(48, 61);
            this.PedidosPorMes.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.PedidosPorMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PedidosPorMes.Name = "PedidosPorMes";
            this.PedidosPorMes.Size = new System.Drawing.Size(71, 21);
            this.PedidosPorMes.TabIndex = 7;
            this.PedidosPorMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StockDeposito
            // 
            this.StockDeposito.Location = new System.Drawing.Point(42, 61);
            this.StockDeposito.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.StockDeposito.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StockDeposito.Name = "StockDeposito";
            this.StockDeposito.Size = new System.Drawing.Size(79, 21);
            this.StockDeposito.TabIndex = 14;
            this.StockDeposito.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DemoraProducto
            // 
            this.DemoraProducto.DecimalPlaces = 3;
            this.DemoraProducto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.DemoraProducto.Location = new System.Drawing.Point(59, 61);
            this.DemoraProducto.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DemoraProducto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.DemoraProducto.Name = "DemoraProducto";
            this.DemoraProducto.Size = new System.Drawing.Size(64, 21);
            this.DemoraProducto.TabIndex = 15;
            this.DemoraProducto.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // dgvDeposito
            // 
            this.dgvDeposito.AllowUserToAddRows = false;
            this.dgvDeposito.AllowUserToDeleteRows = false;
            this.dgvDeposito.AutoGenerateColumns = false;
            this.dgvDeposito.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDeposito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeposito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Evento,
            this.Reloj,
            this.RND,
            this.Demora,
            this.TiempoLlegada,
            this.Stock,
            this.DemoraProductos,
            this.PedidosPerdidosAC,
            this.LlegadaProductos,
            this.Espacio});
            this.dgvDeposito.DataSource = this.bsSimulacion;
            this.dgvDeposito.Location = new System.Drawing.Point(33, 120);
            this.dgvDeposito.Name = "dgvDeposito";
            this.dgvDeposito.ReadOnly = true;
            this.dgvDeposito.Size = new System.Drawing.Size(1299, 314);
            this.dgvDeposito.TabIndex = 15;
            // 
            // Evento
            // 
            this.Evento.DataPropertyName = "Evento";
            this.Evento.Frozen = true;
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            this.Evento.ReadOnly = true;
            this.Evento.Width = 150;
            // 
            // Reloj
            // 
            this.Reloj.DataPropertyName = "Reloj";
            this.Reloj.Frozen = true;
            this.Reloj.HeaderText = "Reloj";
            this.Reloj.Name = "Reloj";
            this.Reloj.ReadOnly = true;
            // 
            // RND
            // 
            this.RND.DataPropertyName = "RndLlegada";
            this.RND.HeaderText = "RND";
            this.RND.Name = "RND";
            this.RND.ReadOnly = true;
            // 
            // Demora
            // 
            this.Demora.DataPropertyName = "DemoraLlegada";
            this.Demora.HeaderText = "Demora";
            this.Demora.Name = "Demora";
            this.Demora.ReadOnly = true;
            // 
            // TiempoLlegada
            // 
            this.TiempoLlegada.DataPropertyName = "TiempoLlegada";
            this.TiempoLlegada.HeaderText = "Próxima Llegada";
            this.TiempoLlegada.Name = "TiempoLlegada";
            this.TiempoLlegada.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock Depósito";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // DemoraProductos
            // 
            this.DemoraProductos.DataPropertyName = "DemoraProductos";
            this.DemoraProductos.HeaderText = "DemoraProductos";
            this.DemoraProductos.Name = "DemoraProductos";
            this.DemoraProductos.ReadOnly = true;
            this.DemoraProductos.Visible = false;
            // 
            // PedidosPerdidosAC
            // 
            this.PedidosPerdidosAC.DataPropertyName = "PedidosPerdidosAC";
            this.PedidosPerdidosAC.HeaderText = "AC Pedidos Perdidos";
            this.PedidosPerdidosAC.Name = "PedidosPerdidosAC";
            this.PedidosPerdidosAC.ReadOnly = true;
            // 
            // LlegadaProductos
            // 
            this.LlegadaProductos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LlegadaProductos.DataPropertyName = "LlegadaProductos";
            this.LlegadaProductos.HeaderText = "Tiempo Reposición de Productos";
            this.LlegadaProductos.Name = "LlegadaProductos";
            this.LlegadaProductos.ReadOnly = true;
            this.LlegadaProductos.Width = 129;
            // 
            // Espacio
            // 
            this.Espacio.HeaderText = "";
            this.Espacio.MinimumWidth = 2;
            this.Espacio.Name = "Espacio";
            this.Espacio.ReadOnly = true;
            this.Espacio.Width = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CantSimulaciones);
            this.groupBox2.Controls.Add(this.SimularDesde);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(144, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 91);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Simulaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Desde";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.StockDeposito);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(295, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 91);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposito";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Capacidad Depósito";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "(en unidades)";
            // 
            // btnSimular
            // 
            this.btnSimular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimular.Image = ((System.Drawing.Image)(resources.GetObject("btnSimular.Image")));
            this.btnSimular.Location = new System.Drawing.Point(36, 27);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(83, 82);
            this.btnSimular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSimular.TabIndex = 31;
            this.btnSimular.TabStop = false;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox3.Controls.Add(this.DemoraProducto);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(692, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 91);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Llegada Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Demora reposición en meses:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox4.Controls.Add(this.PedidosPorMes);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Location = new System.Drawing.Point(483, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 91);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Llegada Pedido";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Promedio Pedidos por mes:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Exponencial negativa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(205, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "MÉTRICAS";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Location = new System.Drawing.Point(36, 451);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(496, 51);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            // 
            // lblCapacidadDeposito1
            // 
            this.lblCapacidadDeposito1.AutoSize = true;
            this.lblCapacidadDeposito1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadDeposito1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCapacidadDeposito1.Location = new System.Drawing.Point(32, 505);
            this.lblCapacidadDeposito1.Name = "lblCapacidadDeposito1";
            this.lblCapacidadDeposito1.Size = new System.Drawing.Size(179, 19);
            this.lblCapacidadDeposito1.TabIndex = 37;
            this.lblCapacidadDeposito1.Text = "Capacidad Depósito :";
            this.lblCapacidadDeposito1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPedidosPerdidos1
            // 
            this.lblPedidosPerdidos1.AutoSize = true;
            this.lblPedidosPerdidos1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidosPerdidos1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPedidosPerdidos1.Location = new System.Drawing.Point(237, 505);
            this.lblPedidosPerdidos1.Name = "lblPedidosPerdidos1";
            this.lblPedidosPerdidos1.Size = new System.Drawing.Size(212, 19);
            this.lblPedidosPerdidos1.TabIndex = 38;
            this.lblPedidosPerdidos1.Text = "Pedidos Perdidos Por Año :";
            // 
            // lblPedidosPerdidos2
            // 
            this.lblPedidosPerdidos2.AutoSize = true;
            this.lblPedidosPerdidos2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidosPerdidos2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPedidosPerdidos2.Location = new System.Drawing.Point(237, 573);
            this.lblPedidosPerdidos2.Name = "lblPedidosPerdidos2";
            this.lblPedidosPerdidos2.Size = new System.Drawing.Size(212, 19);
            this.lblPedidosPerdidos2.TabIndex = 40;
            this.lblPedidosPerdidos2.Text = "Pedidos Perdidos Por Año :";
            // 
            // lblCapacidadDeposito2
            // 
            this.lblCapacidadDeposito2.AutoSize = true;
            this.lblCapacidadDeposito2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadDeposito2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCapacidadDeposito2.Location = new System.Drawing.Point(32, 573);
            this.lblCapacidadDeposito2.Name = "lblCapacidadDeposito2";
            this.lblCapacidadDeposito2.Size = new System.Drawing.Size(179, 19);
            this.lblCapacidadDeposito2.TabIndex = 39;
            this.lblCapacidadDeposito2.Text = "Capacidad Depósito :";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox7.Location = new System.Drawing.Point(36, 537);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(496, 24);
            this.groupBox7.TabIndex = 42;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Simulación Actual";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox8.Location = new System.Drawing.Point(36, 608);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(496, 24);
            this.groupBox8.TabIndex = 42;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Simulación Anterior";
            // 
            // lblPorcentajeVariacion
            // 
            this.lblPorcentajeVariacion.AutoSize = true;
            this.lblPorcentajeVariacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeVariacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPorcentajeVariacion.Location = new System.Drawing.Point(32, 649);
            this.lblPorcentajeVariacion.Name = "lblPorcentajeVariacion";
            this.lblPorcentajeVariacion.Size = new System.Drawing.Size(176, 19);
            this.lblPorcentajeVariacion.TabIndex = 43;
            this.lblPorcentajeVariacion.Text = "Porcentaje Variación:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(597, 451);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1123, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(996, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 102);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // PantallaDeposito
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1370, 700);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPorcentajeVariacion);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.lblPedidosPerdidos2);
            this.Controls.Add(this.lblCapacidadDeposito2);
            this.Controls.Add(this.lblPedidosPerdidos1);
            this.Controls.Add(this.lblCapacidadDeposito1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvDeposito);
            this.Name = "PantallaDeposito";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPOSITO";
            this.Load += new System.EventHandler(this.PantallaDeposito_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PantallaDeposito_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.CantSimulaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimularDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosPorMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemoraProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSimulacion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimular)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown CantSimulaciones;
        private System.Windows.Forms.NumericUpDown SimularDesde;
        private System.Windows.Forms.NumericUpDown PedidosPorMes;
        private System.Windows.Forms.NumericUpDown StockDeposito;
        private System.Windows.Forms.NumericUpDown DemoraProducto;
        private System.Windows.Forms.DataGridView dgvDeposito;
        private System.Windows.Forms.BindingSource bsSimulacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnSimular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demora;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemoraProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidosPerdidosAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn LlegadaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Espacio;
        private System.Windows.Forms.Label lblCapacidadDeposito1;
        private System.Windows.Forms.Label lblPedidosPerdidos1;
        private System.Windows.Forms.Label lblPedidosPerdidos2;
        private System.Windows.Forms.Label lblCapacidadDeposito2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblPorcentajeVariacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

