﻿using System;
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
//using VFPToolkit;


namespace BLISoft
{
    public partial class frmGnrRptCalendario : frmBase
    {
        public frmGnrRptCalendario()
        {
            InitializeComponent();
        }

        private void frmGnrRptCalendario_Load(object sender, EventArgs e)
        {
            Limpiar();
            
        }

        private void Limpiar()
        {
            txtYear.Clear();
            txtYear.Focus();
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
                if (txtYear.Text != "")
                {
                    // Habilitando los campos necesarios
                    txtYear.Enabled = true;
                    txtYear.Focus();

                    // CREANDO EL QUERY DE CONSULTA
                    //string fechadesde = fechaDesde.Value.ToString("yyyy-MM-dd");
                    //string fechahasta = fechaHasta.Value.ToString("yyyy-MM-dd");
                    //cWhere = cWhere + " AND fechacita >= "+"'"+ fechadesde +"'" +" AND fechacita <= "+"'"+ fechahasta +"'"+"";
                    cWhere = cWhere + " AND year = '"+ txtYear.Text +"'";
                    sbQuery.Clear();
                    sbQuery.Append("SELECT year, semana, fechadesde, fechahasta, colorencintado, colorcosecha, sem10, sem11, sem12, sem13");
                    //sbQuery.Append(" doctores.doctores_cedula,upper(CONCAT(doctores.doctores_nombre,' ',doctores.doctores_apellido)) as doctor,departamentos.departamento_descripcion");
                    sbQuery.Append(" FROM calendarioencintado");
                                        
                    //sbQuery.Append(" INNER JOIN departamentos ON departamentos.departamento_id = cita.referimiento");
                    sbQuery.Append(cWhere);

                    // Paso los valores de sbQuery al CommandText
                    myCommand.CommandText = sbQuery.ToString();

                    // Creo el objeto Data Adapter y ejecuto el command en el
                    myAdapter = new MySqlDataAdapter(myCommand);

                    // Creo el objeto Data Table
                    DataTable dtCalendario = new DataTable();

                    // Lleno el data adapter
                    myAdapter.Fill(dtCalendario);

                    // Cierro el objeto clsConexion
                    myclsConexion.Close();

                    // Verifico cantidad de datos encontrados
                    int nRegistro = dtCalendario.Rows.Count;
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
                        cTitulo = "CALENDARIO DE ENCINTADO";

                        //6to Instanciamos nuestro REPORTE
                        //Reportes.ListadoDoctores oListado = new Reportes.ListadoDoctores();
                        REPORTES.rptCalendario orptCalendario = new REPORTES.rptCalendario();

                        //pasamos el nombre del TITULO del Listado
                        //SumaryInfo es un objeto que se utiliza para leer,crear y actualizar las propiedades del reporte
                        // oListado.SummaryInfo.ReportTitle = cTitulo;
                        orptCalendario.SummaryInfo.ReportTitle = cTitulo;

                        //7mo. instanciamos nuestro el FORMULARIO donde esta nuestro ReportViewer
                        frmPrinter ofrmPrinter = new frmPrinter(dtCalendario, orptCalendario, cTitulo);

                        //ParameterFieldInfo Obtiene o establece la colección de campos de parámetros.                                                            
                        ofrmPrinter.CrystalReportViewer1.ParameterFieldInfo = oParametrosCR;
                        ofrmPrinter.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("No se puede realizar busqueda con campos vacios...");
                    txtYear.Focus();
                }

            }
            catch (Exception myEx)
            {
                MessageBox.Show("Error : " +  myEx.Message, "Mostrando Reporte", MessageBoxButtons.OK,
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
