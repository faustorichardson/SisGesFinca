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
    public partial class frmUnidadesMedidas : frmBase
    {
        string cModo = "Inicio";

        public frmUnidadesMedidas()
        {
            InitializeComponent();
        }

        private void frmUnidadesMedidas_Load(object sender, EventArgs e)
        {
            this.cModo = "Inicio";
            this.Botones();
            this.fillComboTipoUnidad();
            this.Limpiar();
            this.txtID.Focus();
        }

        private void fillComboTipoUnidad()
        {
            // Step 1 
            MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

            // Step 2
            MyConexion.Open();

            // Step 3
            MySqlCommand MyCommand = new MySqlCommand("SELECT idunidades, descripcion FROM unidades ORDER BY descripcion ASC", MyConexion);

            // Step 4
            MySqlDataReader MyReader;
            MyReader = MyCommand.ExecuteReader();

            // Step 5
            DataTable MyDataTable = new DataTable();
            MyDataTable.Columns.Add("idunidades", typeof(int));
            MyDataTable.Columns.Add("descripcion", typeof(string));
            MyDataTable.Load(MyReader);

            // Step 6            
            cmbTipoUnidad.ValueMember = "idunidades";
            cmbTipoUnidad.DisplayMember = "descripcion";
            cmbTipoUnidad.DataSource = MyDataTable;

            // Step 7
            MyConexion.Close();
        }

        private void Limpiar()
        {
            txtID.Clear();
            txtDescripcion.Clear();
            txtAbreviatura.Clear();
            txtEquivalencia.Clear();
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
                    this.txtID.Enabled = true;
                    this.txtDescripcion.Enabled = false;
                    this.txtAbreviatura.Enabled = false;
                    this.txtEquivalencia.Enabled = false;
                    this.cmbTipoUnidad.Enabled = false;
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
                    this.txtID.Enabled = false;
                    this.txtDescripcion.Enabled = true;
                    this.txtAbreviatura.Enabled = true;
                    this.txtEquivalencia.Enabled = true;
                    this.cmbTipoUnidad.Enabled = true;
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
                    this.txtID.Enabled = false;
                    this.txtDescripcion.Enabled = true;
                    this.txtAbreviatura.Enabled = true;
                    this.txtEquivalencia.Enabled = true;
                    this.cmbTipoUnidad.Enabled = true;
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
                    this.txtID.Enabled = false;
                    this.txtDescripcion.Enabled = true;
                    this.txtAbreviatura.Enabled = true;
                    this.txtEquivalencia.Enabled = true;
                    this.cmbTipoUnidad.Enabled = true;
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
                    this.txtID.Enabled = true;
                    this.txtDescripcion.Enabled = false;
                    this.txtAbreviatura.Enabled = false;
                    this.txtEquivalencia.Enabled = false;
                    this.cmbTipoUnidad.Enabled = false;
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
                    //
                    this.txtID.Enabled = true;
                    this.txtDescripcion.Enabled = false;
                    this.txtAbreviatura.Enabled = false;
                    this.txtEquivalencia.Enabled = false;
                    this.cmbTipoUnidad.Enabled = false;
                    break;

                default:
                    break;
            }

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
                MyCommand.CommandText = "SELECT count(*) FROM unidadmedidas";

                // Step 4 - Open connection
                MyConexion.Open();

                // Step 5 - Execute the SQL Statement y Asigno el valor resultante a la variable "codigo"
                int codigo;
                codigo = Convert.ToInt32(MyCommand.ExecuteScalar());
                codigo = codigo + 1;
                txtID.Text = Convert.ToString(codigo);
                txtDescripcion.Focus();

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
            this.Limpiar();
            this.Botones();
            this.ProximoCodigo();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("No se permite guardar con campos en blancos...");
                txtDescripcion.Focus();
            }
            else if (txtAbreviatura.Text == "")
            {
                MessageBox.Show("No se permite guardar con campos en blancos...");
                txtAbreviatura.Focus();
            }
            else
            {
                if (cModo == "Nuevo")
                {
                    try
                    {
                        // Step 1 - Creating the connection
                        MySqlConnection myConexion = new MySqlConnection(Conexion.ConectionString);

                        // Step 2 - Crear el comando de ejecucion
                        MySqlCommand myCommand = myConexion.CreateCommand();

                        // Step 3 - Comando a ejecutar
                        myCommand.CommandText = "INSERT INTO unidadmedidas(desc_unidad, abreviatura, equivalencia, tipounidad)"+
                            " values(@descripcion, @abreviatura, @equivalencia, @tipounidad)";
                        myCommand.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                        myCommand.Parameters.AddWithValue("@abreviatura", txtAbreviatura.Text);
                        myCommand.Parameters.AddWithValue("@equivalencia", txtEquivalencia.Text);
                        myCommand.Parameters.AddWithValue("@tipounidad", cmbTipoUnidad.SelectedValue);

                        // Step 4  - Abro la conexion
                        myConexion.Open();

                        // Step 5 - Ejecuto el query
                        myCommand.ExecuteNonQuery();

                        // Step 6 - Cierro conexion
                        myConexion.Close();
                        myCommand.Dispose();

                        MessageBox.Show("Informacion guardada exitosamente...");
                        this.Limpiar();
                    }
                    catch (Exception myEx)
                    {
                        MessageBox.Show(myEx.Message);
                        throw;
                    }
                }
                else
                {
                    try
                    {
                        // Step 1 - Creating the connection
                        MySqlConnection myConexion = new MySqlConnection(Conexion.ConectionString);

                        // Step 2 - Crear el comando de ejecucion
                        MySqlCommand myCommand = myConexion.CreateCommand();

                        // Step 3 - Comando a ejecutar
                        myCommand.CommandText = "UPDATE unidadmedidas SET desc_unidad = @descripcion," +
                            "abreviatura = @abreviatura, equivalencia = @equivalencia, tipounidad = @tipounidad"+
                            " WHERE id_unidad =" + txtID.Text + "";
                        myCommand.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                        myCommand.Parameters.AddWithValue("@abreviatura", txtAbreviatura.Text);
                        myCommand.Parameters.AddWithValue("@equivalencia", txtEquivalencia.Text);
                        myCommand.Parameters.AddWithValue("@tipounidad", cmbTipoUnidad.SelectedValue);

                        // Step 4  - Abro la conexion
                        myConexion.Open();

                        // Step 5 - Ejecuto el query
                        myCommand.ExecuteNonQuery();

                        // Step 6 - Cierro conexion
                        myConexion.Close();
                        myCommand.Dispose();

                        MessageBox.Show("Informacion actualizada exitosamente...");                        
                    }
                    catch (Exception myEx)
                    {
                        MessageBox.Show(myEx.Message);
                        throw;
                    }
                }

                this.Limpiar();
                this.cModo = "Inicio";
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
                    MyCommand.CommandText = "SELECT desc_unidad, abreviatura, equivalencia, tipounidad"+
                        " FROM unidadmedidas WHERE id_unidad = " + txtID.Text + "";

                    // Step 4 - connection open
                    MyConexion.Open();

                    // Step 5 - Creating the DataReader                    
                    MySqlDataReader MyReader = MyCommand.ExecuteReader();

                    // Step 6 - Verifying if Reader has rows
                    if (MyReader.HasRows)
                    {
                        while (MyReader.Read())
                        {
                            txtDescripcion.Text = MyReader["desc_unidad"].ToString();
                            txtAbreviatura.Text = MyReader["abreviatura"].ToString();
                            txtEquivalencia.Text = MyReader["equivalencia"].ToString();
                            cmbTipoUnidad.SelectedValue = MyReader["tipounidad"].ToString();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
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
            string cUsuario = "";
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
                sbQuery.Append("SELECT unidadmedidas.id_unidad as ID, unidadmedidas.desc_unidad as Descripcion,");
                sbQuery.Append(" unidadmedidas.abreviatura as Abreviatura, unidades.descripcion as TipoUnidad");
                //sbQuery.Append(" doctores.doctores_cedula,upper(CONCAT(doctores.doctores_nombre,' ',doctores.doctores_apellido)) as doctor,departamentos.departamento_descripcion");
                sbQuery.Append(" FROM unidadmedidas");
                sbQuery.Append(" INNER JOIN unidades ON unidades.idunidades = unidadmedidas.tipounidad");
                sbQuery.Append(cWhere);

                // Paso los valores de sbQuery al CommandText
                myCommand.CommandText = sbQuery.ToString();

                // Creo el objeto Data Adapter y ejecuto el command en el
                myAdapter = new MySqlDataAdapter(myCommand);

                // Creo el objeto Data Table
                DataTable dtUnidadesMedidas = new DataTable();

                // Lleno el data adapter
                myAdapter.Fill(dtUnidadesMedidas);

                // Cierro el objeto clsConexion
                myclsConexion.Close();

                // Verifico cantidad de datos encontrados
                int nRegistro = dtUnidadesMedidas.Rows.Count;
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
                    cTitulo = "LISTADO DE UNIDADES DE MEDIDAS";

                    //6to Instanciamos nuestro REPORTE
                    //Reportes.ListadoDoctores oListado = new Reportes.ListadoDoctores();
                    REPORTES.rptUnidadesMedidas orptUnidadesMedidas = new REPORTES.rptUnidadesMedidas();
                    //pasamos el nombre del TITULO del Listado
                    //SumaryInfo es un objeto que se utiliza para leer,crear y actualizar las propiedades del reporte
                    // oListado.SummaryInfo.ReportTitle = cTitulo;
                    orptUnidadesMedidas.SummaryInfo.ReportTitle = cTitulo;

                    //7mo. instanciamos nuestro el FORMULARIO donde esta nuestro ReportViewer
                    frmPrinter ofrmPrinter = new frmPrinter(dtUnidadesMedidas, orptUnidadesMedidas, cTitulo);
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

    }
}
