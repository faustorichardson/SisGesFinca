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

namespace BLISoft
{
    public partial class frmCampos : frmBase
    {
        string cModo = "Inicio";

        public frmCampos()
        {
            InitializeComponent();
           

            // Agregando funciones extras
            cModo = "Inicio";
            this.Botones();
            this.PopulateComboUnidad();
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
                    txtID.ReadOnly = false;
                    txtNombreCampo.ReadOnly = true;
                    cmbUnidadMedida.Enabled = false;
                    txtAreaSembrada.ReadOnly = true;
                    txtArea.ReadOnly = true;
                    txtLinea.Enabled = false;
                    txtPlantas.Enabled = false;
                    txtAspersores.Enabled = false;
                    txtMangueras.Enabled = false;
                    this.txtID.Focus();
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
                    txtID.ReadOnly = true;
                    txtNombreCampo.ReadOnly = false;
                    cmbUnidadMedida.Enabled = true;
                    txtArea.ReadOnly = false;
                    txtAreaSembrada.ReadOnly = false;
                    txtLinea.Enabled = true;
                    txtPlantas.Enabled = true;
                    txtAspersores.Enabled = true;
                    txtMangueras.Enabled = true;
                    txtNombreCampo.Focus();
                    break;

                case "Grabar":
                    this.btnNuevo.Enabled = true;
                    this.btnGrabar.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnBuscar.Enabled = true;
                    this.btnImprimir.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnSalir.Enabled = true;
                    txtID.ReadOnly = true;
                    txtNombreCampo.ReadOnly = true;
                    cmbUnidadMedida.Enabled = false;
                    txtArea.ReadOnly = true;
                    txtAreaSembrada.ReadOnly = true;
                    txtLinea.Enabled = false;
                    txtPlantas.Enabled = false;
                    txtAspersores.Enabled = false;
                    txtMangueras.Enabled = false;
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
                    txtID.ReadOnly = true;
                    txtNombreCampo.ReadOnly = false;
                    txtArea.ReadOnly = false;
                    txtAreaSembrada.ReadOnly = false;
                    this.cmbUnidadMedida.Enabled = true;
                    txtLinea.Enabled = true;
                    txtPlantas.Enabled = true;
                    txtAspersores.Enabled = true;
                    txtMangueras.Enabled = true;
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
                    txtID.ReadOnly = false;
                    txtNombreCampo.ReadOnly = true;
                    cmbUnidadMedida.Enabled = false;
                    txtArea.ReadOnly = true;
                    txtAreaSembrada.ReadOnly = true;
                    txtLinea.Enabled = false;
                    txtPlantas.Enabled = false;
                    txtAspersores.Enabled = false;
                    txtMangueras.Enabled = false;
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

        private void frmCampos_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            cModo = "Inicio";
            this.Botones();
        }

        private void PopulateComboUnidad()
        {
            // Step 1 
            MySqlConnection MyConexion = new MySqlConnection(Conexion.ConectionString);

            // Step 2
            MyConexion.Open();

            // Step 3
            MySqlCommand MyCommand = new MySqlCommand("SELECT id_unidad, desc_unidad FROM unidadmedidas " +
                "ORDER BY desc_unidad ASC", MyConexion);

            // Step 4
            MySqlDataReader MyReader;
            MyReader = MyCommand.ExecuteReader();

            // Step 5
            DataTable MyDataTable = new DataTable();
            MyDataTable.Columns.Add("id_unidad", typeof(int));
            MyDataTable.Columns.Add("desc_unidad", typeof(string));
            MyDataTable.Load(MyReader);

            // Step 6
            cmbUnidadMedida.ValueMember = "id_unidad";
            cmbUnidadMedida.DisplayMember = "desc_unidad";
            cmbUnidadMedida.DataSource = MyDataTable;

            // Step 7
            MyConexion.Close();

        }

