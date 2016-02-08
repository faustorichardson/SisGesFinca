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
    public partial class frmPrintCampos : Form
    {
        public frmPrintCampos()
        {
            InitializeComponent();
        }

        private void GenerarReporte()
        {
            // Defino variables y sentencias a ejecutar
            string mySqlStatement = "SELECT id_campo, desc_campo, areacampo, areasembrada, unidad, "+
                "lineas, plantas, aspersores, mangueras FROM campos";

            // Defino el DataSet
            dsCampos myDsCampos = new dsCampos();

            try
            {
                // Conexion
                MySqlConnection myConexion = new MySqlConnection(Conexion.ConectionString);
                
                // Creo los Data Adapters
                MySqlDataAdapter myDACampos = new MySqlDataAdapter(mySqlStatement, myConexion);

                // Llenando las tablas de Dataset Tipados
                myDACampos.Fill(myDsCampos, "dtCampos");

                // Generamos el Reporte
                rptCampos informe = new rptCampos();
                informe.SetDataSource(myDsCampos);
                crViewer.ReportSource = informe;
            }
            catch (Exception myEx)
            {
                MessageBox.Show(myEx.Message);
            }

        }

        private void frmPrintCampos_Load(object sender, EventArgs e)
        {
            GenerarReporte();
        }
    }
}
