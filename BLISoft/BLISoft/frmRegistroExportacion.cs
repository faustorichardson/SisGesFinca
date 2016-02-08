using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace BLISoft
{
    public partial class frmRegistroExportacion : frmBase
    {
        string cModo = "Inicio";

        public frmRegistroExportacion()
        {
            InitializeComponent();
        }

        private void frmRegistroExportacion_Load(object sender, EventArgs e)
        {
            this.fillComboCliente();
            this.Limpiar();            
            this.cModo = "Inicio";
            this.Botones();
        }

        private void fillComboCliente()
        {
            // Step 1 
            MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

            // Step 2
            MyConexion.Open();

            // Step 3
            MySqlCommand MyCommand = new MySqlCommand("SELECT idclientes, nombre FROM clientes ORDER BY nombre ASC", MyConexion);

            // Step 4
            MySqlDataReader MyReader;
            MyReader = MyCommand.ExecuteReader();

            // Step 5
            DataTable MyDataTable = new DataTable();
            MyDataTable.Columns.Add("idclientes", typeof(int));
            MyDataTable.Columns.Add("nombre", typeof(string));
            MyDataTable.Load(MyReader);

            // Step 6
            cmbCliente.ValueMember = "idclientes";
            cmbCliente.DisplayMember = "nombre";
            cmbCliente.DataSource = MyDataTable;

            // Step 7
            MyConexion.Close();
        }

        private void Limpiar()
        {
            txtRegistro.Clear();
            txtCantidadRacimos.Clear();
            txtCantidadLibras.Clear();
            txtCantidadPaletas.Clear();
            txtCantidadCajas.Clear();
            cmbCliente.Refresh();
            txtPrecioVenta.Clear();
            txtNeveras.Clear();
            txtFecha.Refresh();
            txtRegistro.Focus();
        }

        private void ProximoRegistro()
        {
            try
            {
                // Step 1 - Connection stablished
                MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

                // Step 2 - Create command
                MySqlCommand MyCommand = MyConexion.CreateCommand();

                // Step 3 - Set the commanndtext property
                MyCommand.CommandText = "SELECT count(*) FROM ventas";

                // Step 4 - Open connection
                MyConexion.Open();

                // Step 5 - Execute the SQL Statement y Asigno el valor resultante a la variable "codigo"
                int codigo;
                codigo = Convert.ToInt32(MyCommand.ExecuteScalar());
                codigo = codigo + 1;
                txtRegistro.Text = Convert.ToString(codigo);
                txtFecha.Focus();                

                // Step 5 - Close the connection
                MyConexion.Close();
            }
            catch (MySqlException MyEx)
            {
                MessageBox.Show(MyEx.Message);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cModo = "Nuevo";
            this.Botones();
            this.ProximoRegistro();
            this.txtFecha.Focus();
        }

        private void Botones()
        {
            switch (cModo)
            {
                case "Inicio":
                    this.btnNuevo.Enabled = true;
                    this.btnGrabar.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnBuscar.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnSalir.Enabled = true;
                    //
                    this.txtCantidadRacimos.Enabled = false;
                    this.txtCantidadLibras.Enabled = false;
                    this.txtCantidadPaletas.Enabled = false;
                    this.txtCantidadCajas.Enabled = false;
                    this.cmbCliente.Enabled = false;
                    this.txtPrecioVenta.Enabled = false;
                    this.txtNeveras.Enabled = false;
                    this.txtRegistro.Enabled = true;
                    this.txtFecha.Enabled = false;
                    break;

                case "Nuevo":
                    this.btnNuevo.Enabled = false;
                    this.btnGrabar.Enabled = true;
                    this.btnEditar.Enabled = false;
                    this.btnBuscar.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    this.btnSalir.Enabled = true;
                    //
                    this.txtCantidadRacimos.Enabled = true;
                    this.txtCantidadLibras.Enabled = true;
                    this.txtCantidadPaletas.Enabled = false;
                    this.txtCantidadCajas.Enabled = false;
                    this.cmbCliente.Enabled = true;
                    this.txtPrecioVenta.Enabled = true;
                    this.txtNeveras.Enabled = false;
                    this.txtRegistro.Enabled = false;
                    this.txtFecha.Enabled = true;
                    break;

                case "Grabar":
                    this.btnNuevo.Enabled = true;
                    this.btnGrabar.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnBuscar.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnSalir.Enabled = true;
                    //
                    this.txtCantidadRacimos.Enabled = false;
                    this.txtCantidadLibras.Enabled = false;
                    this.txtCantidadPaletas.Enabled = false;
                    this.txtCantidadCajas.Enabled = false;
                    this.cmbCliente.Enabled = false;
                    this.txtPrecioVenta.Enabled = false;
                    this.txtNeveras.Enabled = false;
                    this.txtRegistro.Enabled = true;
                    this.txtFecha.Enabled = false;
                    break;

                case "Editar":
                    this.btnNuevo.Enabled = false;
                    this.btnGrabar.Enabled = true;
                    this.btnEditar.Enabled = false;
                    this.btnBuscar.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    this.btnSalir.Enabled = true;
                    //
                    this.txtCantidadRacimos.Enabled = true;
                    this.txtCantidadLibras.Enabled = true;
                    this.txtCantidadPaletas.Enabled = false;
                    this.txtCantidadCajas.Enabled = false;
                    this.cmbCliente.Enabled = true;
                    this.txtPrecioVenta.Enabled = true;
                    this.txtNeveras.Enabled = false;
                    this.txtRegistro.Enabled = false;
                    this.txtFecha.Enabled = true;
                    break;

                case "Buscar":
                    this.btnNuevo.Enabled = true;
                    this.btnGrabar.Enabled = false;
                    this.btnEditar.Enabled = true;
                    this.btnBuscar.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnSalir.Enabled = true;
                    //
                    this.txtCantidadRacimos.Enabled = false;
                    this.txtCantidadLibras.Enabled = false;
                    this.txtCantidadPaletas.Enabled = false;
                    this.txtCantidadCajas.Enabled = false;
                    this.cmbCliente.Enabled = false;
                    this.txtPrecioVenta.Enabled = false;
                    this.txtNeveras.Enabled = false;
                    this.txtRegistro.Enabled = true;
                    this.txtFecha.Enabled = false;
                    break;

                case "Eliminar":
                    break;

                case "Cancelar":
                    this.btnNuevo.Enabled = true;
                    this.btnGrabar.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnBuscar.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnSalir.Enabled = true;
                    break;

                default:
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtCantidadRacimos.Text == "")
            {
                MessageBox.Show("No se puede guardar con el campo Cantidad Racimos en blanco...");
                txtCantidadRacimos.Focus();
            }
            else if (txtCantidadLibras.Text == "")
            {
                MessageBox.Show("No se puede guardar con el campo Cantidad Libras en blanco...");
                txtCantidadLibras.Focus();
            }
            else if (txtCantidadPaletas.Text == "")
            {
                MessageBox.Show("No se puede guardar con el campo Cantidad Paletas en blanco...");
                txtCantidadPaletas.Focus();
            }
            else if (txtCantidadCajas.Text == "")
            {
                MessageBox.Show("No se puede guardar con el campo Cantidad Cajas en blanco...");
                txtCantidadCajas.Focus();
            }
            else if (txtPrecioVenta.Text == "")
            {
                MessageBox.Show("No se puede guardar con el campo Precio Venta en blanco...");
                txtPrecioVenta.Focus();
            }
            else
            {
                // Verifico si el modo es nuevo para agregar un registro nuevo
                if (cModo == "Nuevo")
                {
                    try
                    {
                        // Step 1 - Stablishing the connection
                        MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

                        // Step 2 - Crear el comando de ejecucion
                        MySqlCommand myCommand = MyConexion.CreateCommand();

                        // Step 3 - Comando a ejecutar                        
                        myCommand.CommandText = "INSERT INTO ventas(paletas, libras, cajas, racimos," +
                            "precioventa, vendidoa, fecha, neveras) values(@paletas, @libras, @cajas, @racimos, " +
                            "@precioventa, @vendidoa, @fecha, @neveras)";                        
                        myCommand.Parameters.AddWithValue("@paletas", txtCantidadPaletas.Text);
                        myCommand.Parameters.AddWithValue("@libras", txtCantidadLibras.Text);
                        myCommand.Parameters.AddWithValue("@cajas", txtCantidadCajas.Text);
                        myCommand.Parameters.AddWithValue("@racimos", txtCantidadRacimos.Text);
                        myCommand.Parameters.AddWithValue("@precioventa", txtPrecioVenta.Text);
                        myCommand.Parameters.AddWithValue("@vendidoa", cmbCliente.SelectedValue);
                        myCommand.Parameters.AddWithValue("@fecha", txtFecha.Value.ToString("yyyy-MM-dd"));
                        myCommand.Parameters.AddWithValue("@neveras", txtNeveras.Text);

                        // Step 4 - Opening the connection
                        MyConexion.Open();

                        // Step 5 - Executing the query
                        myCommand.ExecuteNonQuery();

                        // Step 6 - Closing the connection
                        MyConexion.Close();
                        myCommand.Dispose();
                        MessageBox.Show("Informacion guardada satisfactoriamente...");

                        // Limpiando pantalla
                        this.Limpiar();
                        this.cModo = "Inicio";
                        this.Botones();

                    }
                    catch (Exception MyEx)
                    {
                        MessageBox.Show(MyEx.Message);
                    }
                }
                // de lo contrario actualizo el registro con los datos modificados
                else
                {
                    try
                    {
                        // Step 1 - Stablishing the connection
                        MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

                        // Step 2 - Crear el comando de ejecucion
                        MySqlCommand myCommand = MyConexion.CreateCommand();

                        // Step 3 - Comando a ejecutar                        
                        myCommand.CommandText = "UPDATE ventas SET paletas = @paletas, " +
                            "libras = @libras, cajas = @cajas, racimos = @racimos, precioventa = @precioventa, " +
                            "vendidoa = @vendidoa, fecha = @fecha, neveras = @neveras WHERE idregistro = "+ txtRegistro.Text +"";
                        myCommand.Parameters.AddWithValue("@paletas", txtCantidadPaletas.Text);
                        myCommand.Parameters.AddWithValue("@libras", txtCantidadLibras.Text);
                        myCommand.Parameters.AddWithValue("@cajas", txtCantidadCajas.Text);
                        myCommand.Parameters.AddWithValue("@racimos", txtCantidadRacimos.Text);
                        myCommand.Parameters.AddWithValue("@precioventa", txtPrecioVenta.Text);
                        myCommand.Parameters.AddWithValue("@vendidoa", cmbCliente.SelectedValue);
                        myCommand.Parameters.AddWithValue("@fecha", txtFecha.Value.ToString("yyyy-MM-dd"));
                        myCommand.Parameters.AddWithValue("@neveras", txtNeveras.Text);

                        // Step 4 - Opening the connection
                        MyConexion.Open();

                        // Step 5 - Executing the query
                        myCommand.ExecuteNonQuery();

                        // Step 6 - Closing the connection
                        MyConexion.Close();
                        myCommand.Dispose();
                        MessageBox.Show("Informacion actualizada satisfactoriamente...");

                        // Limpiando pantalla
                        this.Limpiar();
                        this.cModo = "Inicio";
                        this.Botones();
                    }
                    catch (Exception MyEx)
                    {
                        MessageBox.Show(MyEx.Message);
                    }                    
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.cModo = "Editar";
            this.Botones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtFecha.Text == "")
            {
                MessageBox.Show("No se puede hacer busqueda sin fecha definida...");
                txtFecha.Focus();
            }
            else
            {
                try
                {
                    // Step 1 - Conexion
                    MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

                    // Step 2 - creating the command object
                    MySqlCommand MyCommand = MyConexion.CreateCommand();

                    // Step 3 - creating the commandtext
                    string fecha = txtFecha.Value.ToString("yyyy-MM-dd");
                    MyCommand.CommandText = "SELECT idregistro, paletas, libras, cajas, racimos, precioventa, vendidoa, " +
                        "fecha, neveras FROM ventas WHERE idregistro = " + "'"+ txtRegistro.Text +"'" + "";

                    // Step 4 - connection open
                    MyConexion.Open();

                    // Step 5 - Creating the DataReader                    
                    MySqlDataReader MyReader = MyCommand.ExecuteReader();

                    // Step 6 - Verifying if Reader has rows
                    if (MyReader.HasRows)
                    {
                        while (MyReader.Read())
                        {                            
                            txtCantidadPaletas.Text = MyReader["paletas"].ToString();
                            txtCantidadLibras.Text = MyReader["libras"].ToString();
                            txtCantidadCajas.Text = MyReader["cajas"].ToString();
                            txtCantidadRacimos.Text = MyReader["racimos"].ToString();
                            txtPrecioVenta.Text = MyReader["precioventa"].ToString();
                            cmbCliente.SelectedValue = MyReader["vendidoa"].ToString();
                            txtFecha.Value = Convert.ToDateTime(MyReader["fecha"]);
                            txtNeveras.Text = MyReader["neveras"].ToString();

                        }

                        this.cModo = "Buscar";
                        this.Botones();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros...");
                        //MessageBox.Show(fecha);
                        this.cModo = "Inicio";
                        this.Botones();
                        this.Limpiar();                        
                    }

                    // Step 6 - Closing all
                    MyReader.Close();
                    MyCommand.Dispose();
                    MyConexion.Close();
                }
                catch (Exception myEx)
                {
                    MessageBox.Show(myEx.Message);                    
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtRegistro.Text != "" && txtCantidadCajas.Text != "" && txtCantidadLibras.Text != "" && txtCantidadPaletas.Text != "")
            {
                DialogResult Result =
                MessageBox.Show("Se perderan Los cambios Realizados" + System.Environment.NewLine + "Desea Guardar los Cambios", "Sistema Gestion de Plantaciones v1.0", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                switch (Result)
                {
                    case DialogResult.Yes:
                        cModo = "Actualiza";
                        btnGrabar_Click(sender, e);
                        break;
                }
            }

            this.Limpiar();
            this.cModo = "Inicio";
            this.Botones();
        }

        private void txtCantidadLibras_Validating(object sender, CancelEventArgs e)
        {
            // hago los calculos en base a las libras registradas
            // una caja de guineo tiene 42 libras
            // una paleta contiene 48 cajas
            // una nevera contiene 20 paletas
            decimal cantCajas, cantPaletas, cantNeveras;
            cantCajas = Convert.ToDecimal(txtCantidadLibras.Text) / 42;
            cantPaletas = cantCajas / 48;
            cantNeveras = cantPaletas / 20;

            // Pongo los valores en los campos correspondientes
            txtCantidadCajas.Text = Convert.ToString(cantCajas);
            txtCantidadPaletas.Text = Convert.ToString(cantPaletas);
            txtNeveras.Text = Convert.ToString(cantNeveras);
        }
    }
}
