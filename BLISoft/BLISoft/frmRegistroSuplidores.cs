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
    public partial class frmRegistroSuplidores : frmBase
    {
        string cModo = "Inicio";

        public frmRegistroSuplidores()
        {
            InitializeComponent();
        }

        private void frmRegistroSuplidores_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            cModo = "Inicio";
            this.Botones();
            this.fillComboProvincia();
        }

        private void Limpiar()
        {
            txtID.Clear();
            txtEmpresa.Clear();
            txtRazonSocial.Clear();
            txtMarca.Clear();
            txtRNC.Clear();
            txtTelefono.Clear();
            txtTelefono2.Clear();
            txtDireccion.Clear();
            txtFax.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtContacto.Clear();
            txtTelContacto.Clear();
            txtExtensionContacto.Clear();
            txtCelularContacto.Clear();
            txtExtensionContacto.Clear();
            cmbProvincia.Refresh();
        }

        private void ProximoCodigo()
        {
            try
            {
                // Step 1 - Connection stablished
                MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

                // Step 2 - Create command
                MySqlCommand MyCommand = MyConexion.CreateCommand();

                // Step 3 - Set the commanndtext property
                MyCommand.CommandText = "SELECT count(*) FROM suplidores";

                // Step 4 - Open connection
                MyConexion.Open();

                // Step 5 - Execute the SQL Statement y Asigno el valor resultante a la variable "codigo"
                int codigo;
                codigo = Convert.ToInt32(MyCommand.ExecuteScalar());
                codigo = codigo + 1;                
                txtID.Text = Convert.ToString(codigo);
                txtEmpresa.Focus();

                // Step 5 - Close the connection
                MyConexion.Close();
            }
            catch (MySqlException MyEx)
            {
                MessageBox.Show(MyEx.Message);
            }

        }

        private void fillComboProvincia() 
        {
            try
            {
                // Step 1 
	            MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

                // Step 2
                MyConexion.Open();

                // Step 3
                MySqlCommand MyCommand = new MySqlCommand("SELECT idprovincia, provincia FROM provincias ORDER BY provincia ASC", MyConexion);

                // Step 4
                MySqlDataReader MyReader;
                MyReader = MyCommand.ExecuteReader();

                // Step 5
                DataTable MyDataTable = new DataTable();
                MyDataTable.Columns.Add("idprovincia", typeof(int));
                MyDataTable.Columns.Add("provincia", typeof(string));
                MyDataTable.Load(MyReader);

                // Step 6
                cmbProvincia.ValueMember = "idprovincia";
                cmbProvincia.DisplayMember = "provincia";
                cmbProvincia.DataSource = MyDataTable;

                // Step 7
                MyConexion.Close();
            }
            catch (Exception myEx)
            {
                MessageBox.Show(myEx.Message);
                throw;
            }
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
                    this.btnImprimir.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnSalir.Enabled = true;
                    //
                    txtID.Enabled = true;
                    txtEmpresa.Enabled = false;
                    txtRazonSocial.Enabled = false;
                    txtMarca.Enabled = false;
                    txtRNC.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtTelefono2.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtFax.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtContacto.Enabled = false;
                    txtTelContacto.Enabled = false;
                    txtExtensionContacto.Enabled = false;
                    txtCelularContacto.Enabled = false;
                    txtExtensionContacto.Enabled = false;
                    cmbProvincia.Enabled = false;
                    //
                    txtID.Focus();
                    break;

                case "Nuevo":
                    this.btnNuevo.Enabled = false;
                    this.btnGrabar.Enabled = true;
                    this.btnEditar.Enabled = false;
                    this.btnBuscar.Enabled = false;
                    this.btnImprimir.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    this.btnSalir.Enabled = true;
                    //
                    txtID.Enabled = false;
                    txtEmpresa.Enabled = true;
                    txtRazonSocial.Enabled = true;
                    txtMarca.Enabled = true;
                    txtRNC.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtTelefono2.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtFax.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtContacto.Enabled = true;
                    txtTelContacto.Enabled = true;
                    txtExtensionContacto.Enabled = true;
                    txtCelularContacto.Enabled = true;
                    txtExtensionContacto.Enabled = true;
                    cmbProvincia.Enabled = true;
                    break;

                case "Grabar":
                    this.btnNuevo.Enabled = true;
                    this.btnGrabar.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnBuscar.Enabled = true;
                    this.btnImprimir.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnSalir.Enabled = true;
                    //
                    txtID.Enabled = true;
                    txtEmpresa.Enabled = false;
                    txtRazonSocial.Enabled = false;
                    txtMarca.Enabled = false;
                    txtRNC.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtTelefono2.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtFax.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtContacto.Enabled = false;
                    txtTelContacto.Enabled = false;
                    txtExtensionContacto.Enabled = false;
                    txtCelularContacto.Enabled = false;
                    txtExtensionContacto.Enabled = false;
                    cmbProvincia.Enabled = false;
                    break;

                case "Editar":
                    this.btnNuevo.Enabled = false;
                    this.btnGrabar.Enabled = true;
                    this.btnEditar.Enabled = false;
                    this.btnBuscar.Enabled = false;
                    this.btnImprimir.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    this.btnSalir.Enabled = true;
                    //
                    txtID.Enabled = false;
                    txtEmpresa.Enabled = true;
                    txtRazonSocial.Enabled = true;
                    txtMarca.Enabled = true;
                    txtRNC.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtTelefono2.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtFax.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtContacto.Enabled = true;
                    txtTelContacto.Enabled = true;
                    txtExtensionContacto.Enabled = true;
                    txtCelularContacto.Enabled = true;
                    txtExtensionContacto.Enabled = true;
                    cmbProvincia.Enabled = true;
                    break;

                case "Buscar":
                    this.btnNuevo.Enabled = true;
                    this.btnGrabar.Enabled = false;
                    this.btnEditar.Enabled = true;
                    this.btnBuscar.Enabled = true;
                    this.btnImprimir.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnSalir.Enabled = true;
                    //
                    txtID.Enabled = true;
                    txtEmpresa.Enabled = false;
                    txtRazonSocial.Enabled = false;
                    txtMarca.Enabled = false;
                    txtRNC.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtTelefono2.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtFax.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtContacto.Enabled = false;
                    txtTelContacto.Enabled = false;
                    txtExtensionContacto.Enabled = false;
                    txtCelularContacto.Enabled = false;
                    txtExtensionContacto.Enabled = false;
                    cmbProvincia.Enabled = false;
                    break;

                case "Eliminar":
                    break;

                case "Cancelar":
                    this.btnNuevo.Enabled = true;
                    this.btnGrabar.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnBuscar.Enabled = true;
                    this.btnImprimir.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnSalir.Enabled = true;
                    break;

                default:
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cModo = "Nuevo";
            this.Limpiar();
            this.Botones();
            this.ProximoCodigo();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtEmpresa.Text == "" || txtContacto.Text == "")
            {
                MessageBox.Show("No se permiten campos vacios...");
                txtEmpresa.Focus();
            }
            else
            {
                if (cModo == "Nuevo")
                {
                    try
                    {
                        // Step 1 - Stablishing the connection
                        MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

                        // Step 2 - Crear el comando de ejecucion
                        MySqlCommand myCommand = MyConexion.CreateCommand();

                        // Step 3 - Comando a ejecutar
                        myCommand.CommandText = "INSERT INTO suplidores(nombre, razonsocial, marca, rnc, telefono, fax, direccion, provincia,"+
                            "correo, contacto, telcontacto, extension, correocontacto, celcontacto, telefono2) values(@nombre, @razonsocial, @marca, @rnc,"+
                            "@telefono, @fax, @direccion, @provincia, @correo, @contacto, @telcontacto, @extension, @correocontacto, @celcontacto, @telefono2)";
                        myCommand.Parameters.AddWithValue("@nombre", txtEmpresa.Text);
                        myCommand.Parameters.AddWithValue("@razonsocial", txtRazonSocial.Text);
                        myCommand.Parameters.AddWithValue("@marca", txtMarca.Text);
                        myCommand.Parameters.AddWithValue("@rnc", txtRNC.Text);
                        myCommand.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        myCommand.Parameters.AddWithValue("@fax", txtFax.Text);
                        myCommand.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        myCommand.Parameters.AddWithValue("@provincia", cmbProvincia.SelectedValue);
                        myCommand.Parameters.AddWithValue("@correo", txtCorreo.Text);
                        myCommand.Parameters.AddWithValue("@contacto", txtContacto.Text);
                        myCommand.Parameters.AddWithValue("@telcontacto", txtTelContacto.Text);
                        myCommand.Parameters.AddWithValue("@extension", txtExtensionContacto.Text);
                        myCommand.Parameters.AddWithValue("@correocontacto", txtCorreoContacto.Text);
                        myCommand.Parameters.AddWithValue("@celcontacto", txtCelularContacto.Text);
                        myCommand.Parameters.AddWithValue("@telefono2", txtTelefono2.Text);

                        // Step 4 - Opening the connection
                        MyConexion.Open();

                        // Step 5 - Executing the query
                        myCommand.ExecuteNonQuery();

                        // Step 6 - Closing the connection
                        MyConexion.Close();

                        MessageBox.Show("Informacion guardada satisfactoriamente...");
                    }
                    catch (Exception MyEx)
                    {
                        MessageBox.Show(MyEx.Message);
                    }

                }
                else
                {
                    try
                    {
                        // Step 1 - Stablishing the connection
                        MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

                        // Step 2 - Crear el comando de ejecucion
                        MySqlCommand myCommand = MyConexion.CreateCommand();

                        // Step 3 - Comando a ejecutar
                        myCommand.CommandText = "UPDATE suplidores SET nombre = @nombre, razonsocial = @razonsocial, marca = @marca,"+
                            "rnc = @rnc, telefono = @telefono, fax = @fax, direccion = @direccion, provincia = @provincia,"+
                            "correo = @correo, contacto = @contacto, telcontacto = @telcontacto, extension = @extension,"+
                            "correocontacto = @correocontacto, celcontacto = @celcontacto, telefono2 = @telefono2 " +
                            "WHERE idsuplidores = " + txtID.Text + "";
                        myCommand.Parameters.AddWithValue("@nombre", txtEmpresa.Text);
                        myCommand.Parameters.AddWithValue("@razonsocial", txtRazonSocial.Text);
                        myCommand.Parameters.AddWithValue("@marca", txtMarca.Text);
                        myCommand.Parameters.AddWithValue("@rnc", txtRNC.Text);
                        myCommand.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        myCommand.Parameters.AddWithValue("@fax", txtFax.Text);
                        myCommand.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        myCommand.Parameters.AddWithValue("@provincia", cmbProvincia.SelectedValue);
                        myCommand.Parameters.AddWithValue("@correo", txtCorreo.Text);
                        myCommand.Parameters.AddWithValue("@contacto", txtContacto.Text);
                        myCommand.Parameters.AddWithValue("@telcontacto", txtTelContacto.Text);
                        myCommand.Parameters.AddWithValue("@extension", txtExtensionContacto.Text);
                        myCommand.Parameters.AddWithValue("@correocontacto", txtCorreoContacto.Text);
                        myCommand.Parameters.AddWithValue("@celcontacto", txtCelularContacto.Text);
                        myCommand.Parameters.AddWithValue("@telefono2", txtTelefono2.Text);

                        // Step 4 - Opening the connection
                        MyConexion.Open();

                        // Step 5 - Executing the query
                        myCommand.ExecuteNonQuery();

                        // Step 6 - Closing the connection
                        MyConexion.Close();

                        MessageBox.Show("Informacion actualizada satisfactoriamente...");
                    }
                    catch (Exception MyEx)
                    {
                        MessageBox.Show(MyEx.Message);
                    }

                }

                this.Limpiar();
                cModo = "Inicio";
                this.Botones();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.cModo = "Editar";
            this.Botones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("No se permiten busquedas vacias...");
                txtID.Focus();
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
                    MyCommand.CommandText = "SELECT nombre, razonsocial, marca, rnc, telefono, fax, direccion, provincia, correo,"+
                        "contacto, telcontacto, extension, correocontacto, celcontacto, telefono2 " +
                        "FROM suplidores WHERE idsuplidores = " + txtID.Text + "";

                    // Step 4 - connection open
                    MyConexion.Open();

                    // Step 5 - Creating the DataReader                    
                    MySqlDataReader MyReader = MyCommand.ExecuteReader();

                    // Step 6 - Verifying if Reader has rows
                    if (MyReader.HasRows)
                    {
                        while (MyReader.Read())
                        {
                            txtEmpresa.Text = MyReader["nombre"].ToString();
                            txtRazonSocial.Text = MyReader["razonsocial"].ToString();
                            txtMarca.Text = MyReader["marca"].ToString();
                            txtRNC.Text = MyReader["rnc"].ToString();
                            txtTelefono.Text = MyReader["telefono"].ToString();
                            txtFax.Text = MyReader["fax"].ToString();
                            txtDireccion.Text = MyReader["direccion"].ToString();
                            cmbProvincia.SelectedValue = MyReader["provincia"].ToString();
                            txtCorreo.Text = MyReader["correo"].ToString();
                            txtContacto.Text = MyReader["contacto"].ToString();
                            txtTelContacto.Text = MyReader["telcontacto"].ToString();
                            txtExtensionContacto.Text = MyReader["extension"].ToString();
                            txtCorreoContacto.Text = MyReader["correocontacto"].ToString();
                            txtCelularContacto.Text = MyReader["celcontacto"].ToString();
                            txtTelefono2.Text = MyReader["telefono2"].ToString();
                        }

                        this.cModo = "Buscar";
                        this.Botones();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros...");
                        this.cModo = "Inicio";
                        this.Botones();
                        this.Limpiar();
                        this.txtID.Focus();
                    }

                    // Step 6 - Closing all
                    MyReader.Close();
                    MyCommand.Dispose();
                    MyConexion.Close();

                }
                catch (Exception MyEx)
                {
                    MessageBox.Show(MyEx.Message);
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmGnrRptSuplidores ofrmGnrRptSuplidores = new frmGnrRptSuplidores();
            ofrmGnrRptSuplidores.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtEmpresa.Text != "" || txtContacto.Text != "")
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}
