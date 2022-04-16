
namespace Proyecto.PRESENTACION
{
    partial class Administrador
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtvProducto = new System.Windows.Forms.DataGridView();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboAreolineas = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboCiudadDestino = new System.Windows.Forms.ComboBox();
            this.cboCiuadadOrigen = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVuelo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroVuelo = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelBtnGuardarPersonal = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnVolverPersonal = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProducto)).BeginInit();
            this.panelRegistro.SuspendLayout();
            this.panelBtnGuardarPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1580, 182);
            this.panel1.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(537, 149);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(631, 22);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtvProducto
            // 
            this.dtvProducto.AllowUserToAddRows = false;
            this.dtvProducto.AllowUserToDeleteRows = false;
            this.dtvProducto.AllowUserToResizeRows = false;
            this.dtvProducto.BackgroundColor = System.Drawing.Color.Gray;
            this.dtvProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.dtvProducto.Location = new System.Drawing.Point(67, 203);
            this.dtvProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtvProducto.Name = "dtvProducto";
            this.dtvProducto.RowHeadersVisible = false;
            this.dtvProducto.RowHeadersWidth = 51;
            this.dtvProducto.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.dtvProducto.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtvProducto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            this.dtvProducto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtvProducto.RowTemplate.Height = 29;
            this.dtvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvProducto.Size = new System.Drawing.Size(1482, 555);
            this.dtvProducto.TabIndex = 2;
            this.dtvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvProducto_CellClick);
            this.dtvProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvProducto_CellDoubleClick);
            // 
            // panelRegistro
            // 
            this.panelRegistro.AutoSize = true;
            this.panelRegistro.BackColor = System.Drawing.Color.DimGray;
            this.panelRegistro.Controls.Add(this.label9);
            this.panelRegistro.Controls.Add(this.dateTimePicker3);
            this.panelRegistro.Controls.Add(this.dateTimePicker2);
            this.panelRegistro.Controls.Add(this.cboEstado);
            this.panelRegistro.Controls.Add(this.cboAreolineas);
            this.panelRegistro.Controls.Add(this.dateTimePicker1);
            this.panelRegistro.Controls.Add(this.cboCiudadDestino);
            this.panelRegistro.Controls.Add(this.cboCiuadadOrigen);
            this.panelRegistro.Controls.Add(this.label8);
            this.panelRegistro.Controls.Add(this.lblVuelo);
            this.panelRegistro.Controls.Add(this.label6);
            this.panelRegistro.Controls.Add(this.txtNumeroVuelo);
            this.panelRegistro.Controls.Add(this.panel4);
            this.panelRegistro.Controls.Add(this.label5);
            this.panelRegistro.Controls.Add(this.btnVolverPersonal);
            this.panelRegistro.Controls.Add(this.panelBtnGuardarPersonal);
            this.panelRegistro.Controls.Add(this.lblSueldo);
            this.panelRegistro.Controls.Add(this.label4);
            this.panelRegistro.Controls.Add(this.label3);
            this.panelRegistro.Controls.Add(this.label2);
            this.panelRegistro.Controls.Add(this.label1);
            this.panelRegistro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelRegistro.Location = new System.Drawing.Point(92, 147);
            this.panelRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(1017, 682);
            this.panelRegistro.TabIndex = 3;
            this.panelRegistro.Visible = false;
            this.panelRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRegistro_Paint);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(381, 385);
            this.dateTimePicker3.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker3.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(156, 34);
            this.dateTimePicker3.TabIndex = 40;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(381, 331);
            this.dateTimePicker2.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(156, 34);
            this.dateTimePicker2.TabIndex = 39;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(383, 545);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(191, 36);
            this.cboEstado.TabIndex = 38;
            // 
            // cboAreolineas
            // 
            this.cboAreolineas.FormattingEnabled = true;
            this.cboAreolineas.Location = new System.Drawing.Point(383, 484);
            this.cboAreolineas.Name = "cboAreolineas";
            this.cboAreolineas.Size = new System.Drawing.Size(191, 36);
            this.cboAreolineas.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(381, 272);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(356, 34);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // cboCiudadDestino
            // 
            this.cboCiudadDestino.FormattingEnabled = true;
            this.cboCiudadDestino.Location = new System.Drawing.Point(381, 209);
            this.cboCiudadDestino.Name = "cboCiudadDestino";
            this.cboCiudadDestino.Size = new System.Drawing.Size(189, 36);
            this.cboCiudadDestino.TabIndex = 31;
            // 
            // cboCiuadadOrigen
            // 
            this.cboCiuadadOrigen.FormattingEnabled = true;
            this.cboCiuadadOrigen.Location = new System.Drawing.Point(381, 155);
            this.cboCiuadadOrigen.Name = "cboCiuadadOrigen";
            this.cboCiuadadOrigen.Size = new System.Drawing.Size(189, 36);
            this.cboCiuadadOrigen.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(180, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 28);
            this.label8.TabIndex = 29;
            this.label8.Text = "Estado de Vuelo :";
            // 
            // lblVuelo
            // 
            this.lblVuelo.AutoSize = true;
            this.lblVuelo.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelo.ForeColor = System.Drawing.Color.White;
            this.lblVuelo.Location = new System.Drawing.Point(437, 67);
            this.lblVuelo.Name = "lblVuelo";
            this.lblVuelo.Size = new System.Drawing.Size(286, 45);
            this.lblVuelo.TabIndex = 27;
            this.lblVuelo.Text = "Programar Vuelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(238, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "Areolinea :";
            // 
            // txtNumeroVuelo
            // 
            this.txtNumeroVuelo.BackColor = System.Drawing.Color.DimGray;
            this.txtNumeroVuelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroVuelo.ForeColor = System.Drawing.Color.White;
            this.txtNumeroVuelo.Location = new System.Drawing.Point(385, 434);
            this.txtNumeroVuelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroVuelo.MaxLength = 4;
            this.txtNumeroVuelo.Name = "txtNumeroVuelo";
            this.txtNumeroVuelo.Size = new System.Drawing.Size(189, 27);
            this.txtNumeroVuelo.TabIndex = 23;
            this.txtNumeroVuelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroVuelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroVuelo_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(383, 465);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 2);
            this.panel4.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(167, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Numero de Vuelo :";
            // 
            // panelBtnGuardarPersonal
            // 
            this.panelBtnGuardarPersonal.Controls.Add(this.btnGuardar);
            this.panelBtnGuardarPersonal.Controls.Add(this.btnEditar);
            this.panelBtnGuardarPersonal.Location = new System.Drawing.Point(478, 613);
            this.panelBtnGuardarPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBtnGuardarPersonal.Name = "panelBtnGuardarPersonal";
            this.panelBtnGuardarPersonal.Size = new System.Drawing.Size(283, 54);
            this.panelBtnGuardarPersonal.TabIndex = 15;
            this.panelBtnGuardarPersonal.Visible = false;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.ForeColor = System.Drawing.Color.White;
            this.lblSueldo.Location = new System.Drawing.Point(178, 385);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(164, 28);
            this.lblSueldo.TabIndex = 4;
            this.lblSueldo.Text = "Hora de Llegada :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(193, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora de Salida :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(160, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad de Destino :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad de Origen :";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(1486, 0);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 182);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1185, 144);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // btnVolverPersonal
            // 
            this.btnVolverPersonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolverPersonal.BackgroundImage")));
            this.btnVolverPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolverPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverPersonal.FlatAppearance.BorderSize = 0;
            this.btnVolverPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverPersonal.Location = new System.Drawing.Point(897, 56);
            this.btnVolverPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolverPersonal.Name = "btnVolverPersonal";
            this.btnVolverPersonal.Size = new System.Drawing.Size(66, 46);
            this.btnVolverPersonal.TabIndex = 16;
            this.btnVolverPersonal.UseVisualStyleBackColor = true;
            this.btnVolverPersonal.Click += new System.EventHandler(this.btnVolverPersonal_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(3, 2);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 39);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(124, 2);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 39);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(229)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(510, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(578, 80);
            this.label7.TabIndex = 4;
            this.label7.Text = "ADMINISTRADOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(598, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 23);
            this.label9.TabIndex = 42;
            this.label9.Text = "Ingrese un numero entre 1 - 9999\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightGray;
            this.label13.Location = new System.Drawing.Point(286, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(236, 46);
            this.label13.TabIndex = 43;
            this.label13.Text = "Ingrese el numero del Vuelo :\r\n\r\n";
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.dtvProducto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Administrador";
            this.Size = new System.Drawing.Size(1580, 856);
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProducto)).EndInit();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            this.panelBtnGuardarPersonal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtvProducto;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.FlowLayoutPanel panelBtnGuardarPersonal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnVolverPersonal;
        private System.Windows.Forms.Label lblVuelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeroVuelo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboAreolineas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboCiudadDestino;
        private System.Windows.Forms.ComboBox cboCiuadadOrigen;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
    }
}
