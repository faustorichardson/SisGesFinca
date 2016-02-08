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
    public partial class frmGnrRptEmbolse : frmBase
    {
        public frmGnrRptEmbolse()
        {
            InitializeComponent();
        }

        private void frmGnrRptEmbolse_Load(object sender, EventArgs e)
        {
            fechaDesde.Enabled = false;
            fechaHasta.Enabled = false;
            cmbSemana.Enabled = false;
            cmbColorCinta.Enabled = false;
            fillComboColorCinta();
            fillComboSemana();
        }

        private void fillComboSemana()
        {
            // Step 1 
            MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

            // Step 2
            MyConexion.Open();

            // Step 3
            MySqlCommand MyCommand = new MySqlCommand("SELECT idsemana, semana FROM semanas", MyConexion);

            // Step 4
            MySqlDataReader MyReader;
            MyReader = MyCommand.ExecuteReader();

            // Step 5
            DataTable MyDataTable = new DataTable();
            MyDataTable.Columns.Add("idsemana", typeof(int));
            MyDataTable.Columns.Add("semana", typeof(string));
            MyDataTable.Load(MyReader);

            // Step 6
            cmbSemana.ValueMember = "idsemana";
            cmbSemana.DisplayMember = "semana";
            cmbSemana.DataSource = MyDataTable;

            // Step 7
            MyConexion.Close();
        }

        private void fillComboColorCinta()
        {
            // Step 1 
            MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

            // Step 2
            MyConexion.Open();

            // Step 3
            MySqlCommand MyCommand = new MySqlCommand("SELECT id_cinta, color FROM cintas ORDER BY color ASC", MyConexion);

            // Step 4
            MySqlDataReader MyReader;
            MyReader = MyCommand.ExecuteReader();

            // Step 5
            DataTable MyDataTable = new DataTable();
            MyDataTable.Columns.Add("id_cinta", typeof(int));
            MyDataTable.Columns.Add("color", typeof(string));
            MyDataTable.Load(MyReader);

            // Step 6
            cmbColorCinta.ValueMember = "id_cinta";
            cmbColorCinta.DisplayMember = "color";
            cmbColorCinta.DataSource = MyDataTable;

            // Step 7
            MyConexion.Close();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            fechaDesde.Enabled = false;
            fechaHasta.Enabled = false;
            cmbColorCinta.Enabled = false;
            cmbSemana.Enabled = false;
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            cmbColorCinta.Enabled = false;
            cmbSemana.Enabled = false;
            fechaDesde.Enabled = true;
            fechaHasta.Enabled = true;
            fechaDesde.Focus();
        }

        private void rbSemana_CheckedChanged(object sender, EventArgs e)
        {
            fechaHasta.Enabled = false;
            fechaDesde.Enabled = false;
            cmbColorCinta.Enabled = false;
            cmbSemana.Enabled = true;
            cmbSemana.Focus();
        }

        private void rbFechaCampo_CheckedChanged(object sender, EventArgs e)
        {
            cmbSemana.Enabled = false;
            fechaDesde.Enabled = true;
            fechaHasta.Enabled = true;
            cmbColorCinta.Enabled = true;
            fechaDesde.Focus();
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
                    //string fechadesde = fechaDesde.Value.ToString("yyyy-MM-dd");
                    //string fechahasta = fechaHasta.Value.ToString("yyyy-MM-dd");
                    //cWhere = cWhere + " AND fechacita >= "+"'"+ fechadesde +"'" +" AND fechacita <= "+"'"+ fechahasta +"'"+"";
                    //cWhere = cWhere + " AND year = '" + txtYear.Text + "'";
                    sbQuery.Clear();
                    sbQuery.Append("SELECT embolse.fecha, embolse.semana, cintas.color, embolse.cmp1, embolse.cmp2, embolse.cmp3,");
                    sbQuery.Append(" embolse.cmp4, embolse.cmp5, embolse.cmp6, embolse.cmp7, embolse.cmp8, embolse.cmp9, embolse.cmp10,");
                    sbQuery.Append(" embolse.cmp11, embolse.cmp12, embolse.cmp13, embolse.cmp14, embolse.cmp15, embolse.cmp16");                                                            
                    sbQuery.Append(" FROM embolse");
                    sbQuery.Append(" INNER JOIN cintas ON cintas.id_cinta = embolse.colorcinta");
                    sbQuery.Append(cWhere);
                }
                else if (rbFecha.Checked)
                {
                    // CREANDO EL QUERY DE CONSULTA
                    string fechadesde = fechaDesde.Value.ToString("yyyy-MM-dd");
                    string fechahasta = fechaHasta.Value.ToString("yyyy-MM-dd");
                    cWhere = cWhere + " AND fecha >= " + "'" + fechadesde + "'" + " AND fecha <= " + "'" + fechahasta + "'" + "";
                    //cWhere = cWhere + " AND year = '" + txtYear.Text + "'";
                    sbQuery.Clear();
                    sbQuery.Append("SELECT embolse.fecha, embolse.semana, cintas.color, embolse.cmp1, embolse.cmp2, embolse.cmp3,");
                    sbQuery.Append(" embolse.cmp4, embolse.cmp5, embolse.cmp6, embolse.cmp7, embolse.cmp8, embolse.cmp9, embolse.cmp10,");
                    sbQuery.Append(" embolse.cmp11, embolse.cmp12, embolse.cmp13, embolse.cmp14, embolse.cmp15, embolse.cmp16");
                    sbQuery.Append(" FROM embolse");
                    sbQuery.Append(" INNER JOIN cintas ON cintas.id_cinta = embolse.colorcinta");
                    sbQuery.Append(cWhere);
                }
                else if (rbSemana.Checked)
                {
                    // CREANDO EL QUERY DE CONSULTA
                    //DateTime year = fechaDesde.Value.Date.Year();
                    //cWhere = cWhere + " AND fechacorte >= " + "'" + fechadesde + "'" + " AND fechacorte <= " + "'" + fechahasta + "'" + "";                    
                    cWhere = cWhere + " AND semana = " + cmbSemana.SelectedValue + "";
                    sbQuery.Clear();
                    sbQuery.Append("SELECT embolse.fecha, embolse.semana, cintas.color, embolse.cmp1, embolse.cmp2, embolse.cmp3,");
                    sbQuery.Append(" embolse.cmp4, embolse.cmp5, embolse.cmp6, embolse.cmp7, embolse.cmp8, embolse.cmp9, embolse.cmp10,");
                    sbQuery.Append(" embolse.cmp11, embolse.cmp12, embolse.cmp13, embolse.cmp14, embolse.cmp15, embolse.cmp16");
                    sbQuery.Append(" FROM embolse");
                    sbQuery.Append(" INNER JOIN cintas ON cintas.id_cinta = embolse.colorcinta");
                    sbQuery.Append(cWhere);
                }
                else if (rbFechaCampo.Checked)
                {
                    // CREANDO EL QUERY DE CONSULTA
                    string fechadesde = fechaDesde.Value.ToString("yyyy-MM-dd");
                    string fechahasta = fechaHasta.Value.ToString("yyyy-MM-dd");
                    cWhere = cWhere + " AND fechacorte >= " + "'" + fechadesde + "'" + " AND fechacorte <= " + "'" + fechahasta + "'" + "";
                    cWhere = cWhere + " AND colorcinta = " + cmbColorCinta.SelectedValue + "";
                    sbQuery.Clear();
                    sbQuery.Append("SELECT embolse.fecha, embolse.semana, cintas.color, embolse.cmp1, embolse.cmp2, embolse.cmp3,");
                    sbQuery.Append(" embolse.cmp4, embolse.cmp5, embolse.cmp6, embolse.cmp7, embolse.cmp8, embolse.cmp9, embolse.cmp10,");
                    sbQuery.Append(" embolse.cmp11, embolse.cmp12, embolse.cmp13, embolse.cmp14, embolse.cmp15, embolse.cmp16");
                    sbQuery.Append(" FROM embolse");
                    sbQuery.Append(" INNER JOIN cintas ON cintas.id_cinta = embolse.colorcinta");
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
                DataTable dtEmbolse = new DataTable();

                // Lleno el data adapter
                myAdapter.Fill(dtEmbolse);

                // Cierro el objeto clsConexion
                myclsConexion.Close();

                // Verifico cantidad de datos encontrados
                int nRegistro = dtEmbolse.Rows.Count;
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
                    cTitulo = "REPORTE ESTADISTICOS DE LOS EMBOLSES";

                    //6to Instanciamos nuestro REPORTE
                    //Reportes.ListadoDoctores oListado = new Reportes.ListadoDoctores();
                    REPORTES.rptEmbolse orptEmbolse = new REPORTES.rptEmbolse();
                    //pasamos el nombre del TITULO del Listado
                    //SumaryInfo es un objeto que se utiliza para leer,crear y actualizar las propiedades del reporte
                    // oListado.SummaryInfo.ReportTitle = cTitulo;
                    orptEmbolse.SummaryInfo.ReportTitle = cTitulo;

                    //7mo. instanciamos nuestro el FORMULARIO donde esta nuestro ReportViewer
                    frmPrinter ofrmPrinter = new frmPrinter(dtEmbolse, orptEmbolse, cTitulo);
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
    }
}
