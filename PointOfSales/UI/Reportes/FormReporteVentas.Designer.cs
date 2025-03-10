namespace PointOfSales.UI.Reportes
{
    partial class FormReporteVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteVentas));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFiltrar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExportarPDF = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReporteVentas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.dtpFechaFinal);
            this.panel1.Controls.Add(this.dtpFechaInicial);
            this.panel1.Controls.Add(this.cbCliente);
            this.panel1.Controls.Add(this.cbUsuario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.AllowAnimations = true;
            this.btnFiltrar.AllowMouseEffects = true;
            this.btnFiltrar.AllowToggling = false;
            this.btnFiltrar.AnimationSpeed = 200;
            this.btnFiltrar.AutoGenerateColors = false;
            this.btnFiltrar.AutoRoundBorders = false;
            this.btnFiltrar.AutoSizeLeftIcon = true;
            this.btnFiltrar.AutoSizeRightIcon = true;
            this.btnFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnFiltrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.BackgroundImage")));
            this.btnFiltrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiltrar.ButtonText = "Buscar";
            this.btnFiltrar.ButtonTextMarginLeft = 0;
            this.btnFiltrar.ColorContrastOnClick = 45;
            this.btnFiltrar.ColorContrastOnHover = 45;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnFiltrar.CustomizableEdges = borderEdges1;
            this.btnFiltrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFiltrar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFiltrar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnFiltrar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnFiltrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.IconLeft = null;
            this.btnFiltrar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFiltrar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFiltrar.IconMarginLeft = 11;
            this.btnFiltrar.IconPadding = 10;
            this.btnFiltrar.IconRight = null;
            this.btnFiltrar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFiltrar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFiltrar.IconSize = 25;
            this.btnFiltrar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnFiltrar.IdleBorderRadius = 0;
            this.btnFiltrar.IdleBorderThickness = 0;
            this.btnFiltrar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnFiltrar.IdleIconLeftImage = null;
            this.btnFiltrar.IdleIconRightImage = null;
            this.btnFiltrar.IndicateFocus = false;
            this.btnFiltrar.Location = new System.Drawing.Point(615, 28);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFiltrar.OnDisabledState.BorderRadius = 1;
            this.btnFiltrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiltrar.OnDisabledState.BorderThickness = 1;
            this.btnFiltrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFiltrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFiltrar.OnDisabledState.IconLeftImage = null;
            this.btnFiltrar.OnDisabledState.IconRightImage = null;
            this.btnFiltrar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnFiltrar.onHoverState.BorderRadius = 1;
            this.btnFiltrar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiltrar.onHoverState.BorderThickness = 1;
            this.btnFiltrar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnFiltrar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.onHoverState.IconLeftImage = null;
            this.btnFiltrar.onHoverState.IconRightImage = null;
            this.btnFiltrar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnFiltrar.OnIdleState.BorderRadius = 1;
            this.btnFiltrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiltrar.OnIdleState.BorderThickness = 1;
            this.btnFiltrar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnFiltrar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.OnIdleState.IconLeftImage = null;
            this.btnFiltrar.OnIdleState.IconRightImage = null;
            this.btnFiltrar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFiltrar.OnPressedState.BorderRadius = 1;
            this.btnFiltrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiltrar.OnPressedState.BorderThickness = 1;
            this.btnFiltrar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFiltrar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.OnPressedState.IconLeftImage = null;
            this.btnFiltrar.OnPressedState.IconRightImage = null;
            this.btnFiltrar.Size = new System.Drawing.Size(150, 39);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFiltrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFiltrar.TextMarginLeft = 0;
            this.btnFiltrar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFiltrar.UseDefaultRadiusAndThickness = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(15, 71);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 7;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(15, 28);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicial.TabIndex = 6;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(417, 28);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(149, 21);
            this.cbCliente.TabIndex = 5;
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(246, 27);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(150, 21);
            this.cbUsuario.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(413, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(243, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicial:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgvReporteVentas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 350);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExportarPDF);
            this.panel3.Controls.Add(this.lblTotalVentas);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 100);
            this.panel3.TabIndex = 1;
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.AllowAnimations = true;
            this.btnExportarPDF.AllowMouseEffects = true;
            this.btnExportarPDF.AllowToggling = false;
            this.btnExportarPDF.AnimationSpeed = 200;
            this.btnExportarPDF.AutoGenerateColors = false;
            this.btnExportarPDF.AutoRoundBorders = false;
            this.btnExportarPDF.AutoSizeLeftIcon = true;
            this.btnExportarPDF.AutoSizeRightIcon = true;
            this.btnExportarPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarPDF.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnExportarPDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportarPDF.BackgroundImage")));
            this.btnExportarPDF.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarPDF.ButtonText = "Exportar PDF";
            this.btnExportarPDF.ButtonTextMarginLeft = 0;
            this.btnExportarPDF.ColorContrastOnClick = 45;
            this.btnExportarPDF.ColorContrastOnHover = 45;
            this.btnExportarPDF.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnExportarPDF.CustomizableEdges = borderEdges2;
            this.btnExportarPDF.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportarPDF.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportarPDF.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnExportarPDF.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnExportarPDF.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExportarPDF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportarPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportarPDF.IconLeft = null;
            this.btnExportarPDF.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarPDF.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportarPDF.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExportarPDF.IconMarginLeft = 11;
            this.btnExportarPDF.IconPadding = 10;
            this.btnExportarPDF.IconRight = null;
            this.btnExportarPDF.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarPDF.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportarPDF.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExportarPDF.IconSize = 25;
            this.btnExportarPDF.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnExportarPDF.IdleBorderRadius = 0;
            this.btnExportarPDF.IdleBorderThickness = 0;
            this.btnExportarPDF.IdleFillColor = System.Drawing.Color.Empty;
            this.btnExportarPDF.IdleIconLeftImage = null;
            this.btnExportarPDF.IdleIconRightImage = null;
            this.btnExportarPDF.IndicateFocus = false;
            this.btnExportarPDF.Location = new System.Drawing.Point(134, 13);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportarPDF.OnDisabledState.BorderRadius = 1;
            this.btnExportarPDF.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarPDF.OnDisabledState.BorderThickness = 1;
            this.btnExportarPDF.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportarPDF.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportarPDF.OnDisabledState.IconLeftImage = null;
            this.btnExportarPDF.OnDisabledState.IconRightImage = null;
            this.btnExportarPDF.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnExportarPDF.onHoverState.BorderRadius = 1;
            this.btnExportarPDF.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarPDF.onHoverState.BorderThickness = 1;
            this.btnExportarPDF.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnExportarPDF.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExportarPDF.onHoverState.IconLeftImage = null;
            this.btnExportarPDF.onHoverState.IconRightImage = null;
            this.btnExportarPDF.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnExportarPDF.OnIdleState.BorderRadius = 1;
            this.btnExportarPDF.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarPDF.OnIdleState.BorderThickness = 1;
            this.btnExportarPDF.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnExportarPDF.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExportarPDF.OnIdleState.IconLeftImage = null;
            this.btnExportarPDF.OnIdleState.IconRightImage = null;
            this.btnExportarPDF.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExportarPDF.OnPressedState.BorderRadius = 1;
            this.btnExportarPDF.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarPDF.OnPressedState.BorderThickness = 1;
            this.btnExportarPDF.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExportarPDF.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExportarPDF.OnPressedState.IconLeftImage = null;
            this.btnExportarPDF.OnPressedState.IconRightImage = null;
            this.btnExportarPDF.Size = new System.Drawing.Size(150, 39);
            this.btnExportarPDF.TabIndex = 9;
            this.btnExportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportarPDF.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExportarPDF.TextMarginLeft = 0;
            this.btnExportarPDF.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExportarPDF.UseDefaultRadiusAndThickness = true;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalVentas.Location = new System.Drawing.Point(12, 29);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(43, 16);
            this.lblTotalVentas.TabIndex = 1;
            this.lblTotalVentas.Text = "$0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total de ventas:";
            // 
            // dgvReporteVentas
            // 
            this.dgvReporteVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.dgvReporteVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteVentas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporteVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporteVentas.Location = new System.Drawing.Point(0, 0);
            this.dgvReporteVentas.Name = "dgvReporteVentas";
            this.dgvReporteVentas.RowHeadersVisible = false;
            this.dgvReporteVentas.Size = new System.Drawing.Size(831, 350);
            this.dgvReporteVentas.TabIndex = 0;
            // 
            // FormReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbUsuario;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFiltrar;
        private System.Windows.Forms.DataGridView dgvReporteVentas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalVentas;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExportarPDF;
    }
}