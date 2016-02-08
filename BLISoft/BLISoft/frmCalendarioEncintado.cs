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
    public partial class frmCalendarioEncintado : frmBase
    {
        string cModo = "Inicio";

        public frmCalendarioEncintado()
        {
            InitializeComponent();

        }

        private void frmCalendarioEncintado_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            cModo = "Inicio";
            this.Botones();            
            fillComboEncintado();
            fillComboCosecha();
            fillComboSem10();
            fillComboSem11();
            fillComboSem12();
            fillComboSem13();
            this.txtRegistro.Clear();
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
                MyCommand.CommandText = "SELECT count(*) FROM calendarioencintado";

                // Step 4 - Open connection
                MyConexion.Open();

                // Step 5 - Execute the SQL Statement y Asigno el valor resultante a la variable "codigo"
                int codigo;
                codigo = Convert.ToInt32(MyCommand.ExecuteScalar());
                codigo = codigo + 1;
                txtRegistro.Text = Convert.ToString(codigo);
                txtYear.Focus();

                // Step 5 - Close the connection
                MyConexion.Close();
            }
            catch (MySqlException MyEx)
            {
                MessageBox.Show(MyEx.Message);
            }

        }

        private void fillComboEncintado()
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
            MyDataTable.Columns.Add("color", typeof(string));
            MyDataTable.Load(MyReader);

            // Step 6
            this.cmbColorCinta.ValueMember = "color";
            this.cmbColorCinta.DisplayMember = "color";
            this.cmbColorCinta.DataSource = MyDataTable;

            // Step 7
            MyConexion.Close();
        }

        private void fillComboCosecha()
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
            MyDataTable.Columns.Add("color", typeof(string));            
            MyDataTable.Load(MyReader);

            // Step 6
            this.cmbColorCosecha.ValueMember = "color";
            this.cmbColorCosecha.DisplayMember = "color";
            this.cmbColorCosecha.DataSource = MyDataTable;

            // Step 7
            MyConexion.Close();

        }

        private void fillComboSem10()
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
            MyDataTable.Columns.Add("color", typeof(string));            
            MyDataTable.Load(MyReader);

            // Step 6
            this.cmbSem10.ValueMember = "color";
            this.cmbSem10.DisplayMember = "color";
            this.cmbSem10.DataSource = MyDataTable;

            // Step 7
            MyConexion.Close();

        }

        private void fillComboSem11()
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
            MyDataTable.Columns.Add("color", typeof(string));
            MyDataTable.Load(MyReader);

            // Step 6
            this.cmbSem11.ValueMember = "color";
            this.cmbSem11.DisplayMember = "color";
            this.cmbSem11.DataSource = MyDataTable;

            // Step 7
            MyConexion.Close();

        }

        private void fillComboSem12()
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
            MyDataTable.Columns.Add("color", typeof(string));
            MyDataTable.Load(MyReader);

            // Step 6
            this.cmbSem12.ValueMember = "color";
            this.cmbSem12.DisplayMember = "color";
            this.cmbSem12.DataSource = MyDataTable;

            // Step 7
            MyConexion.Close();

        }

        private void fillComboSem13()
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
            MyDataTable.Columns.Add("color", typeof(string));
            MyDataTable.Load(MyReader);

            // Step 6
            this.cmbSem13.ValueMember = "color";
            this.cmbSem13.DisplayMember = "color";
            this.cmbSem13.DataSource = MyDataTable;

            // Step 7
            MyConexion.Close();

        }


        private void Limpiar()
        {
            this.txtYear.Clear();
            this.txtSemana.Clear();
            this.fillComboEncintado();
            this.fillComboCosecha();
            this.fechaDesde.ResetText();
            this.fechaHasta.ResetText();
            this.txtRegistro.Clear();
            this.txtYear.Focus();
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
                    this.txtRegistro.Enabled = false;
                    this.txtYear.ReadOnly = false;
                    this.txtSemana.ReadOnly = false;
                    this.fechaDesde.Enabled = false;
                    this.fechaHasta.Enabled = false;
                    this.cmbColorCinta.Enabled = false;
                    this.cmbColorCosecha.Enabled = false;
                    this.cmbSem10.Enabled = false;
                    this.cmbSem11.Enabled = false;
                    this.cmbSem12.Enabled = false;
                    this.cmbSem13.Enabled = false;
                    this.txtYear.Focus();
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
                    this.txtRegistro.Enabled = false;
                    this.txtYear.ReadOnly = false;
                    this.txtSemana.ReadOnly = false;
                    this.fechaDesde.Enabled = true;
                    this.fechaHasta.Enabled = true;
                    this.cmbColorCinta.Enabled = true;
                    this.cmbColorCosecha.Enabled = true;
                    this.cmbSem10.Enabled = true;
                    this.cmbSem11.Enabled = true;
                    this.cmbSem12.Enabled = true;
                    this.cmbSem13.Enabled = true;
                    this.txtYear.Focus();
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
                    this.txtRegistro.Enabled = false;
                    this.txtYear.ReadOnly = true;
                    this.txtSemana.ReadOnly = true;
                    this.fechaDesde.Enabled = false;
                    this.fechaHasta.Enabled = false;
                    this.cmbColorCinta.Enabled = false;
                    this.cmbColorCosecha.Enabled = false;
                    this.cmbSem10.Enabled = false;
                    this.cmbSem11.Enabled = false;
                    this.cmbSem12.Enabled = false;
                    this.cmbSem13.Enabled = false;
                    break;

                case "Editar":
                    this.btnNuevo.Enabled = false;
                    this.btnGrabar.Enabled = true;
                    this.btnEditar.Enabled = false;
                    this.btnBuscar.Enabled = false;
                    this.btnImprimir.Enabled = false;
                    this.btnEliminar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    this.btnSalir.Enabled = true;
                    this.txtRegistro.Enabled = false;
                    this.txtYear.ReadOnly = false;
                    this.txtSemana.ReadOnly = false;
                    this.fechaDesde.Enabled = true;
                    this.fechaHasta.Enabled = true;
                    this.cmbColorCinta.Enabled = true;
                    this.cmbColorCosecha.Enabled = true;
                    this.cmbSem10.Enabled = true;
                    this.cmbSem11.Enabled = true;
                    this.cmbSem12.Enabled = true;
                    this.cmbSem13.Enabled = true;
                    break;

                case "Buscar":
                    this.btnNuevo.Enabled = true;
                    this.btnGrabar.Enabled = false;
                    this.btnEditar.Enabled = true;
                    this.btnBuscar.Enabled = true;
                    this.btnImprimir.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnSalir.Enabled = true;
                    this.txtRegistro.Enabled = false;
                    this.txtYear.ReadOnly = false;
                    this.txtSemana.ReadOnly = false;
                    this.fechaDesde.Enabled = false;
                    this.fechaHasta.Enabled = false;
                    this.cmbColorCinta.Enabled = false;
                    this.cmbColorCosecha.Enabled = false;
                    this.cmbSem10.Enabled = false;
                    this.cmbSem11.Enabled = false;
                    this.cmbSem12.Enabled = false;
                    this.cmbSem13.Enabled = false;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSemana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se aceptan numeros...");
                this.txtSemana.Focus();
                e.Handled = true;
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se aceptan numeros...");
                this.txtYear.Focus();
                e.Handled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {            
            this.Limpiar();            
            cModo = "Nuevo";
            this.Botones();
            ProximoCodigo();
            this.txtYear.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            if (txtYear.Text == "")
            {
                MessageBox.Show("No se permiten campos vacios...");
                this.txtYear.Focus();
            }

            if (txtSemana.Text == "")
            {
                MessageBox.Show("No se permiten campos vacios...");
                this.txtSemana.Focus();
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
                        myCommand.CommandText = "INSERT INTO calendarioencintado(year, semana, fechadesde, " +
                            "fechahasta, colorencintado, colorcosecha, sem10, sem11, sem12, sem13) values(@year, " +
                            "@semana, @fechadesde, @fechahasta, @colorencintado, @colorcosecha, @sem10, @sem11, " +
                            "@sem12, @sem13)";
                        myCommand.Parameters.AddWithValue("@year", txtYear.Text);
                        myCommand.Parameters.AddWithValue("@semana", txtSemana.Text);
                        myCommand.Parameters.AddWithValue("@fechadesde", fechaDesde.Value.ToString("yyyy-MM-dd"));
                        myCommand.Parameters.AddWithValue("@fechahasta", fechaHasta.Value.ToString("yyyy-MM-dd"));
                        myCommand.Parameters.AddWithValue("@colorencintado", cmbColorCinta.SelectedValue);
                        myCommand.Parameters.AddWithValue("@colorcosecha", cmbColorCosecha.SelectedValue);
                        myCommand.Parameters.AddWithValue("@sem10", cmbSem10.SelectedValue);
                        myCommand.Parameters.AddWithValue("@sem11", cmbSem11.SelectedValue);
                        myCommand.Parameters.AddWithValue("@sem12", cmbSem12.SelectedValue);
                        myCommand.Parameters.AddWithValue("@sem13", cmbSem13.SelectedValue);

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
                        myCommand.CommandText = "UPDATE calendarioencintado SET year = @year, " +
                            "semana = @semana, fechadesde = @fechadesde, fechahasta = @fechahasta, " +
                            "colorencintado = @colorencintado, colorcosecha = @colorcosecha, " +
                            "sem10 = @sem10, sem11 = @sem11, sem12 = @sem12, sem13 = @sem13 " +
                            "WHERE id = " + txtRegistro.Text + "";
                        myCommand.Parameters.AddWithValue("@year", txtYear.Text);
                        myCommand.Parameters.AddWithValue("@semana", txtSemana.Text);
                        myCommand.Parameters.AddWithValue("@fechadesde", fechaDesde.Value.ToString("yyyy-MM-dd"));
                        myCommand.Parameters.AddWithValue("@fechahasta", fechaHasta.Value.ToString("yyyy-MM-dd"));
                        myCommand.Parameters.AddWithValue("@colorencintado", cmbColorCinta.SelectedValue);
                        myCommand.Parameters.AddWithValue("@colorcosecha", cmbColorCosecha.SelectedValue);
                        myCommand.Parameters.AddWithValue("@sem10", cmbSem10.SelectedValue);
                        myCommand.Parameters.AddWithValue("@sem11", cmbSem11.SelectedValue);
                        myCommand.Parameters.AddWithValue("@sem12", cmbSem12.SelectedValue);
                        myCommand.Parameters.AddWithValue("@sem13", cmbSem13.SelectedValue);

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
                cModo = "Inicio";
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
            if (txtYear.Text == "")
            {
                MessageBox.Show("No se permiten busquedas sin Año asignado...");
                txtYear.Focus();
            } else if (txtSemana.Text == "")
            {
                MessageBox.Show("No se permiten busquedas sin Semana asignada...");
                txtSemana.Focus();
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
                    MyCommand.CommandText = "SELECT year, semana, fechadesde, fechahasta, colorencintado, colorcosecha," +
                        "sem10, sem11, sem12, sem13 FROM calendarioencintado " +
                        "WHERE year = " + txtYear.Text + " AND semana = " + txtSemana.Text + "";

                    // Step 4 - connection open
                    MyConexion.Open();

                    // Step 5 - Creating the DataReader                    
                    MySqlDataReader MyReader = MyCommand.ExecuteReader();

                    // Step 6 - Verifying if Reader has rows
                    if (MyReader.HasRows)
                    {
                        while (MyReader.Read())
                        {
                            txtYear.Text = MyReader["year"].ToString();
                            txtSemana.Text = MyReader["semana"].ToString();
                            fechaDesde.Value = Convert.ToDateTime(MyReader["fechadesde"]);
                            fechaHasta.Value = Convert.ToDateTime(MyReader["fechahasta"]);                            
                            cmbColorCinta.SelectedValue = MyReader["colorencintado"].ToString();
                            cmbColorCosecha.SelectedValue = MyReader["colorcosecha"].ToString();
                            cmbSem10.SelectedValue = MyReader["sem10"].ToString();
                            cmbSem11.SelectedValue = MyReader["sem11"].ToString();
                            cmbSem12.SelectedValue = MyReader["sem12"].ToString();
                            cmbSem13.SelectedValue = MyReader["sem13"].ToString();
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
                        this.txtYear.Focus();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se eliminan este tipo de datas...");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtSemana.Text != "" || txtYear.Text != "")
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmGnrRptCalendario ofrmGnrRptCalendario = new frmGnrRptCalendario();
            ofrmGnrRptCalendario.Show();
        }
    }
}