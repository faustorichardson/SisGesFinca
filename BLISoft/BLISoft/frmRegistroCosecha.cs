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
    public partial class frmRegistroCosecha : frmBase
    {
        string cModo = "Inicio";

        public frmRegistroCosecha()
        {
            InitializeComponent();            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Verifico de que los campos necesarios para la busqueda
            // no se encuentren vacios
            if (txtFechaCorte.Text == "")
            {
                MessageBox.Show("No se permite busqueda con FECHA EN BLANCO...");
                txtFechaCorte.Focus();
            } else if(txtSemana.Text == ""){
                MessageBox.Show("No se permite busqueda con SEMANA EN BLANCO...");
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
                    string fechaCorte = txtFechaCorte.Value.ToString("yyyy-MM-dd");
                    
                    MyCommand.CommandText = "SELECT idcosecha, fechacorte, semana, campo, cinta_verde, cinta_azul, cinta_amarilla, " +
                        "cinta_marron, cinta_gris, cinta_roja, cinta_blanca, cinta_negra, cantidadtotal, cinta_verdeR, cinta_azulR, cinta_amarillaR, "+
                        "cinta_marronR, cinta_grisR, cinta_rojaR, cinta_blancaR, cinta_negraR, cantidadrechazos FROM cosecha " +
                        "WHERE fechacorte =" + "'"+ fechaCorte +"'" + " AND semana = " + txtSemana.Text + " AND campo = " + cmbCampo.SelectedValue + "";

                    // Step 4 - connection open
                    MyConexion.Open();

                    // Step 5 - Creating the DataReader                    
                    MySqlDataReader MyReader = MyCommand.ExecuteReader();

                    // Step 6 - Verifying if Reader has rows
                    if (MyReader.HasRows)
                    {
                        while (MyReader.Read())
                        {                            
                          
                            txtRegistro.Text = Convert.ToString(MyReader["idcosecha"]);
                            txtFechaCorte.Value = Convert.ToDateTime(MyReader["fechacorte"]);
                            txtSemana.Text = MyReader["semana"].ToString();
                            cmbCampo.SelectedValue = MyReader["campo"].ToString();
                            txtColorVerde.Text = MyReader["cinta_verde"].ToString();
                            txtColorAzul.Text = MyReader["cinta_azul"].ToString();
                            txtColorAmarillo.Text = MyReader["cinta_amarilla"].ToString();
                            txtColorMarron.Text = MyReader["cinta_marron"].ToString();
                            txtColorGris.Text = MyReader["cinta_gris"].ToString();
                            txtColorRojo.Text = MyReader["cinta_roja"].ToString();
                            txtColorBlanco.Text = MyReader["cinta_blanca"].ToString();
                            txtColorNegro.Text = MyReader["cinta_negra"].ToString();
                            txtCantidadTotal.Text = MyReader["cantidadtotal"].ToString();
                            txtColorVerdeR.Text = MyReader["cinta_verdeR"].ToString();
                            txtColorAzulR.Text = MyReader["cinta_azulR"].ToString();
                            txtColorAmarilloR.Text = MyReader["cinta_amarillaR"].ToString();
                            txtColorMarronR.Text = MyReader["cinta_marronR"].ToString();
                            txtColorGrisR.Text = MyReader["cinta_grisR"].ToString();
                            txtColorRojoR.Text = MyReader["cinta_rojaR"].ToString();
                            txtColorBlancoR.Text = MyReader["cinta_blancaR"].ToString();
                            txtColorNegroR.Text = MyReader["cinta_negraR"].ToString();
                            txtCantidadTotalR.Text = MyReader["cantidadrechazos"].ToString();
                        }

                        this.cModo = "Buscar";
                        this.Botones();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros...");
                        this.Limpiar();
                        this.cModo = "Inicio";
                        this.Botones();                        
                        this.txtFechaCorte.Focus();
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
                    this.btnCalcular.Enabled = false;
                    this.txtRegistro.Enabled = false;
                    this.txtFechaCorte.Enabled = true;
                    this.txtSemana.Enabled = true;
                    this.cmbCampo.Enabled = true;
                    this.txtColorVerde.Enabled = false;
                    this.txtColorAzul.Enabled = false;
                    this.txtColorAmarillo.Enabled = false;
                    this.txtColorMarron.Enabled = false;
                    this.txtColorGris.Enabled = false;
                    this.txtColorRojo.Enabled = false;
                    this.txtColorBlanco.Enabled = false;
                    this.txtColorNegro.Enabled = false;
                    this.txtCantidadTotal.Enabled = false;
                    this.txtColorVerdeR.Enabled = false;
                    this.txtColorAzulR.Enabled = false;
                    this.txtColorAmarilloR.Enabled = false;
                    this.txtColorMarronR.Enabled = false;
                    this.txtColorGrisR.Enabled = false;
                    this.txtColorRojoR.Enabled = false;
                    this.txtColorBlancoR.Enabled = false;
                    this.txtColorNegroR.Enabled = false;
                    this.txtCantidadTotalR.Enabled = false;
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
                    this.btnCalcular.Enabled = true;
                    this.txtRegistro.Enabled = false;
                    this.txtFechaCorte.Enabled = true;
                    this.txtSemana.Enabled = true;
                    this.cmbCampo.Enabled = true;
                    this.txtColorVerde.Enabled = true;
                    this.txtColorAzul.Enabled = true;
                    this.txtColorAmarillo.Enabled = true;
                    this.txtColorMarron.Enabled = true;
                    this.txtColorGris.Enabled = true;
                    this.txtColorRojo.Enabled = true;
                    this.txtColorBlanco.Enabled = true;
                    this.txtColorNegro.Enabled = true;
                    this.txtCantidadTotal.Enabled = false;
                    this.txtColorVerdeR.Enabled = true;
                    this.txtColorAzulR.Enabled = true;
                    this.txtColorAmarilloR.Enabled = true;
                    this.txtColorMarronR.Enabled = true;
                    this.txtColorGrisR.Enabled = true;
                    this.txtColorRojoR.Enabled = true;
                    this.txtColorBlancoR.Enabled = true;
                    this.txtColorNegroR.Enabled = true;
                    this.txtCantidadTotalR.Enabled = false;
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
                    this.btnCalcular.Enabled = false;
                    this.txtRegistro.Enabled = false;
                    this.txtFechaCorte.Enabled = true;
                    this.txtSemana.Enabled = true;
                    this.cmbCampo.Enabled = true;
                    this.txtColorVerde.Enabled = false;
                    this.txtColorAzul.Enabled = false;
                    this.txtColorAmarillo.Enabled = false;
                    this.txtColorMarron.Enabled = false;
                    this.txtColorGris.Enabled = false;
                    this.txtColorRojo.Enabled = false;
                    this.txtColorBlanco.Enabled = false;
                    this.txtColorNegro.Enabled = false;
                    this.txtCantidadTotal.Enabled = false;
                    this.txtColorVerdeR.Enabled = false;
                    this.txtColorAzulR.Enabled = false;
                    this.txtColorAmarilloR.Enabled = false;
                    this.txtColorMarronR.Enabled = false;
                    this.txtColorGrisR.Enabled = false;
                    this.txtColorRojoR.Enabled = false;
                    this.txtColorBlancoR.Enabled = false;
                    this.txtColorNegroR.Enabled = false;
                    this.txtCantidadTotalR.Enabled = false;
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
                    this.btnCalcular.Enabled = true;
                    this.txtRegistro.Enabled = false;
                    this.txtFechaCorte.Enabled = true;
                    this.txtSemana.Enabled = true;
                    this.cmbCampo.Enabled = true;
                    this.txtColorVerde.Enabled = true;
                    this.txtColorAzul.Enabled = true;
                    this.txtColorAmarillo.Enabled = true;
                    this.txtColorMarron.Enabled = true;
                    this.txtColorGris.Enabled = true;
                    this.txtColorRojo.Enabled = true;
                    this.txtColorBlanco.Enabled = true;
                    this.txtColorNegro.Enabled = true;
                    this.txtCantidadTotal.Enabled = false;
                    this.txtColorVerdeR.Enabled = true;
                    this.txtColorAzulR.Enabled = true;
                    this.txtColorAmarilloR.Enabled = true;
                    this.txtColorMarronR.Enabled = true;
                    this.txtColorGrisR.Enabled = true;
                    this.txtColorRojoR.Enabled = true;
                    this.txtColorBlancoR.Enabled = true;
                    this.txtColorNegroR.Enabled = true;
                    this.txtCantidadTotalR.Enabled = false;
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
                    this.btnCalcular.Enabled = false;
                    this.txtRegistro.Enabled = false;
                    this.txtFechaCorte.Enabled = true;
                    this.txtSemana.Enabled = true;
                    this.cmbCampo.Enabled = true;
                    this.txtColorVerde.Enabled = false;
                    this.txtColorAzul.Enabled = false;
                    this.txtColorAmarillo.Enabled = false;
                    this.txtColorMarron.Enabled = false;
                    this.txtColorGris.Enabled = false;
                    this.txtColorRojo.Enabled = false;
                    this.txtColorBlanco.Enabled = false;
                    this.txtColorNegro.Enabled = false;
                    this.txtCantidadTotal.Enabled = false;
                    this.txtColorVerdeR.Enabled = false;
                    this.txtColorAzulR.Enabled = false;
                    this.txtColorAmarilloR.Enabled = false;
                    this.txtColorMarronR.Enabled = false;
                    this.txtColorGrisR.Enabled = false;
                    this.txtColorRojoR.Enabled = false;
                    this.txtColorBlancoR.Enabled = false;
                    this.txtColorNegroR.Enabled = false;
                    this.txtCantidadTotalR.Enabled = false;
                    break;

                case "Eliminar":
                    MessageBox.Show("En esta pantalla no se permiten eliminar registros...");
                    break;

                case "Cancelar":
                    this.btnNuevo.Enabled = true;
                    this.btnGrabar.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnBuscar.Enabled = true;
                    this.btnImprimir.Enabled = true;
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

        private void frmRegistroCosecha_Load(object sender, EventArgs e)
        {
            this.cModo = "Inicio";
            this.Botones();
            this.Limpiar();
            this.fillComboCampo();
        }

        private void fillComboCampo()
        {
            // Step 1 
            MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

            // Step 2
            MyConexion.Open();

            // Step 3
            MySqlCommand MyCommand = new MySqlCommand("SELECT id_campo, desc_campo FROM campos", MyConexion);

            // Step 4
            MySqlDataReader MyReader;
            MyReader = MyCommand.ExecuteReader();

            // Step 5
            DataTable MyDataTable = new DataTable();
            MyDataTable.Columns.Add("id_campo", typeof(int));
            MyDataTable.Columns.Add("desc_campo", typeof(string));
            MyDataTable.Load(MyReader);

            // Step 6
            cmbCampo.ValueMember = "id_campo";
            cmbCampo.DisplayMember = "desc_campo";
            cmbCampo.DataSource = MyDataTable;

            // Step 7
            MyConexion.Close();
        }

        private void Limpiar()
        {
            this.txtSemana.Clear();
            this.txtColorVerde.Clear();
            this.txtColorAzul.Clear();
            this.txtColorAmarillo.Clear();
            this.txtColorMarron.Clear();
            this.txtColorGris.Clear();
            this.txtColorRojo.Clear();
            this.txtColorBlanco.Clear();
            this.txtColorNegro.Clear();
            this.txtCantidadTotal.Clear();
            this.txtColorVerdeR.Clear();
            this.txtColorAzulR.Clear();
            this.txtColorAmarilloR.Clear();
            this.txtColorMarronR.Clear();
            this.txtColorGrisR.Clear();
            this.txtColorRojoR.Clear();
            this.txtColorBlancoR.Clear();
            this.txtColorNegroR.Clear();
            this.txtCantidadTotalR.Clear();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {                        

            if (txtFechaCorte.Text == "")
            {
                MessageBox.Show("No se puede guardar datos sin FECHA...");
                txtFechaCorte.Focus();
            } else if(txtSemana.Text == "")
            {
                MessageBox.Show("No se puede guardar datos sin SEMANA indicada...");
                txtSemana.Focus();
            }
            else if (txtCantidadTotal.Text == "")
            {
                MessageBox.Show("No se puede registrar datos con Total Racimos Cortados sin datos...");
                txtColorVerde.Focus();
            }
            else if (txtCantidadTotalR.Text == "")
            {
                MessageBox.Show("No se puede registrar datos con Total Rechazos Cortados sin datos...");
                txtColorVerdeR.Focus();
            }
            else
            {
                if (cModo == "Nuevo")
                {
                    try
                    {
                        // Mando a calcular Campos Total Racimos / Total Rechazos
                        btnCalcular_Click(sender, e);                        

                        // Step 1 - Stablishing the connection
                        MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

                        // Step 2 - Crear el comando de ejecucion
                        MySqlCommand myCommand = MyConexion.CreateCommand();

                        // Step 3 - Comando a ejecutar
                        myCommand.CommandText = "INSERT INTO cosecha(fechacorte, semana, campo, cinta_verde, cinta_azul, " +
                            "cinta_amarilla, cinta_marron, cinta_gris, cinta_roja, cinta_blanca, cinta_negra, cantidadtotal, " +
                            "cinta_verdeR, cinta_azulR, cinta_amarillaR, cinta_marronR, cinta_grisR, cinta_rojaR, cinta_blancaR, " +
                            "cinta_negraR, cantidadrechazos) VALUES(@fechacorte, @semana, @campo, @cinta_verde, @cinta_azul, @cinta_amarilla, @cinta_marron, " +
                            "@cinta_gris, @cinta_roja, @cinta_blanca, @cinta_negra, @cantidadtotal, @cinta_verdeR, @cinta_azulR, @cinta_amarillaR, " +
                            "@cinta_marronR, @cinta_grisR, @cinta_rojaR, @cinta_blancaR, @cinta_negraR, @cantidadrechazos)";
                        myCommand.Parameters.AddWithValue("@fechacorte", txtFechaCorte.Value.ToString("yyyy-MM-dd"));
                        myCommand.Parameters.AddWithValue("@semana", txtSemana.Text);
                        myCommand.Parameters.AddWithValue("@campo", cmbCampo.SelectedValue);
                        myCommand.Parameters.AddWithValue("@cinta_verde", txtColorVerde.Text);
                        myCommand.Parameters.AddWithValue("@cinta_azul", txtColorAzul.Text);
                        myCommand.Parameters.AddWithValue("@cinta_amarilla", txtColorAmarillo.Text);
                        myCommand.Parameters.AddWithValue("@cinta_marron", txtColorMarron.Text);
                        myCommand.Parameters.AddWithValue("@cinta_gris", txtColorGris.Text);
                        myCommand.Parameters.AddWithValue("@cinta_roja", txtColorRojo.Text);
                        myCommand.Parameters.AddWithValue("@cinta_blanca", txtColorBlanco.Text);
                        myCommand.Parameters.AddWithValue("@cinta_negra", txtColorNegro.Text);
                        myCommand.Parameters.AddWithValue("@cantidadtotal", txtCantidadTotal.Text);
                        myCommand.Parameters.AddWithValue("@cinta_verdeR", txtColorVerdeR.Text);
                        myCommand.Parameters.AddWithValue("@cinta_azulR", txtColorAzulR.Text);
                        myCommand.Parameters.AddWithValue("@cinta_amarillaR", txtColorAmarilloR.Text);
                        myCommand.Parameters.AddWithValue("@cinta_marronR", txtColorMarronR.Text);
                        myCommand.Parameters.AddWithValue("@cinta_grisR", txtColorGrisR.Text);
                        myCommand.Parameters.AddWithValue("@cinta_rojaR", txtColorRojoR.Text);
                        myCommand.Parameters.AddWithValue("@cinta_blancaR", txtColorBlancoR.Text);
                        myCommand.Parameters.AddWithValue("@cinta_negraR", txtColorNegroR.Text);
                        myCommand.Parameters.AddWithValue("@cantidadrechazos", txtCantidadTotalR.Text);

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
                        // Mando a calcular Campos Total Racimos / Total Rechazos
                        btnCalcular_Click(sender, e);
                        
                        // Step 1 - Stablishing the connection
                        MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

                        // Step 2 - Crear el comando de ejecucion
                        MySqlCommand myCommand = MyConexion.CreateCommand();

                        // Step 3 - Comando a ejecutar
                        myCommand.CommandText = "UPDATE cosecha SET fechacorte = @fechacorte, semana = @semana," +
                            "campo = @campo, cinta_verde = @cinta_verde, cinta_azul = @cinta_azul, cinta_amarilla = @cinta_amarilla," +
                            "cinta_marron = @cinta_marron, cinta_gris = @cinta_gris, cinta_roja = @cinta_roja," +
                            "cinta_blanca = @cinta_blanca, cinta_negra = @cinta_negra," +
                            "cinta_verdeR = @cinta_verdeR, cinta_azulR = @cinta_azulR, cinta_amarillaR = @cinta_amarillaR," +
                            "cinta_marronR = @cinta_marronR, cinta_grisR = @cinta_grisR, cinta_rojaR = @cinta_rojaR," +
                            "cinta_blancaR = @cinta_blancaR, cinta_negraR = @cinta_negraR," +
                            "cantidadtotal = @cantidadtotal, cantidadrechazos = @cantidadrechazos WHERE idcosecha = " + txtRegistro.Text + "";
                        myCommand.Parameters.AddWithValue("@fechacorte", txtFechaCorte.Value.ToString("yyyy-MM-dd"));
                        myCommand.Parameters.AddWithValue("@semana", txtSemana.Text);
                        myCommand.Parameters.AddWithValue("@campo", cmbCampo.SelectedValue);
                        myCommand.Parameters.AddWithValue("@cinta_verde", txtColorVerde.Text);
                        myCommand.Parameters.AddWithValue("@cinta_azul", txtColorAzul.Text);
                        myCommand.Parameters.AddWithValue("@cinta_amarilla", txtColorAmarillo.Text);
                        myCommand.Parameters.AddWithValue("@cinta_marron", txtColorMarron.Text);
                        myCommand.Parameters.AddWithValue("@cinta_gris", txtColorGris.Text);
                        myCommand.Parameters.AddWithValue("@cinta_roja", txtColorRojo.Text);
                        myCommand.Parameters.AddWithValue("@cinta_blanca", txtColorBlanco.Text);
                        myCommand.Parameters.AddWithValue("@cinta_negra", txtColorNegro.Text);
                        myCommand.Parameters.AddWithValue("@cantidadtotal", txtCantidadTotal.Text);
                        myCommand.Parameters.AddWithValue("@cinta_verdeR", txtColorVerdeR.Text);
                        myCommand.Parameters.AddWithValue("@cinta_azulR", txtColorAzulR.Text);
                        myCommand.Parameters.AddWithValue("@cinta_amarillaR", txtColorAmarilloR.Text);
                        myCommand.Parameters.AddWithValue("@cinta_marronR", txtColorMarronR.Text);
                        myCommand.Parameters.AddWithValue("@cinta_grisR", txtColorGrisR.Text);
                        myCommand.Parameters.AddWithValue("@cinta_rojaR", txtColorRojoR.Text);
                        myCommand.Parameters.AddWithValue("@cinta_blancaR", txtColorBlancoR.Text);
                        myCommand.Parameters.AddWithValue("@cinta_negraR", txtColorNegroR.Text);
                        myCommand.Parameters.AddWithValue("@cantidadrechazos", txtCantidadTotalR.Text);

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.ProximoCodigo();
            cModo = "Nuevo";
            this.Botones();
            this.txtSemana.Focus();
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
                MyCommand.CommandText = "SELECT count(*) FROM cosecha";

                // Step 4 - Open connection
                MyConexion.Open();

                // Step 5 - Execute the SQL Statement y Asigno el valor resultante a la variable "codigo"
                int codigo;
                codigo = Convert.ToInt32(MyCommand.ExecuteScalar());
                codigo = codigo + 1;
                txtRegistro.Text = Convert.ToString(codigo);

                // Step 5 - Close the connection
                MyConexion.Close();
            }
            catch (MySqlException MyEx)
            {
                MessageBox.Show(MyEx.Message);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtColorVerde.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorVerde.Focus();
            }
            else if (txtColorAzul.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorAzul.Focus();
            }
            else if (txtColorAmarillo.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorAmarillo.Focus();
            }
            else if (txtColorMarron.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorMarron.Focus();
            }
            else if (txtColorGris.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorGris.Focus();
            }
            else if (txtColorRojo.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorRojo.Focus();
            }
            else if (txtColorBlanco.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorBlanco.Focus();
            }
            else if (txtColorNegro.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorNegro.Focus();
            } if (txtColorVerdeR.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorVerdeR.Focus();
            }
            else if (txtColorAzulR.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorAzulR.Focus();
            }
            else if (txtColorAmarilloR.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorAmarilloR.Focus();
            }
            else if (txtColorMarronR.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorMarronR.Focus();
            }
            else if (txtColorGrisR.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorGrisR.Focus();
            }
            else if (txtColorRojoR.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorRojoR.Focus();
            }
            else if (txtColorBlancoR.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorBlancoR.Focus();
            }
            else if (txtColorNegroR.Text == "")
            {
                MessageBox.Show("Debe introducir un valor...");
                txtColorNegroR.Focus();
            }
            else
            {
                // Sumatoria de los Racimos Cortados
                int cantidad = Convert.ToInt32(txtColorVerde.Text) + Convert.ToInt32(txtColorAzul.Text) + Convert.ToInt32(txtColorAmarillo.Text) + 
                    Convert.ToInt32(txtColorMarron.Text) + Convert.ToInt32(txtColorGris.Text) + Convert.ToInt32(txtColorRojo.Text) + 
                    Convert.ToInt32(txtColorBlanco.Text) + Convert.ToInt32(txtColorNegro.Text);
                txtCantidadTotal.Text = Convert.ToString(cantidad);

                // Sumatoria de los Rechazos
                int cantidadR = Convert.ToInt32(txtColorVerdeR.Text) + Convert.ToInt32(txtColorAzulR.Text) + Convert.ToInt32(txtColorAmarilloR.Text) +
                    Convert.ToInt32(txtColorMarronR.Text) + Convert.ToInt32(txtColorGrisR.Text) + Convert.ToInt32(txtColorRojoR.Text) +
                    Convert.ToInt32(txtColorBlancoR.Text) + Convert.ToInt32(txtColorNegroR.Text);
                txtCantidadTotalR.Text = Convert.ToString(cantidadR);
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmGnrRptCosecha ofrmGnrRptCosecha = new frmGnrRptCosecha();
            ofrmGnrRptCosecha.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.cModo = "Editar";
            this.Botones();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string Campo = Convert.ToString(cmbCampo.SelectedValue);

            if (txtSemana.Text != "" && Campo != "" && txtRegistro.Text != "")
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
    }
}
