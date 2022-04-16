
namespace Proyecto.PRESENTACION
{
    partial class Vuelos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtvVuelos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Vuelo = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvVuelos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(229)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(641, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "VUELOS";
            // 
            // dtvVuelos
            // 
            this.dtvVuelos.AllowUserToAddRows = false;
            this.dtvVuelos.AllowUserToDeleteRows = false;
            this.dtvVuelos.AllowUserToResizeRows = false;
            this.dtvVuelos.BackgroundColor = System.Drawing.Color.Gray;
            this.dtvVuelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vuelo});
            this.dtvVuelos.Location = new System.Drawing.Point(118, 163);
            this.dtvVuelos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtvVuelos.Name = "dtvVuelos";
            this.dtvVuelos.RowHeadersVisible = false;
            this.dtvVuelos.RowHeadersWidth = 51;
            this.dtvVuelos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.dtvVuelos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtvVuelos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dtvVuelos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtvVuelos.RowTemplate.Height = 29;
            this.dtvVuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvVuelos.Size = new System.Drawing.Size(1520, 694);
            this.dtvVuelos.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 776);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1654, 167);
            this.panel1.TabIndex = 8;
            // 
            // lblHora
            // 
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(970, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(684, 167);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "----------------";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1654, 38);
            this.panel2.TabIndex = 9;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Proyecto.Properties.Resources.de_viaje__1_;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // Vuelo
            // 
            this.Vuelo.HeaderText = "";
            this.Vuelo.Image = global::Proyecto.Properties.Resources.de_viaje__1_;
            this.Vuelo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Vuelo.MinimumWidth = 6;
            this.Vuelo.Name = "Vuelo";
            this.Vuelo.Width = 125;
            // 
            // Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtvVuelos);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Vuelos";
            this.Size = new System.Drawing.Size(1654, 943);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvVuelos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtvVuelos;
        private System.Windows.Forms.DataGridViewImageColumn Vuelo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
