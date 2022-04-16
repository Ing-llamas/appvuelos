using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Proyecto.LOGICA;
using Proyecto.DATOS;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.PRESENTACION
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose(); 





        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {

                DataTable dt = new DataTable();
                LUsuarios parametros = new LUsuarios();
                DUsuarios funcion = new DUsuarios();
                int Contador = 0;

                parametros.Usuario = txtUsuario.Text;
                parametros.Password = txtPassword.Text;

                funcion.ValidarUsuarios(ref dt, parametros);
                Contador = dt.Rows.Count;

                if (Contador > 0)
                {
                    MessageBox.Show("Bienvenido al Sistema", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                    MenuPrincipal frm = new MenuPrincipal();
                    frm.ShowDialog();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



           
       

        }
    }
}
