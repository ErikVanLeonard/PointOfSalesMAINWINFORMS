﻿namespace PointOfSales
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corteDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corteDeCajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.corteDeCajaYCerrarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControlVentas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvProductosVenta = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnVerificador = new System.Windows.Forms.Button();
            this.btnBorrarArt = new System.Windows.Forms.Button();
            this.btnSalidas = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnProductoComun = new System.Windows.Forms.Button();
            this.bntInsertarVarios = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCantidadArticulos = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAsignarCliente = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPendiente = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCobrarVenta = new System.Windows.Forms.Button();
            this.btnImprimirTicket = new System.Windows.Forms.Button();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.tabInventario = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelReloj = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControlVentas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVenta)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.corteDeCajaToolStripMenuItem,
            this.facturaciónToolStripMenuItem,
            this.abrirTurnoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Sistema";
            this.archivoToolStripMenuItem.Visible = false;
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.configuraciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem});
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Visible = false;
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // corteDeCajaToolStripMenuItem
            // 
            this.corteDeCajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corteDeCajaToolStripMenuItem1,
            this.corteDeCajaYCerrarTurnoToolStripMenuItem});
            this.corteDeCajaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.corteDeCajaToolStripMenuItem.Name = "corteDeCajaToolStripMenuItem";
            this.corteDeCajaToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.corteDeCajaToolStripMenuItem.Text = "Operaciones Caja";
            this.corteDeCajaToolStripMenuItem.Visible = false;
            // 
            // corteDeCajaToolStripMenuItem1
            // 
            this.corteDeCajaToolStripMenuItem1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.corteDeCajaToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.corteDeCajaToolStripMenuItem1.Name = "corteDeCajaToolStripMenuItem1";
            this.corteDeCajaToolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.corteDeCajaToolStripMenuItem1.Text = "Corte de caja";
            // 
            // corteDeCajaYCerrarTurnoToolStripMenuItem
            // 
            this.corteDeCajaYCerrarTurnoToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.corteDeCajaYCerrarTurnoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.corteDeCajaYCerrarTurnoToolStripMenuItem.Name = "corteDeCajaYCerrarTurnoToolStripMenuItem";
            this.corteDeCajaYCerrarTurnoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.corteDeCajaYCerrarTurnoToolStripMenuItem.Text = "Corte de caja y cerrar turno";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            this.facturaciónToolStripMenuItem.Visible = false;
            // 
            // abrirTurnoToolStripMenuItem
            // 
            this.abrirTurnoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.abrirTurnoToolStripMenuItem.Name = "abrirTurnoToolStripMenuItem";
            this.abrirTurnoToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.abrirTurnoToolStripMenuItem.Text = "Abrir Turno";
            this.abrirTurnoToolStripMenuItem.Click += new System.EventHandler(this.abrirTurnoToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabVentas);
            this.tabControl1.Controls.Add(this.tabClientes);
            this.tabControl1.Controls.Add(this.tabProductos);
            this.tabControl1.Controls.Add(this.tabInventario);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(68, 28);
            this.tabControl1.Location = new System.Drawing.Point(0, 59);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 392);
            this.tabControl1.TabIndex = 1;
            // 
            // tabVentas
            // 
            this.tabVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.tabVentas.Controls.Add(this.panel3);
            this.tabVentas.Location = new System.Drawing.Point(4, 32);
            this.tabVentas.Margin = new System.Windows.Forms.Padding(0);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Size = new System.Drawing.Size(1020, 356);
            this.tabVentas.TabIndex = 0;
            this.tabVentas.Text = "VENTAS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.panel3.Controls.Add(this.tabControlVentas);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 356);
            this.panel3.TabIndex = 1;
            // 
            // tabControlVentas
            // 
            this.tabControlVentas.Controls.Add(this.tabPage1);
            this.tabControlVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlVentas.Location = new System.Drawing.Point(0, 69);
            this.tabControlVentas.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlVentas.Name = "tabControlVentas";
            this.tabControlVentas.SelectedIndex = 0;
            this.tabControlVentas.Size = new System.Drawing.Size(1020, 207);
            this.tabControlVentas.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.tabPage1.Controls.Add(this.dgvProductosVenta);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1012, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ticket 1";
            // 
            // dgvProductosVenta
            // 
            this.dgvProductosVenta.AllowUserToAddRows = false;
            this.dgvProductosVenta.AllowUserToDeleteRows = false;
            this.dgvProductosVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.dgvProductosVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductosVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Importe,
            this.Existencia});
            this.dgvProductosVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductosVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductosVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.dgvProductosVenta.Location = new System.Drawing.Point(0, 0);
            this.dgvProductosVenta.Margin = new System.Windows.Forms.Padding(0);
            this.dgvProductosVenta.Name = "dgvProductosVenta";
            this.dgvProductosVenta.ReadOnly = true;
            this.dgvProductosVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvProductosVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductosVenta.RowHeadersVisible = false;
            this.dgvProductosVenta.Size = new System.Drawing.Size(1012, 180);
            this.dgvProductosVenta.TabIndex = 0;
            this.dgvProductosVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosVenta_CellContentClick);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Codigo de barras";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Descripción producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Venta";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.panel5.Controls.Add(this.btnVerificador);
            this.panel5.Controls.Add(this.btnBorrarArt);
            this.panel5.Controls.Add(this.btnSalidas);
            this.panel5.Controls.Add(this.btnEntradas);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.btnBuscar);
            this.panel5.Controls.Add(this.btnProductoComun);
            this.panel5.Controls.Add(this.bntInsertarVarios);
            this.panel5.Controls.Add(this.btnAgregarProducto);
            this.panel5.Controls.Add(this.txtBuscarProducto);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1020, 69);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnVerificador
            // 
            this.btnVerificador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnVerificador.FlatAppearance.BorderSize = 0;
            this.btnVerificador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVerificador.Location = new System.Drawing.Point(911, 32);
            this.btnVerificador.Name = "btnVerificador";
            this.btnVerificador.Size = new System.Drawing.Size(96, 23);
            this.btnVerificador.TabIndex = 10;
            this.btnVerificador.Text = "F9 | Verificador";
            this.btnVerificador.UseVisualStyleBackColor = false;
            // 
            // btnBorrarArt
            // 
            this.btnBorrarArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnBorrarArt.FlatAppearance.BorderSize = 0;
            this.btnBorrarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarArt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBorrarArt.Location = new System.Drawing.Point(786, 32);
            this.btnBorrarArt.Name = "btnBorrarArt";
            this.btnBorrarArt.Size = new System.Drawing.Size(119, 23);
            this.btnBorrarArt.TabIndex = 9;
            this.btnBorrarArt.Text = "SUPR | Borrar Art.";
            this.btnBorrarArt.UseVisualStyleBackColor = false;
            // 
            // btnSalidas
            // 
            this.btnSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnSalidas.FlatAppearance.BorderSize = 0;
            this.btnSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalidas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalidas.Location = new System.Drawing.Point(661, 32);
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.Size = new System.Drawing.Size(119, 23);
            this.btnSalidas.TabIndex = 8;
            this.btnSalidas.Text = "F8 | Salidas";
            this.btnSalidas.UseVisualStyleBackColor = false;
            // 
            // btnEntradas
            // 
            this.btnEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnEntradas.FlatAppearance.BorderSize = 0;
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEntradas.Location = new System.Drawing.Point(536, 32);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(119, 23);
            this.btnEntradas.TabIndex = 7;
            this.btnEntradas.Text = "F7 | Entradas";
            this.btnEntradas.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(411, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "F11 | Mayoreo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(286, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "F10 | Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnProductoComun
            // 
            this.btnProductoComun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnProductoComun.FlatAppearance.BorderSize = 0;
            this.btnProductoComun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoComun.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductoComun.Location = new System.Drawing.Point(133, 32);
            this.btnProductoComun.Name = "btnProductoComun";
            this.btnProductoComun.Size = new System.Drawing.Size(147, 23);
            this.btnProductoComun.TabIndex = 4;
            this.btnProductoComun.Text = "CTRL + P | Prod. Comun";
            this.btnProductoComun.UseVisualStyleBackColor = false;
            // 
            // bntInsertarVarios
            // 
            this.bntInsertarVarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.bntInsertarVarios.FlatAppearance.BorderSize = 0;
            this.bntInsertarVarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntInsertarVarios.ForeColor = System.Drawing.SystemColors.Control;
            this.bntInsertarVarios.Location = new System.Drawing.Point(10, 32);
            this.bntInsertarVarios.Name = "bntInsertarVarios";
            this.bntInsertarVarios.Size = new System.Drawing.Size(119, 23);
            this.bntInsertarVarios.TabIndex = 3;
            this.bntInsertarVarios.Text = "INS | Varios";
            this.bntInsertarVarios.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarProducto.Location = new System.Drawing.Point(615, 5);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(179, 23);
            this.btnAgregarProducto.TabIndex = 2;
            this.btnAgregarProducto.Text = "ENT | Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(133, 6);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(476, 20);
            this.txtBuscarProducto.TabIndex = 1;
            this.txtBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarProducto_KeyPress_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(7, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "Codigo del producto:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.panel4.Controls.Add(this.lblCantidadArticulos);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnAsignarCliente);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lblTotalPago);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btnCancelar);
            this.panel4.Controls.Add(this.btnPendiente);
            this.panel4.Controls.Add(this.btnCambiar);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.btnCobrarVenta);
            this.panel4.Controls.Add(this.btnImprimirTicket);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 276);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1020, 80);
            this.panel4.TabIndex = 2;
            // 
            // lblCantidadArticulos
            // 
            this.lblCantidadArticulos.AutoSize = true;
            this.lblCantidadArticulos.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadArticulos.ForeColor = System.Drawing.Color.White;
            this.lblCantidadArticulos.Location = new System.Drawing.Point(430, 50);
            this.lblCantidadArticulos.Name = "lblCantidadArticulos";
            this.lblCantidadArticulos.Size = new System.Drawing.Size(21, 23);
            this.lblCantidadArticulos.TabIndex = 15;
            this.lblCantidadArticulos.Text = "0";
            this.lblCantidadArticulos.Click += new System.EventHandler(this.lblCantidadArticulos_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(261, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Articulos en la venta actual:";
            // 
            // btnAsignarCliente
            // 
            this.btnAsignarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnAsignarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAsignarCliente.FlatAppearance.BorderSize = 0;
            this.btnAsignarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsignarCliente.Location = new System.Drawing.Point(286, 4);
            this.btnAsignarCliente.Name = "btnAsignarCliente";
            this.btnAsignarCliente.Size = new System.Drawing.Size(115, 23);
            this.btnAsignarCliente.TabIndex = 13;
            this.btnAsignarCliente.Text = "Asignar cliente";
            this.btnAsignarCliente.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(145, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "$0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(66, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "$0.00";
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPago.ForeColor = System.Drawing.Color.White;
            this.lblTotalPago.Location = new System.Drawing.Point(5, 55);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(38, 15);
            this.lblTotalPago.TabIndex = 10;
            this.lblTotalPago.Text = "$0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(145, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cambio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(66, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pago con:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(165, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar/Eliminar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnPendiente
            // 
            this.btnPendiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnPendiente.FlatAppearance.BorderSize = 0;
            this.btnPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendiente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPendiente.Location = new System.Drawing.Point(84, 4);
            this.btnPendiente.Name = "btnPendiente";
            this.btnPendiente.Size = new System.Drawing.Size(75, 23);
            this.btnPendiente.TabIndex = 5;
            this.btnPendiente.Text = "Pendiente";
            this.btnPendiente.UseVisualStyleBackColor = false;
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCambiar.Location = new System.Drawing.Point(3, 4);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 4;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(685, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(680, 25);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(134, 52);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "$0.00";
            // 
            // btnCobrarVenta
            // 
            this.btnCobrarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrarVenta.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCobrarVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCobrarVenta.FlatAppearance.BorderSize = 0;
            this.btnCobrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrarVenta.Location = new System.Drawing.Point(865, 4);
            this.btnCobrarVenta.Name = "btnCobrarVenta";
            this.btnCobrarVenta.Size = new System.Drawing.Size(151, 40);
            this.btnCobrarVenta.TabIndex = 1;
            this.btnCobrarVenta.Text = "Cobrar e imprimir";
            this.btnCobrarVenta.UseVisualStyleBackColor = false;
            this.btnCobrarVenta.Click += new System.EventHandler(this.btnCobrarVenta_Click);
            // 
            // btnImprimirTicket
            // 
            this.btnImprimirTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnImprimirTicket.FlatAppearance.BorderSize = 0;
            this.btnImprimirTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirTicket.ForeColor = System.Drawing.Color.White;
            this.btnImprimirTicket.Location = new System.Drawing.Point(865, 50);
            this.btnImprimirTicket.Name = "btnImprimirTicket";
            this.btnImprimirTicket.Size = new System.Drawing.Size(152, 27);
            this.btnImprimirTicket.TabIndex = 0;
            this.btnImprimirTicket.Text = "Imprimir ultima venta";
            this.btnImprimirTicket.UseVisualStyleBackColor = false;
            this.btnImprimirTicket.Click += new System.EventHandler(this.btnImprimirTicket_Click);
            // 
            // tabClientes
            // 
            this.tabClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.tabClientes.Controls.Add(this.label2);
            this.tabClientes.Location = new System.Drawing.Point(4, 32);
            this.tabClientes.Margin = new System.Windows.Forms.Padding(0);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Size = new System.Drawing.Size(1020, 356);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // tabProductos
            // 
            this.tabProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.tabProductos.Location = new System.Drawing.Point(4, 32);
            this.tabProductos.Margin = new System.Windows.Forms.Padding(0);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Size = new System.Drawing.Size(1020, 356);
            this.tabProductos.TabIndex = 2;
            this.tabProductos.Text = "PRODUCTOS";
            // 
            // tabInventario
            // 
            this.tabInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.tabInventario.Location = new System.Drawing.Point(4, 32);
            this.tabInventario.Margin = new System.Windows.Forms.Padding(0);
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.Size = new System.Drawing.Size(1020, 356);
            this.tabInventario.TabIndex = 3;
            this.tabInventario.Text = "INVENTARIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 479);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelReloj});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1031, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelReloj
            // 
            this.labelReloj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.labelReloj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReloj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelReloj.Name = "labelReloj";
            this.labelReloj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelReloj.Size = new System.Drawing.Size(1016, 17);
            this.labelReloj.Spring = true;
            this.labelReloj.Text = "00:00:00 TT";
            this.labelReloj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnVentas);
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Controls.Add(this.btnProductos);
            this.panel2.Controls.Add(this.btnInventario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 53);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(723, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "VERSIÓN GRATUITA | https://landskape.com.mx";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(845, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Te atiende: CAJERO DEMO";
            this.toolTip1.SetToolTip(this.label1, "CAJERO EN TURNO");
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVentas.Location = new System.Drawing.Point(7, 3);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(104, 48);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "F1 | VENTAS";
            this.btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClientes.Location = new System.Drawing.Point(117, 3);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(104, 48);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "F2 | CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductos.Location = new System.Drawing.Point(227, 3);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(104, 48);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = "F3 | PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInventario.Location = new System.Drawing.Point(337, 3);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(104, 48);
            this.btnInventario.TabIndex = 7;
            this.btnInventario.Text = "F4 | INVENTARIO";
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "LANSKAPE\\ SOLUTIONS\\.\\ -----\\ VERSION\\ GRATUITA\\ -----\\ DESCARGA\\ EN\\ LANSKAPE-CO" +
    "M\\ \\|\\ PROHIBIDA\\ SU\\ VENTA\\ 2025";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.White;
            this.cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(12, 27);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(905, 105);
            this.cuiLabel1.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1031, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cuiLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1047, 542);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUNTO DE VENTA | landskape.com.mx";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControlVentas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVenta)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.TabPage tabInventario;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corteDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem corteDeCajaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem corteDeCajaYCerrarTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirTurnoToolStripMenuItem;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnImprimirTicket;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCobrarVenta;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPendiente;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button bntInsertarVarios;
        private System.Windows.Forms.TabControl tabControlVentas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnProductoComun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalidas;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button btnBorrarArt;
        private System.Windows.Forms.Button btnVerificador;
        private System.Windows.Forms.Label lblCantidadArticulos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAsignarCliente;
        private System.Windows.Forms.DataGridView dgvProductosVenta;
        private System.Windows.Forms.ToolStripStatusLabel labelReloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
    }
}

