using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.LOGICA;
using Proyecto.DATOS;
using System.Windows.Forms;

namespace Proyecto.PRESENTACION
{
    public partial class Administrador : UserControl
    {
        public Administrador()
        {
            InitializeComponent();
        }

        int ID;
        string NumeroVuelo;



        private void btnAgregar_Click(object sender, EventArgs e)
        {


            try
            {

                DateTime fecha = DateTime.Today;


                panelRegistro.Visible = true;
                panelRegistro.Dock = DockStyle.Fill; // espandimos en todo el panel
                btnGuardar.Visible = true;
                btnEditar.Visible = false;
             
                mostrarDatos();
          
                panelBtnGuardarPersonal.Visible = true;
                dtvProducto.Visible = false;
                lblVuelo.Text = "Programar Vuelo";
                panel1.Visible = false;
                Llenar_comboBox();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Llenar_comboBox() {

            try
            {

                mostrarCiudadesOrigen();
                mostrarCiudadDestino();
                mostrarAreolinea();
                mostrarEstados();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


          
        }




        private void btnVolverPersonal_Click(object sender, EventArgs e)
        {

            try
            {
                panelRegistro.Visible = false;
                dtvProducto.Visible = true;
                mostrarDatos();
                txtBuscar.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void mostrarDatos()
        {
            try
            {

                DataTable dt = new DataTable();
                Dvuelos funcion = new Dvuelos();
                funcion.MostarVuelos(ref dt);
                Bases.DiseñoDtv(ref dtvProducto);

                dtvProducto.DataSource = dt;
                panel1.Visible = true;
                dtvProducto.Visible = true;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            

        }

        private void Productos_Load(object sender, EventArgs e)
        {


            try
            {
                mostrarDatos();

                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "HH:mm";

                dateTimePicker3.Format = DateTimePickerFormat.Custom;
                dateTimePicker3.CustomFormat = "HH:mm";

                panel1.Visible = true;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


          
        }

        private void mostrarCiudadesOrigen() {


            try
            {

                DataTable dt = new DataTable();
                Dvuelos funcion = new Dvuelos();
                funcion.CargarCiudadesCiudadOrigen(ref dt);

                cboCiuadadOrigen.DisplayMember = "Ciudad Origen";
                cboCiuadadOrigen.ValueMember = "Id_Ciudad";
                cboCiuadadOrigen.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




           


        }

        private void mostrarCiudadDestino() {

            try
            {

                DataTable dt = new DataTable();
                Dvuelos funcion = new Dvuelos();
                funcion.CargarCiudadesCiudadDestino(ref dt);

                cboCiudadDestino.DisplayMember = "Ciudad Destino";
                cboCiudadDestino.ValueMember = "Id_Ciudad";
                cboCiudadDestino.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

  

        }

        private void mostrarAreolinea()
        {


            try
            {


                DataTable dt = new DataTable();
                Dvuelos funcion = new Dvuelos();
                funcion.CargarAreolineas(ref dt);

                cboAreolineas.DisplayMember = "Aerolinea";
                cboAreolineas.ValueMember = "Id_Aerolinea";
                cboAreolineas.DataSource = dt;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void mostrarEstados()
        {

            try
            {

                DataTable dt = new DataTable();
                Dvuelos funcion = new Dvuelos();
                funcion.CargarEstados(ref dt);

                cboEstado.DisplayMember = "Estado";
                cboEstado.ValueMember = "Id_Estado";
                cboEstado.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

     

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            try
            {
                if (verificar_Ciudades() == true)
                {
                    if (TiempodeVuelo() == true)
                    {

                        if (!string.IsNullOrEmpty(txtNumeroVuelo.Text))
                        {
                            insertarVuelos();
                        }

                        else
                        {

                            MessageBox.Show("El campo numero de vuelo no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }







        }

        private void insertarVuelos() {


            try
            {

                LVuelos parametros = new LVuelos();
                Dvuelos funcion = new Dvuelos();

                DateTime HoraSalida = dateTimePicker2.Value;
                DateTime HoraLlegada = dateTimePicker3.Value;

                numero_de_Vuelo();


                //label2.Text = hora.ToString("HH:mm");

                parametros.Id_CO = Convert.ToInt32(cboCiuadadOrigen.SelectedValue);
                parametros.Id_CD = Convert.ToInt32(cboCiudadDestino.SelectedValue);
                parametros.Fecha = dateTimePicker1.Value;
                parametros.HoraSalida = HoraSalida.ToString("HH:mm");
                parametros.HoraLlegada = HoraLlegada.ToString("HH:mm");
                parametros.NumedoDeVuelo = NumeroVuelo;
                parametros.Id_Aerolinea = Convert.ToInt32(cboAreolineas.SelectedValue);
                parametros.Id_Estado = Convert.ToInt32(cboEstado.SelectedValue);


                if (funcion.InsertarVuelos(parametros) == true)
                {

                    MessageBox.Show("Este Vuelo se ha agragado Correctamente", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelRegistro.Visible = false;
                    mostrarDatos();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



           


        }

        private void panelRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {

                if (e.ColumnIndex == dtvProducto.Columns["Editar"].Index)
                {

                     


                    Llenar_comboBox();

                    ID = Convert.ToInt32(dtvProducto.SelectedCells[1].Value);
                    cboCiuadadOrigen.Text = dtvProducto.SelectedCells[2].Value.ToString();
                    cboCiudadDestino.Text = dtvProducto.SelectedCells[3].Value.ToString();
                    dateTimePicker1.Text = dtvProducto.SelectedCells[4].Value.ToString();
                    dateTimePicker2.Text = dtvProducto.SelectedCells[5].Value.ToString();
                    dateTimePicker3.Text = dtvProducto.SelectedCells[6].Value.ToString();
                    txtNumeroVuelo.Text = dtvProducto.SelectedCells[7].Value.ToString();
                    cboAreolineas.Text = dtvProducto.SelectedCells[8].Value.ToString();
                    cboEstado.Text = dtvProducto.SelectedCells[9].Value.ToString();



                    string cadena = txtNumeroVuelo.Text;
                    int longitud;
                    longitud = cadena.Length;
                    longitud = longitud - 2;


                    NumeroVuelo = cadena.Substring(2, longitud);

                   
                    // txtNumeroVuelo.Text = NumeroVuelo;
                    txtNumeroVuelo.Text = NumeroVuelo;

                    panel1.Visible = false;
                    panelRegistro.Visible = true;
                    panelRegistro.Dock = DockStyle.Fill; // espandimos en todo el panel
                    btnGuardar.Visible = false;
                    btnEditar.Visible = true;
                    panelBtnGuardarPersonal.Visible = true;
                    lblVuelo.Text = "Editar Vuelo";
                    dtvProducto.Visible = false;



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
      



            try
            {


                if (verificar_Ciudades() == true)
                {
                    if (TiempodeVuelo() == true)
                    {

                        if (!string.IsNullOrEmpty(txtNumeroVuelo.Text))
                        {

                            editarUsuario();
                        }

                        else
                        {

                            MessageBox.Show("El campo numero de vuelo no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void editarUsuario() {


            try
            {

                LVuelos parametros = new LVuelos();
                Dvuelos funcion = new Dvuelos();

                DateTime HoraSalida = dateTimePicker2.Value;
                DateTime HoraLlegada = dateTimePicker3.Value;

                numero_de_Vuelo();

                parametros.Id_Vuelos = ID;
                parametros.Id_CO = Convert.ToInt32(cboCiuadadOrigen.SelectedValue);
                parametros.Id_CD = Convert.ToInt32(cboCiudadDestino.SelectedValue);
                parametros.Fecha = dateTimePicker1.Value;
                parametros.HoraSalida = HoraSalida.ToString("HH:mm");
                parametros.HoraLlegada = HoraLlegada.ToString("HH:mm");
                parametros.NumedoDeVuelo = NumeroVuelo;
                parametros.Id_Aerolinea = Convert.ToInt32(cboAreolineas.SelectedValue);
                parametros.Id_Estado = Convert.ToInt32(cboEstado.SelectedValue);



                if (funcion.EditarVuelos(parametros) == true)
                {

                    MessageBox.Show("Este Vuelo se ha editado con Exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelRegistro.Visible = false;
                    mostrarDatos();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




           

        }





        private void dtvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                LVuelos parametros = new LVuelos();
                Dvuelos funcion = new Dvuelos();


                parametros.Id_Vuelos = Convert.ToInt32(dtvProducto.SelectedCells[1].Value);



                DialogResult resultado = MessageBox.Show("¿ Esta seguro que desea eliminar este Vuelo ?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    if (funcion.EliminarVuelos(parametros) == true)
                    {

                        MessageBox.Show("Este Registro se ha eliminado con Exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panelRegistro.Visible = false;
                        mostrarDatos();

                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = new DataTable();
                Dvuelos funcion = new Dvuelos();

                funcion.BuscarVuelos(ref dt, txtBuscar.Text);

                dtvProducto.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





        }




        private bool verificar_Ciudades()
        {

  

            if (cboCiuadadOrigen.Text == cboCiudadDestino.Text)
            {
                MessageBox.Show("La ciudad de origen y la ciudad de destinos no pueden ser las mismas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            else
            {

                return true;

            }

        }

        private void txtNumeroVuelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtNumeroVuelo, e);
        }

        private void numero_de_Vuelo() {


            string areolinean = cboAreolineas.Text;
            NumeroVuelo = areolinean.Substring(0, 2);
            NumeroVuelo = NumeroVuelo + txtNumeroVuelo.Text;

        }


        private bool TiempodeVuelo(){



            double Horas = Bases.DateDiff(Bases.DateInterval.Hour, dateTimePicker2.Value, dateTimePicker3.Value);
            double minutos = Bases.DateDiff(Bases.DateInterval.Minute, dateTimePicker2.Value, dateTimePicker3.Value);
   

            if ((Horas > 0) || (minutos > 0))
            {

                return true;

            }

            else
            {
                MessageBox.Show("La Hora de salida debe ser menor a la hora de llegada ");
                return false;
            }


        }


        private void label10_Click(object sender, EventArgs e)
        {

        }
    } 
}
