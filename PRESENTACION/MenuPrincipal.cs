using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.PRESENTACION
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelBienvenida.Dock = DockStyle.Fill;
        }


        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            try
            {

                Vuelos control = new Vuelos();

                PanelPrincipal.Controls.Clear(); // limpiar el panel de los elementos que contenga
                control.Dock = DockStyle.Fill;
                PanelPrincipal.Controls.Add(control);

                btnProductos.BackColor = Color.DarkGray;
                btnVentas.BackColor = Color.Gray;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




           
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

            try
            {

                btnProductos.BackColor = Color.Gray;
                btnVentas.BackColor = Color.DarkGray;

                Administrador control = new Administrador();
                PanelPrincipal.Controls.Clear(); // limpiar el panel de los elementos que contenga
                control.Dock = DockStyle.Fill;
                PanelPrincipal.Controls.Add(control);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
    }
}
