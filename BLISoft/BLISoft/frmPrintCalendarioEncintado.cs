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


namespace BLISoft
{
    public partial class frmPrintCalendarioEncintado : Form
    {
        public int searchYear;

        public frmPrintCalendarioEncintado()
        {
            InitializeComponent();
        }

        private void frmPrintCalendarioEncintado_Load(object sender, EventArgs e)
        {            
            //string year = Convert.ToString(theYear);
            //MessageBox.Show(year);
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            // Paso el valor de la variable que traspaso al search
            string theYear = Convert.ToString(searchYear);

            // Defino variables y sentencias a ejecutar
            string mySqlStatement = "SELECT year, semana, fechadesde, fechahasta, colorencintado, colorcosecha, " +
                " sem10, sem11, sem12, sem13 FROM calendarioencintado WHERE year = " + "'" + theYear + "'" +"";

            // Defino el DataSet            
            dsCalendarioCosecha myDsCalendarioCosecha = new dsCalendarioCosecha();

            try
            {
                // Conexion
                MySqlConnection myConexion = new MySqlConnection(Conexion.ConectionString);

                // Creo los Data Adapters
                MySqlDataAdapter myDACalendarioCosecha = new MySqlDataAdapter(mySqlStatement, myConexion);

                // Llenando las tablas de Dataset Tipados                
                myDACalendarioCosecha.Fill(myDsCalendarioCosecha, "CalendarioEncintado");

                // Generamos el Reporte
                rptCalendarioEncintado informe = new rptCalendarioEncintado();
                informe.SetDataSource(myDsCalendarioCosecha);
                crViewer.ReportSource = informe;
            }
            catch (Exception myEx)
            {
                MessageBox.Show(myEx.Message);
            }

        }
    }


}
