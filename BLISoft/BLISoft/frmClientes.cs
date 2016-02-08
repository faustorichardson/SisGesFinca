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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.VSDesigner;
using CrystalDecisions.Web;
using CrystalDecisions.Windows;
using System.Drawing.Imaging;
using System.IO;

namespace BLISoft
{
    public partial class frmClientes : frmBase
    {

        string cModo = "Inicio";

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            cModo = "Inicio";
            this.Botones();
            fillComboProvincincia();
        }

        private void Limpiar()
        {
            txtID.Clear();
            txtEmpresa.Clear();
            txtRNC.Clear();
            txtTelefono.Clear();
            txtTelefono2.Clear();
            txtFax.Clear();
            txtDireccion.Clear();
            cmbProvincia.Refresh();
            txtCorreo.Clear();
            chkActivo.Checked = false;
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
                MyCommand.CommandText = "SELECT count(*) FROM clientes";

                // Step 4 - Open connection
                MyConexion.Open();

                // Step 5 - Execute the SQL Statement y Asigno el valor resultante a la variable "codigo"
                int codigo;
                codigo = Convert.ToInt32(MyCommand.ExecuteScalar());
                codigo = codigo + 1;
                txtID.Text = Convert.ToString(codigo);                

                // Step 5 - Close the connection
                MyConexion.Close();
            }
            catch (MySqlException MyEx)
            {
                MessageBox.Show(MyEx.Message);
            }

        }

        private void fillComboProvincincia()
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
                    txtRNC.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtTelefono2.Enabled = false;
                    txtFax.Enabled = false;
                    txtDireccion.Enabled = false;
                    cmbProvincia.Enabled = false;
                    txtCorreo.Enabled = false;
                    chkActivo.Enabled = false;
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
                    txtRNC.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtTelefono2.Enabled = true;
                    txtFax.Enabled = true;
                    txtDireccion.Enabled = true;
                    cmbProvincia.Enabled = true;
                    txtCorreo.Enabled = true;
                    chkActivo.Enabled = true;
                    chkActivo.Checked = true;
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
                    chkActivo.Enabled = false;
                    //
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
                    txtRNC.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtTelefono2.Enabled = true;
                    txtFax.Enabled = true;
                    txtDireccion.Enabled = true;
                    cmbProvincia.Enabled = true;
                    txtCorreo.Enabled = true;
                    chkActivo.Enabled = true;                    
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
                    txtRNC.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtTelefono2.Enabled = false;
                    txtFax.Enabled = false;
                    txtDireccion.Enabled = false;
                    cmbProvincia.Enabled = false;
                    txtCorreo.Enabled = false;
                    chkActivo.Enabled = false;
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
            this.txtEmpresa.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtEmpresa.Text == "" && txtID.Text == "")
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
                        myCommand.CommandText = "INSERT INTO clientes(nombre, rnc, telefono, telefono2, fax, direccion, provincia, correo, status)" +                            
                            " values(@nombre, @rnc, @telefono, @telefono2, @fax, @direccion, @provincia, @correo, @status)";
                        myCommand.Parameters.AddWithValue("@nombre", txtEmpresa.Text);
                        myCommand.Parameters.AddWithValue("@rnc", txtRNC.Text);
                        myCommand.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        myCommand.Parameters.AddWithValue("@telefono2", txtTelefono2.Text);
                        myCommand.Parameters.AddWithValue("@fax", txtFax.Text);
                        myCommand.Parameters.AddWithValue("@direccion", txtDireccion.Text);                        
                        myCommand.Parameters.AddWithValue("@provincia", cmbProvincia.SelectedValue);
                        myCommand.Parameters.AddWithValue("@correo", txtCorreo.Text);
                        int status = 0;
                        if (chkActivo.Checked == true)
                        {
                            status = 1;
                            myCommand.Parameters.AddWithValue("@status", status);
                        }
                        else
                        {                            
                            myCommand.Parameters.AddWithValue("@status", status);
                        }

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
                        myCommand.CommandText = "UPDATE clientes SET nombre = @nombre, rnc = @rnc, telefono = @telefono," +
                            "telefono2 = @telefono2, fax = @fax, direccion = @direccion, provincia = @provincia, correo = @correo,"+
                            "status = @status WHERE idclientes = " + txtID.Text + "";
                        myCommand.Parameters.AddWithValue("@nombre", txtEmpresa.Text);
                        myCommand.Parameters.AddWithValue("@rnc", txtRNC.Text);
                        myCommand.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        myCommand.Parameters.AddWithValue("@telefono2", txtTelefono2.Text);
                        myCommand.Parameters.AddWithValue("@fax", txtFax.Text);
                        myCommand.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        myCommand.Parameters.AddWithValue("@provincia", cmbProvincia.SelectedValue);
                        myCommand.Parameters.AddWithValue("@correo", txtCorreo.Text);
                        int status = 0;
                        if (chkActivo.Checked == true)
                        {
                            status = 1;
                            myCommand.Parameters.AddWithValue("@status", status);
                        }
                        else
                        {
                            myCommand.Parameters.AddWithValue("@status", status);
                        }

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
                    MyCommand.CommandText = "SELECT nombre, rnc, telefono, telefono2, fax, direccion, provincia, correo, status " +
                        "FROM clientes WHERE idclientes = " + txtID.Text + "";

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
                            txtRNC.Text = MyReader["rnc"].ToString();
                            txtTelefono.Text = MyReader["telefono"].ToString();
                            txtTelefono2.Text = MyReader["telefono2"].ToString();
                            txtFax.Text = MyReader["fax"].ToString();
                            txtDireccion.Text = MyReader["direccion"].ToString();
                            cmbProvincia.SelectedValue = MyReader["provincia"].ToString();
                            txtCorreo.Text = MyReader["correo"].ToString();
                            int status = Convert.ToInt32(MyReader["status"]);
                            if (status == 1)
                            {
                                chkActivo.Checked = true;
                            }
                            else
                            {
                                chkActivo.Checked = false;
                            }
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
            //clsConexion a la base de datos
            MySqlConnection myclsConexion = new MySqlConnection(Conexion.ConectionString);
            // Creando el command que ejecutare
            MySqlCommand myCommand = new MySqlCommand();
            // Creando el Data Adapter
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            // Creando el String Builder
            StringBuilder sbQuery = new StringBuilder();
            // Otras variables del entorno
            string cWhere = " WHERE 1 = 1";
            string cUsuario = frmLogin.cUsuarioActual;
            string cTitulo = "";

            try
            {
                // Abro clsConexion
                myclsConexion.Open();
                // Creo comando
                myCommand = myclsConexion.CreateCommand();
                // Adhiero el comando a la clsConexion
                myCommand.Connection = myclsConexion;
                // Filtros de la busqueda
                // CREANDO EL QUERY DE CONSULTA
                //string fechadesde = fechaDesde.Value.ToString("yyyy-MM-dd");
                //string fechahasta = fechaHasta.Value.ToString("yyyy-MM-dd");
                //cWhere = cWhere + " AND fechacita >= "+"'"+ fechadesde +"'" +" AND fechacita <= "+"'"+ fechahasta +"'"+"";
                //cWhere = cWhere + " AND year = '" + txtYear.Text + "'";
                sbQuery.Clear();
                sbQuery.Append("SELECT clientes.idclientes, clientes.nombre, clientes.rnc, clientes.telefono, clientes.telefono2,");
                sbQuery.Append(" clientes.fax, clientes.direccion, provincias.provincia, clientes.correo, clientes.status");
                sbQuery.Append(" FROM clientes");
                sbQuery.Append(" INNER JOIN provincias ON provincias.idprovincia = clientes.provincia");
                sbQuery.Append(cWhere);

                // Paso los valores de sbQuery al CommandText
                myCommand.CommandText = sbQuery.ToString();

                // Creo el objeto Data Adapter y ejecuto el command en el
                myAdapter = new MySqlDataAdapter(myCommand);

                // Creo el objeto Data Table
                DataTable dtClientes = new DataTable();

                // Lleno el data adapter
                myAdapter.Fill(dtClientes);

                // Cierro el objeto clsConexion
                myclsConexion.Close();

                // Verifico cantidad de datos encontrados
                int nRegistro = dtClientes.Rows.Count;
                if (nRegistro == 0)
                {
                    MessageBox.Show("No Hay Datos Para Mostrar, Favor Verificar", "Sistema de Gestion Bananera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    //1ero.HACEMOS LA COLECCION DE PARAMETROS
                    //los campos de parametros contiene un objeto para cada campo de parametro en el informe
                    ParameterFields oParametrosCR = new ParameterFields();
                    //Proporciona propiedades para la recuperacion y configuracion del tipo de los parametros
                    ParameterValues oParametrosValuesCR = new ParameterValues();

                    //2do.CREAMOS LOS PARAMETROS
                    ParameterField oUsuario = new ParameterField();
                    //parametervaluetype especifica el TIPO de valor de parametro
                    //ParameterValueKind especifica el tipo de valor de parametro en la PARAMETERVALUETYPE de la Clase PARAMETERFIELD
                    oUsuario.ParameterValueType = ParameterValueKind.StringParameter;

                    //3ero.VALORES PARA LOS PARAMETROS
                    //ParameterDiscreteValue proporciona propiedades para la recuperacion y configuracion de 
                    //parametros de valores discretos
                    ParameterDiscreteValue oUsuarioDValue = new ParameterDiscreteValue();
                    oUsuarioDValue.Value = cUsuario;

                    //4to. AGREGAMOS LOS VALORES A LOS PARAMETROS
                    oUsuario.CurrentValues.Add(oUsuarioDValue);


                    //5to. AGREGAMOS LOS PARAMETROS A LA COLECCION 
                    oParametrosCR.Add(oUsuario);
                    //nombre del parametro en CR (Crystal Reports)
                    oParametrosCR[0].Name = "cUsuario";
                    //nombre del TITULO DEL INFORME
                    cTitulo = "LISTADO DE CLIENTES";

                    //6to Instanciamos nuestro REPORTE
                    //Reportes.ListadoDoctores oListado = new Reportes.ListadoDoctores();
                    REPORTES.rptClientes orptClientes = new REPORTES.rptClientes();
                    //pasamos el nombre del TITULO del Listado
                    //SumaryInfo es un objeto que se utiliza para leer,crear y actualizar las propiedades del reporte
                    // oListado.SummaryInfo.ReportTitle = cTitulo;
                    orptClientes.SummaryInfo.ReportTitle = cTitulo;

                    //7mo. instanciamos nuestro el FORMULARIO donde esta nuestro ReportViewer
                    frmPrinter ofrmPrinter = new frmPrinter(dtClientes, orptClientes, cTitulo);
                    //ParameterFieldInfo Obtiene o establece la colección de campos de parámetros.                                                            
                    ofrmPrinter.CrystalReportViewer1.ParameterFieldInfo = oParametrosCR;
                    ofrmPrinter.ShowDialog();
                }
            }
            catch (Exception myEx)
            {
                MessageBox.Show("Error : " + myEx.Message, "Mostrando Reporte", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                // clsExceptionLog.LogError(myEx, false);
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" || txtEmpresa.Text != "" || txtRNC.Text != "")
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
