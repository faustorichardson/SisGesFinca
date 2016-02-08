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
    public partial class frmLogin : Form
    {
        int cont = 0;
        public static string cUsuarioActual = "";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {         
            // Step 1 - Creating the connection
            MySqlConnection myConexion = new MySqlConnection(Conexion.ConectionString);

            // Step 2 - Crear el comando de ejecucion
            MySqlCommand myCommand = myConexion.CreateCommand();

            // Step 3 - Comando a ejecutar
            myCommand.CommandText ="SELECT * FROM usuarios WHERE username ='"+ txtUser.Text.Trim() +"' AND userpass ='"+ txtPass.Text +"' ";

            // Step 4  - Abro la conexion
            myConexion.Open();

            // Step 5 - Ejecuto el query
            MySqlDataReader dr;
            dr = myCommand.ExecuteReader();
            
            // Conteo de rows encontradas
            int numberOfRows = 0;
            while (dr.Read())
            {
                numberOfRows += 1;
            }
            // Verifico los records que se han encontrado
            if (numberOfRows > 0)
            {
                lblPorcentaje.Visible = true;
                progressBar1.Visible = true;
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error de Acceso...");
                Limpiar();
                txtUser.Focus();
            }


            // Step 6 - Cierro conexion
            myConexion.Close();

        }

        private void Limpiar()
        {
            this.txtUser.Clear();
            this.txtPass.Clear();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {            
            this.cont = this.cont + 10;
            lblPorcentaje.Text = Convert.ToString(cont) + "%";
            progressBar1.Value = Convert.ToInt32(progressBar1.Value) + 10;
            if (Convert.ToInt32(progressBar1.Value) > 99)
            {
                timer1.Enabled = false;                
                this.Hide();
                frmMenu frmFormMenu = new frmMenu();
                // Le paso el usuario al frmMenu
                frmFormMenu.cUsuarioActual = txtUser.Text.Trim();
                cUsuarioActual = txtUser.Text.Trim();
                frmFormMenu.ShowDialog();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {            
            progressBar1.Visible = false;
            lblPorcentaje.Visible = false;
            this.Limpiar();
        }

    }
}
