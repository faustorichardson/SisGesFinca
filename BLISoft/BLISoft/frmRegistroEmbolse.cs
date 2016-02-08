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
    public partial class frmRegistroEmbolse : frmBase
    {
        // Declaro la variable para el uso de los Botones
        string cModo = "Inicio";
        string colorCinta;

        public frmRegistroEmbolse()
        {
            InitializeComponent();
        }

        private void frmRegistroEmbolse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bliDSCamposGridView.campos' table. You can move, or remove it, as needed.
            this.camposTableAdapter.Fill(this.bliDSCamposGridView.campos);
            // TODO: This line of code loads data into the 'bliDSCamposGridView.campos' table. You can move, or remove it, as needed.
            //this.camposTableAdapter.Fill(this.bliDSCamposGridView.campos);

            // LLENAR COMBO COLOR CINTA
            this.fillColorCinta();

            // Limpiando los valores del grid
            this.Limpiar();
            // Inicializando los botones
            this.cModo = "Inicio";
            this.botones();
        }

        private void fillColorCinta() 
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

        private void botones()
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
                    this.txtSemana.Enabled = false;
                    this.txtCmp1.Enabled = false;
                    this.txtCmp2.Enabled = false;
                    this.txtCmp3.Enabled = false;
                    this.txtCmp4.Enabled = false;
                    this.txtCmp5.Enabled = false;
                    this.txtCmp6.Enabled = false;
                    this.txtCmp7.Enabled = false;
                    this.txtCmp8.Enabled = false;
                    this.txtCmp9.Enabled = false;
                    this.txtCmp10.Enabled = false;
                    this.txtCmp11.Enabled = false;
                    this.txtCmp12.Enabled = false;
                    this.txtCmp13.Enabled = false;
                    this.txtCmp14.Enabled = false;
                    this.txtCmp15.Enabled = false;
                    this.txtCmp16.Enabled = false;
                    this.cmbColorCinta.Enabled = false;
                    this.txtRegistro.Enabled = true;
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
                    this.txtSemana.Enabled = true;                    
                    this.txtCmp1.Enabled = true;
                    this.txtCmp2.Enabled = true;
                    this.txtCmp3.Enabled = true;
                    this.txtCmp4.Enabled = true;
                    this.txtCmp5.Enabled = true;
                    this.txtCmp6.Enabled = true;
                    this.txtCmp7.Enabled = true;
                    this.txtCmp8.Enabled = true;
                    this.txtCmp9.Enabled = true;
                    this.txtCmp10.Enabled = true;
                    this.txtCmp11.Enabled = true;
                    this.txtCmp12.Enabled = true;
                    this.txtCmp13.Enabled = true;
                    this.txtCmp14.Enabled = true;
                    this.txtCmp15.Enabled = true;
                    this.txtCmp16.Enabled = true;
                    this.cmbColorCinta.Enabled = true;
                    this.txtRegistro.Enabled = false;
                    break;

                case "Grabar":
                    this.btnNuevo.Enabled = true;
                    this.btnGrabar.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnBuscar.Enabled = true;
                    this.btnImprimir.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnSalir.Enabled = true;
                    //
                    this.txtSemana.Enabled = false;
                    this.txtCmp1.Enabled = false;
                    this.txtCmp2.Enabled = false;
                    this.txtCmp3.Enabled = false;
                    this.txtCmp4.Enabled = false;
                    this.txtCmp5.Enabled = false;
                    this.txtCmp6.Enabled = false;
                    this.txtCmp7.Enabled = false;
                    this.txtCmp8.Enabled = false;
                    this.txtCmp9.Enabled = false;
                    this.txtCmp10.Enabled = false;
                    this.txtCmp11.Enabled = false;
                    this.txtCmp12.Enabled = false;
                    this.txtCmp13.Enabled = false;
                    this.txtCmp14.Enabled = false;
                    this.txtCmp15.Enabled = false;
                    this.txtCmp16.Enabled = false;
                    this.cmbColorCinta.Enabled = false;
                    this.txtRegistro.Enabled = false;
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
                    this.txtSemana.Enabled = true;
                    this.txtCmp1.Enabled = true;
                    this.txtCmp2.Enabled = true;
                    this.txtCmp3.Enabled = true;
                    this.txtCmp4.Enabled = true;
                    this.txtCmp5.Enabled = true;
                    this.txtCmp6.Enabled = true;
                    this.txtCmp7.Enabled = true;
                    this.txtCmp8.Enabled = true;
                    this.txtCmp9.Enabled = true;
                    this.txtCmp10.Enabled = true;
                    this.txtCmp11.Enabled = true;
                    this.txtCmp12.Enabled = true;
                    this.txtCmp13.Enabled = true;
                    this.txtCmp14.Enabled = true;
                    this.txtCmp15.Enabled = true;
                    this.txtCmp16.Enabled = true;
                    this.cmbColorCinta.Enabled = true;
                    this.txtRegistro.Enabled = false;
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
                    this.txtSemana.Enabled = false;
                    this.txtCmp1.Enabled = false;
                    this.txtCmp2.Enabled = false;
                    this.txtCmp3.Enabled = false;
                    this.txtCmp4.Enabled = false;
                    this.txtCmp5.Enabled = false;
                    this.txtCmp6.Enabled = false;
                    this.txtCmp7.Enabled = false;
                    this.txtCmp8.Enabled = false;
                    this.txtCmp9.Enabled = false;
                    this.txtCmp10.Enabled = false;
                    this.txtCmp11.Enabled = false;
                    this.txtCmp12.Enabled = false;
                    this.txtCmp13.Enabled = false;
                    this.txtCmp14.Enabled = false;
                    this.txtCmp15.Enabled = false;
                    this.txtCmp16.Enabled = false;
                    this.cmbColorCinta.Enabled = false;
                    this.txtRegistro.Enabled = true;
                    break;

                case "Eliminar":
                    break;

                case "Cancelar":
                    this.btnNuevo.Enabled = true;
                    this.btnGrabar.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnBuscar.Enabled = true;
                    this.btnImprimir.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnSalir.Enabled = true;
                    break;

                default:
                    break;
            }

        }

        private void Limpiar()
        {
            this.txtRegistro.Clear();
            this.txtSemana.Clear();
            this.txtCmp1.Clear();
            this.txtCmp2.Clear();
            this.txtCmp3.Clear();
            this.txtCmp4.Clear();
            this.txtCmp5.Clear();
            this.txtCmp6.Clear();
            this.txtCmp7.Clear();
            this.txtCmp8.Clear();
            this.txtCmp9.Clear();
            this.txtCmp10.Clear();
            this.txtCmp11.Clear();
            this.txtCmp12.Clear();
            this.txtCmp13.Clear();
            this.txtCmp14.Clear();
            this.txtCmp15.Clear();
            this.txtCmp16.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.cModo = "Nuevo";
            this.botones();
            //this.BuscarColorCinta();
            this.ProximoCodigo();
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
                MyCommand.CommandText = "SELECT count(*) FROM embolse";

                // Step 4 - Open connection
                MyConexion.Open();

                // Step 5 - Execute the SQL Statement y Asigno el valor resultante a la variable "codigo"
                int codigo;
                codigo = Convert.ToInt32(MyCommand.ExecuteScalar());
                codigo = codigo + 1;
                txtRegistro.Text = Convert.ToString(codigo);
                txtRegistro.Focus();

                // Step 5 - Close the connection
                MyConexion.Close();
            }
            catch (MySqlException MyEx)
            {
                MessageBox.Show(MyEx.Message);
            }

        }

        private void BuscarColorCinta()
        {
            if (dtFecha.Text == "" || txtSemana.Text == "")
            {
                MessageBox.Show("No se permiten busquedas sin FECHA o SEMANA vacia...");
                txtSemana.Focus();
            }
            else
            {
                try
                {
                    // Step 1 - Conexion
                    MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

                    // Step 2 
                    MySqlCommand MyCommand = MyConexion.CreateCommand();

                    // Step 3
                    string myFecha = dtFecha.Value.ToString("yyyy-MM-dd");
                    MyCommand.CommandText = "SELECT colorencintado FROM calendarioencintado " +
                        "WHERE semana ="+ txtSemana.Text +"";
                    //MessageBox.Show(myFecha);
                    
                    // Step 4
                    MyConexion.Open();

                    // Step 5 - Creating the DataReader                    
                    MySqlDataReader MyReader = MyCommand.ExecuteReader();

                    // Step 6 - Verifying if Reader has rows                    
                    if (MyReader.HasRows)
                    {
                        while (MyReader.Read())
                        {
                            colorCinta = MyReader["colorencintado"].ToString();
                        }                        

                        if (colorCinta == "ROJA")
                        {
                            cmbColorCinta.SelectedValue = 1;
                        } else if(colorCinta == "NEGRA")
                        {
                            cmbColorCinta.SelectedValue = 2;
                        }
                        else if (colorCinta == "GRIS")
                        {
                            cmbColorCinta.SelectedValue = 3;
                        }
                        else if (colorCinta == "AZUL")
                        {
                            cmbColorCinta.SelectedValue = 4;
                        }
                        else if (colorCinta == "VERDE")
                        {
                            cmbColorCinta.SelectedValue = 5;
                        }
                        else if (colorCinta == "AMARILLA")
                        {
                            cmbColorCinta.SelectedValue = 6;
                        }
                        else if (colorCinta == "MARRON")
                        {
                            cmbColorCinta.SelectedValue = 7;
                        }
                        else if (colorCinta == "BLANCA")
                        {
                            cmbColorCinta.SelectedValue = 8;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha registrado esta fecha en el calendario de encintado...");
                        this.Limpiar();
                        this.cModo = "Inicio";
                        this.botones();
                    }
                    // Step 7
                    MyConexion.Close();
                    MyCommand.Dispose();
                }
                catch (Exception myEx)
                {
                    MessageBox.Show(myEx.Message);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.cModo = "Editar";
            this.botones();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtSemana.Text == "")
            {
                MessageBox.Show("No se puede guardar registro con el campo SEMANA vacio...");
                txtSemana.Focus();
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
                        myCommand.CommandText = "INSERT INTO embolse(fecha, semana, colorcinta, cmp1, cmp2, cmp3, cmp4, cmp5, cmp6," +
                            "cmp7, cmp8, cmp9, cmp10, cmp11, cmp12, cmp13, cmp14, cmp15, cmp16) values (@fecha, @semana, @colorcinta," +
                            "@cmp1, @cmp2, @cmp3, @cmp4, @cmp5, @cmp6, @cmp7, @cmp8, @cmp9, @cmp10, @cmp11, @cmp12, @cmp13, @cmp14,"+
                            "@cmp15, @cmp16)";
                        myCommand.Parameters.AddWithValue("@fecha", dtFecha.Value.ToString("yyyy-MM-dd"));
                        myCommand.Parameters.AddWithValue("@semana", txtSemana.Text);
                        myCommand.Parameters.AddWithValue("@colorcinta", cmbColorCinta.SelectedValue);
                        myCommand.Parameters.AddWithValue("@cmp1", txtCmp1.Text);
                        myCommand.Parameters.AddWithValue("@cmp2", txtCmp2.Text);
                        myCommand.Parameters.AddWithValue("@cmp3", txtCmp3.Text);
                        myCommand.Parameters.AddWithValue("@cmp4", txtCmp4.Text);
                        myCommand.Parameters.AddWithValue("@cmp5", txtCmp5.Text);
                        myCommand.Parameters.AddWithValue("@cmp6", txtCmp6.Text);
                        myCommand.Parameters.AddWithValue("@cmp7", txtCmp7.Text);
                        myCommand.Parameters.AddWithValue("@cmp8", txtCmp8.Text);
                        myCommand.Parameters.AddWithValue("@cmp9", txtCmp9.Text);
                        myCommand.Parameters.AddWithValue("@cmp10", txtCmp10.Text);
                        myCommand.Parameters.AddWithValue("@cmp11", txtCmp11.Text);
                        myCommand.Parameters.AddWithValue("@cmp12", txtCmp12.Text);
                        myCommand.Parameters.AddWithValue("@cmp13", txtCmp13.Text);
                        myCommand.Parameters.AddWithValue("@cmp14", txtCmp14.Text);
                        myCommand.Parameters.AddWithValue("@cmp15", txtCmp15.Text);
                        myCommand.Parameters.AddWithValue("@cmp16", txtCmp16.Text);

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
                        myCommand.CommandText = "UPDATE embolse SET fecha = @fecha, semana = @semana, colorcinta = @colorcinta," +
                            "cmp1 = @cmp1, cmp2 = @cmp2, cmp3 = @cmp3, cmp4 = @cmp4, cmp5 = @cmp5, cmp6 = @cmp6, cmp7 = @cmp7, " +
                            "cmp8 = @cmp8, cmp9 = @cmp9, cmp10 = @cmp10, cmp11 = @cmp11, cmp12 = @cmp12, cmp13 = @cmp13, cmp14 = @cmp14," +
                            "cmp15 = @cmp15, cmp16 = @cmp16 WHERE idembolse = " + txtRegistro.Text + "";
                        myCommand.Parameters.AddWithValue("@fecha", dtFecha.Value.ToString("yyyy-MM-dd"));
                        myCommand.Parameters.AddWithValue("@semana", txtSemana.Text);
                        myCommand.Parameters.AddWithValue("@colorcinta", cmbColorCinta.SelectedValue);
                        myCommand.Parameters.AddWithValue("@cmp1", txtCmp1.Text);
                        myCommand.Parameters.AddWithValue("@cmp2", txtCmp2.Text);
                        myCommand.Parameters.AddWithValue("@cmp3", txtCmp3.Text);
                        myCommand.Parameters.AddWithValue("@cmp4", txtCmp4.Text);
                        myCommand.Parameters.AddWithValue("@cmp5", txtCmp5.Text);
                        myCommand.Parameters.AddWithValue("@cmp6", txtCmp6.Text);
                        myCommand.Parameters.AddWithValue("@cmp7", txtCmp7.Text);
                        myCommand.Parameters.AddWithValue("@cmp8", txtCmp8.Text);
                        myCommand.Parameters.AddWithValue("@cmp9", txtCmp9.Text);
                        myCommand.Parameters.AddWithValue("@cmp10", txtCmp10.Text);
                        myCommand.Parameters.AddWithValue("@cmp11", txtCmp11.Text);
                        myCommand.Parameters.AddWithValue("@cmp12", txtCmp12.Text);
                        myCommand.Parameters.AddWithValue("@cmp13", txtCmp13.Text);
                        myCommand.Parameters.AddWithValue("@cmp14", txtCmp14.Text);
                        myCommand.Parameters.AddWithValue("@cmp15", txtCmp15.Text);
                        myCommand.Parameters.AddWithValue("@cmp16", txtCmp16.Text);

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
                this.cModo = "Inicio";
                this.botones();
            }
        }

        //private void fillSearchGrid()
        //{
        //    //// Conexion
        //    //MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

        //    //// creating the command object
        //    //MySqlCommand MyCommand = MyConexion.CreateCommand();

        //    //// creating the commandtext 
        //    //string myFecha = dtFecha.Value.ToString("yyyy-MM-dd");
        //    //MyCommand.CommandText = "SELECT campo, cantidadracimos FROM embolse " +
        //    //    "WHERE fecha = " + "'" + myFecha + "'" + "";

        //    //// connection open
        //    //MyConexion.Open();

        //    //// Creating the DataReader                    
        //    //MySqlDataReader MyReader = MyCommand.ExecuteReader();

        //    //// Creating my DataTable
        //    //DataTable myDataTable = new DataTable();
        //    //myDataTable.Load(MyReader);

        //    //foreach (DataRow registro in myDataTable.Rows)
        //    //{                
        //    //    grvCampos.Rows.Add(registro[0].ToString());
        //    //    grvCampos.Rows.Add(registro[1].ToString());
        //    //}

        //    //MyConexion.Close();
        //    //MyCommand.Dispose();

        //}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtRegistro.Text == "")
            {
                MessageBox.Show("No se puede realizar busqueda con fecha en blanco...");
                dtFecha.Focus();
            }
            else
            {
                try
                {

                    // Conexion
                    MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

                    // creating the command object
                    MySqlCommand MyCommand = MyConexion.CreateCommand();

                    // creating the commandtext                     
                    MyCommand.CommandText = "SELECT fecha, semana, colorcinta, cmp1, cmp2, cmp3, cmp4, cmp5, cmp6, cmp7, cmp8, cmp9," +
                        "cmp10, cmp11, cmp12, cmp13, cmp14, cmp15, cmp16 FROM embolse WHERE idembolse = '"+ txtRegistro.Text +"'";                    

                    // connection open
                    MyConexion.Open();

                    // Creating the DataReader                    
                    MySqlDataReader MyReader = MyCommand.ExecuteReader();

                    // Verifying if Reader has rows
                    if (MyReader.HasRows)
                    {
                        //int n = 0;
                        while (MyReader.Read())
                        {
                            dtFecha.Value = Convert.ToDateTime(MyReader["fecha"]);                            
                            txtSemana.Text = MyReader["semana"].ToString();
                            cmbColorCinta.SelectedValue = MyReader["colorcinta"].ToString();
                            txtCmp1.Text = MyReader["cmp1"].ToString();
                            txtCmp2.Text = MyReader["cmp2"].ToString();
                            txtCmp3.Text = MyReader["cmp3"].ToString();
                            txtCmp4.Text = MyReader["cmp4"].ToString();
                            txtCmp5.Text = MyReader["cmp5"].ToString();
                            txtCmp6.Text = MyReader["cmp6"].ToString();
                            txtCmp7.Text = MyReader["cmp7"].ToString();
                            txtCmp8.Text = MyReader["cmp8"].ToString();
                            txtCmp9.Text = MyReader["cmp9"].ToString();
                            txtCmp10.Text = MyReader["cmp10"].ToString();
                            txtCmp11.Text = MyReader["cmp11"].ToString();
                            txtCmp12.Text = MyReader["cmp12"].ToString();
                            txtCmp13.Text = MyReader["cmp13"].ToString();
                            txtCmp14.Text = MyReader["cmp14"].ToString();
                            txtCmp15.Text = MyReader["cmp15"].ToString();
                            txtCmp16.Text = MyReader["cmp16"].ToString();
                        }
                        
                        MyConexion.Close();
                        MyCommand.Dispose();
                       // fillSearchGrid();
                        this.cModo = "Buscar";
                        this.botones();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros...");
                        this.cModo = "Inicio";
                        this.botones();
                        this.Limpiar();
                    }
                }
                catch (Exception myEx)
                {
                    MessageBox.Show(myEx.Message);                    
                }
            }
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtSemana.Text != "")
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
            this.botones();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmGnrRptEmbolse ofrmGnrRptEmbolse = new frmGnrRptEmbolse();
            ofrmGnrRptEmbolse.ShowDialog();
        }
    }
}
