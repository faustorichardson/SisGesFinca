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
    public partial class frmPrintCosecha : Form
    {
        public frmPrintCosecha()
        {
            InitializeComponent();
        }

        private void frmPrintCosecha_Load(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            // Defino variables y sentencias a ejecutar
            string sqlCosecha = "SELECT * FROM cosecha";
            string sqlCampo = "SELECT * FROM campos";

            // Defino el DataSet
            dsCosecha myDsCosecha = new dsCosecha();

            try
            {
                // Conexion
                MySqlConnection myConexion = new MySqlConnection(Conexion.ConectionString);

                // Creo los Data Adapters           
                MySqlDataAdapter myDaCampos = new MySqlDataAdapter(sqlCampo, myConexion);
                MySqlDataAdapter myDaCosecha = new MySqlDataAdapter(sqlCosecha, myConexion);                

                // Llenando las tablas de Dataset Tipados
                myDaCosecha.Fill(myDsCosecha, "dtCosecha");
                myDaCampos.Fill(myDsCosecha, "dtCampos");

                // Generamos el Reporte
                rptCosecha informe = new rptCosecha();                
                informe.SetDataSource(myDsCosecha);
                crViewer.ReportSource = informe;
            }
            catch (Exception myEx)
            {
                MessageBox.Show(myEx.Message);
            }        
        }
    }
}