        private void Limpiar()
        {
            this.txtID.Clear();
            this.txtNombreCampo.Clear();
            this.txtArea.Clear();
            this.txtAreaSembrada.Clear();
            this.txtLinea.Clear();
            this.txtPlantas.Clear();
            this.txtAspersores.Clear();
            this.txtMangueras.Clear();
            this.txtID.Focus();
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
                MyCommand.CommandText = "SELECT count(*) FROM campos";

                // Step 4 - Open connection
                MyConexion.Open();

                // Step 5 - Execute the SQL Statement y Asigno el valor resultante a la variable "codigo"
                int codigo = 0;
                codigo = Convert.ToInt32(MyCommand.ExecuteScalar());
                codigo = codigo + 1;
                txtID.Text = Convert.ToString(codigo);
                txtNombreCampo.Focus();

                // Step 5 - Close the connection
                MyConexion.Close();
            }
            catch (Exception MyEx)
            {
                MessageBox.Show(MyEx.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cModo = "Nuevo";
            this.Limpiar();
            this.Botones();
            this.ProximoCodigo();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtNombreCampo.Text == "" || txtArea.Text == "" || txtAreaSembrada.Text == "")
            {
                MessageBox.Show("No se permiten campos vacios...");
                txtNombreCampo.Focus();
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
                        myCommand.CommandText = "INSERT INTO campos(desc_campo, unidad, areacampo, areasembrada, lineas, " +
                            "plantas, aspersores, mangueras) VALUES(@descripcion, @unidad, @areacampo, @areasembrada, @lineas, " +
                            "@plantas, @aspersores, @mangueras)";
                        myCommand.Parameters.AddWithValue("@descripcion", txtNombreCampo.Text);
                        myCommand.Parameters.AddWithValue("@unidad", cmbUnidadMedida.SelectedValue);
                        myCommand.Parameters.AddWithValue("@areacampo", txtArea.Text);
                        myCommand.Parameters.AddWithValue("@areasembrada", txtAreaSembrada.Text);
                        myCommand.Parameters.AddWithValue("@lineas", txtLinea.Text);
                        myCommand.Parameters.AddWithValue("@plantas", txtPlantas.Text);
                        myCommand.Parameters.AddWithValue("@aspersores", txtAspersores.Text);
                        myCommand.Parameters.AddWithValue("@mangueras", txtMangueras.Text);

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
                        myCommand.CommandText = "UPDATE campos SET desc_campo = @descripcion, areacampo = @areacampo, " +
                            "areasembrada = @areasembrada, unidad = @unidad, lineas = @lineas, plantas = @plantas, "+
                            "aspersores = @aspersores, mangueras = @mangueras WHERE id_campo = " + txtID.Text + "";
                        myCommand.Parameters.AddWithValue("@descripcion", txtNombreCampo.Text);
                        myCommand.Parameters.AddWithValue("@areacampo", txtArea.Text);
                        myCommand.Parameters.AddWithValue("@areasembrada", txtAreaSembrada.Text);
                        myCommand.Parameters.AddWithValue("@unidad", cmbUnidadMedida.SelectedValue);
                        myCommand.Parameters.AddWithValue("@lineas", txtLinea.Text);
                        myCommand.Parameters.AddWithValue("@plantas", txtPlantas.Text);
                        myCommand.Parameters.AddWithValue("@aspersores", txtAspersores.Text);
                        myCommand.Parameters.AddWithValue("@mangueras", txtMangueras.Text);

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtNombreCampo.Text != "")
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("No se permiten busquedas vacias...");
                txtID.Focus();
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
                    MyCommand.CommandText = "SELECT id_campo, desc_campo, areacampo, areasembrada, unidad, lineas, plantas, " +
                        "aspersores, mangueras FROM campos WHERE id_campo = " + txtID.Text + "";

                    // Step 4 - connection open
                    MyConexion.Open();

                    // Step 5 - Creating the DataReader                    
                    MySqlDataReader MyReader = MyCommand.ExecuteReader();

                    // Step 6 - Verifying if Reader has rows
                    if (MyReader.HasRows)
                    {

                        while (MyReader.Read())
                        {
                            txtNombreCampo.Text = MyReader["desc_campo"].ToString();
                            txtArea.Text = MyReader["areacampo"].ToString();
                            txtAreaSembrada.Text = MyReader["areasembrada"].ToString();
                            cmbUnidadMedida.SelectedValue = MyReader["unidad"].ToString();
                            txtLinea.Text = MyReader["lineas"].ToString();
                            txtPlantas.Text = MyReader["plantas"].ToString();
                            txtAspersores.Text = MyReader["aspersores"].ToString();
                            txtMangueras.Text = MyReader["mangueras"].ToString();
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
                        this.txtID.Focus();
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmPrintCampos ofrmPrintCampos = new frmPrintCampos();
            ofrmPrintCampos.Show();
        }

    }
}
