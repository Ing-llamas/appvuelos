using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Proyecto.LOGICA;
using System.Windows.Forms;

using System.Threading.Tasks;

namespace Proyecto.DATOS
{
    public class Dvuelos
    {
        public bool InsertarVuelos(LVuelos parametro) {
            try
            {
                CONEXIONMAESTRA.abrir();
                // para insertar editar o eliminar de trabaja sqlCommand
                SqlCommand cmd = new SqlCommand("insertarVuelos", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_CO", parametro.Id_CO);
                cmd.Parameters.AddWithValue("@Id_CD", parametro.Id_CD);
                cmd.Parameters.AddWithValue("@Fecha", parametro.Fecha);
                cmd.Parameters.AddWithValue("@HoraSalida", parametro.HoraSalida);
                cmd.Parameters.AddWithValue("@HoraLlegada", parametro.HoraLlegada);
                cmd.Parameters.AddWithValue("@NumeroDeVuelo", parametro.NumedoDeVuelo);
                cmd.Parameters.AddWithValue("@Id_Aerolinea", parametro.Id_Aerolinea);
                cmd.Parameters.AddWithValue("@Id_Estado", parametro.Id_Estado);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;

            }

            finally {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public bool EditarVuelos(LVuelos parametro)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                // para insertar editar o eliminar de trabaja sqlCommand
                SqlCommand cmd = new SqlCommand("editarVuelos", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Vuelo", parametro.Id_Vuelos);
                cmd.Parameters.AddWithValue("@Id_CO", parametro.Id_CO);
                cmd.Parameters.AddWithValue("@Id_CD", parametro.Id_CD);
                cmd.Parameters.AddWithValue("@Fecha", parametro.Fecha);
                cmd.Parameters.AddWithValue("@HoraSalida", parametro.HoraSalida);
                cmd.Parameters.AddWithValue("@HoraLlegada", parametro.HoraLlegada);
                cmd.Parameters.AddWithValue("@NumeroDeVuelo", parametro.NumedoDeVuelo);
                cmd.Parameters.AddWithValue("@Id_Aerolinea", parametro.Id_Aerolinea);
                cmd.Parameters.AddWithValue("@Id_Estado", parametro.Id_Estado);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public bool EliminarVuelos(LVuelos parametro)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
     
                SqlCommand cmd = new SqlCommand("eliminarVuelos", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Vuelo", parametro.Id_Vuelos);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }


        public void MostarVuelos(ref DataTable dt) { 
     

            
            try
            {
                CONEXIONMAESTRA.abrir();

         
                SqlDataAdapter da = new SqlDataAdapter("mostrarVuelos", CONEXIONMAESTRA.conexion);
                // SqlDataAdapter da = new SqlDataAdapter("select * from Productos", CONEXIONMAESTRA.conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
  
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public void BuscarVuelos(ref DataTable dt, string buscador)
        {


            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscarVuelos", CONEXIONMAESTRA.conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
                da.Fill(dt);

            }

            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }


        //  FUNCIONES PARA CARGAR DATOS A LOS COMBOBOX  CargarCiudadesCiudadDestino
        public void CargarCiudadesCiudadOrigen(ref DataTable dt) {

            try
            {
                CONEXIONMAESTRA.abrir();
   
                SqlDataAdapter da = new SqlDataAdapter("select Id_Ciudad,Ciudad as [Ciudad Origen] from Ciudades", CONEXIONMAESTRA.conexion);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }

        public void CargarCiudadesCiudadDestino(ref DataTable dt)
        {

            try
            {
                CONEXIONMAESTRA.abrir();

                SqlDataAdapter da = new SqlDataAdapter("select Id_Ciudad,Ciudad as [Ciudad Destino] from Ciudades", CONEXIONMAESTRA.conexion);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }

        public void CargarAreolineas(ref DataTable dt)
        {

            try
            {
                CONEXIONMAESTRA.abrir();

                SqlDataAdapter da = new SqlDataAdapter("select * from Aerolineas", CONEXIONMAESTRA.conexion);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public void CargarEstados(ref DataTable dt)
        {

            try
            {
                CONEXIONMAESTRA.abrir();

                SqlDataAdapter da = new SqlDataAdapter("select * from Estado", CONEXIONMAESTRA.conexion);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }

    }
}
