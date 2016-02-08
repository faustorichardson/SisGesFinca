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
    public partial class frmPrintUnidadesMedidas : frmBase
    {
        public frmPrintUnidadesMedidas()
        {
            InitializeComponent();
        }

        private void frmPrintUnidadesMedidas_Load(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            // Declarando la variable SQL
            string sqlUnidadesMedidas = "SELECT * FROM unidadmedidas";

            // Declarando el Dataset
            dsUnidadesMedidas dsUnidades = new dsUnidadesMedidas();

            try
            {
                // Creo el objeto conexion
                MySqlConnection myConexion = new MySqlConnection(Conexion.ConectionString);

                // Creando los Data Adapters
                MySqlDataAdapter myDAUnidades = new MySqlDataAdapter(sqlUnidadesMedidas, myConexion);

                // Poblamos las tablas del DataSet Tipado
                myDAUnidades.Fill(dsUnidades, "unidadmedidas");

                // Poblando el Reporte
                REPORTES.rptUnidadesMedidas Informe = new REPORTES.rptUnidadesMedidas();
                Informe.SetDataSource(dsUnidades);
                crystalReportViewer1.ReportSource = Informe;
            }
            catch (Exception myEx)
            {
                MessageBox.Show(myEx.Message);
                throw;
            }
        }
    }
}
