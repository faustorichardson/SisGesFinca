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
    public partial class frmGnrRptSuplidores : frmBase
    {
        public frmGnrRptSuplidores()
        {
            InitializeComponent();
        }

        private void frmGnrRptSuplidores_Load(object sender, EventArgs e)
        {
            fillComboProvincia();            
            rbTodos.Checked = true;
            cmbProvincia.Enabled = false;
        }

        private void verificaCombo()
        {
            if (rbTodos.Checked)
            {
                cmbProvincia.Enabled = false;
            }
            else if (rbPorProvincias.Checked)
            {
                cmbProvincia.Enabled = true;
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
            string cUsuario = ""; //frmLogin.cUsuarioActual;
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
                if (rbTodos.Checked)
                {                
                    // CREANDO EL QUERY DE CONSULTA
                    sbQuery.Clear();
                    sbQuery.Append("SELECT suplidores.idsuplidores,suplidores.nombre,suplidores.razonsocial,suplidores.marca,suplidores.rnc,");
                    sbQuery.Append(" suplidores.telefono,suplidores.fax,suplidores.direccion,provincias.provincia,suplidores.correo,");
                    sbQuery.Append(" suplidores.contacto,suplidores.telcontacto,suplidores.extension,suplidores.correocontacto,");
                    sbQuery.Append(" suplidores.celcontacto,suplidores.telefono2");                    
                    //sbQuery.Append(" doctores.doctores_cedula,upper(CONCAT(doctores.doctores_nombre,' ',doctores.doctores_apellido)) as doctor,departamentos.departamento_descripcion");
                    sbQuery.Append(" FROM suplidores");
                    sbQuery.Append(" INNER JOIN provincias ON provincias.idprovincia = suplidores.provincia");
                    sbQuery.Append(cWhere);
                }
                else if (rbPorProvincias.Checked)
                {                    
                    // CREANDO EL QUERY DE CONSULTA
                    cWhere = cWhere + " AND suplidores.provincia= "+ cmbProvincia.SelectedValue + "";
                    //cWhere = cWhere + " AND year = '" + txtYear.Text + "'";
                    sbQuery.Clear();
                    sbQuery.Append("SELECT suplidores.idsuplidores,suplidores.nombre,suplidores.razonsocial,suplidores.marca,suplidores.rnc,");
                    sbQuery.Append(" suplidores.telefono,suplidores.fax,suplidores.direccion,provincias.provincia,suplidores.correo,");
                    sbQuery.Append(" suplidores.contacto,suplidores.telcontacto,suplidores.extension,suplidores.correocontacto,");
                    sbQuery.Append(" suplidores.celcontacto,suplidores.telefono2");
                    //sbQuery.Append(" doctores.doctores_cedula,upper(CONCAT(doctores.doctores_nombre,' ',doctores.doctores_apellido)) as doctor,departamentos.departamento_descripcion");
                    sbQuery.Append(" FROM suplidores");
                    sbQuery.Append(" INNER JOIN provincias ON provincias.idprovincia = suplidores.provincia");
                    sbQuery.Append(cWhere);
                }
                else
                {
                    MessageBox.Show("No se pueden generar reportes sin haber seleccionado un criterio...");
                }

                // Paso los valores de sbQuery al CommandText
                myCommand.CommandText = sbQuery.ToString();

                // Creo el objeto Data Adapter y ejecuto el command en el
                myAdapter = new MySqlDataAdapter(myCommand);

                // Creo el objeto Data Table
                DataTable dtSuplidores = new DataTable();

                // Lleno el data adapter
                myAdapter.Fill(dtSuplidores);

                // Cierro el objeto clsConexion
                myclsConexion.Close();

                // Verifico cantidad de datos encontrados
                int nRegistro = dtSuplidores.Rows.Count;
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
                    cTitulo = "REPORTE LISTADO DE SUPLIDORES";

                    //6to Instanciamos nuestro REPORTE
                    //Reportes.ListadoDoctores oListado = new Reportes.ListadoDoctores();
                    REPORTES.rptSuplidores orptSuplidores = new REPORTES.rptSuplidores();
                    //pasamos el nombre del TITULO del Listado
                    //SumaryInfo es un objeto que se utiliza para leer,crear y actualizar las propiedades del reporte
                    // oListado.SummaryInfo.ReportTitle = cTitulo;
                    orptSuplidores.SummaryInfo.ReportTitle = cTitulo;

                    //7mo. instanciamos nuestro el FORMULARIO donde esta nuestro ReportViewer
                    frmPrinter ofrmPrinter = new frmPrinter(dtSuplidores, orptSuplidores, cTitulo);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            cmbProvincia.Enabled = false;
        }

        private void rbPorProvincias_CheckedChanged(object sender, EventArgs e)
        {
            cmbProvincia.Enabled = true;
        }


    }
}
