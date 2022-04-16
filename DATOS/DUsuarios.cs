using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Proyecto.LOGICA;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Proyecto.DATOS
{
    public class DUsuarios
    {

        public void ValidarUsuarios(ref DataTable dt,LUsuarios parametros )
        {

            try
            {
                CONEXIONMAESTRA.abrir();

                SqlDataAdapter da = new SqlDataAdapter("ValidarUsuario", CONEXIONMAESTRA.conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@usuario", parametros.Usuario);
                da.SelectCommand.Parameters.AddWithValue("@password", parametros.Password);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Informacion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }

    }
}
