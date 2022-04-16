using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Data.SqlClient;
using Proyecto.LOGICA;
using Proyecto.DATOS;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.PRESENTACION
{
    public partial class Vuelos : UserControl
    {
        public Vuelos()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }


        private void mostrarDatos()
        {

            DataTable dt = new DataTable();
            Dvuelos funcion = new Dvuelos();
            funcion.MostarVuelos(ref dt);
            Bases.DiseñoDtv(ref dtvVuelos);
            dtvVuelos.DataSource = dt;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("hh:mm:ss tt");
            lblHora.Text = datetime.ToString();
            
            
        }
    }
}
