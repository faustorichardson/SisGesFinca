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


namespace BLISoft
{
    public partial class frmCategoria : frmBase
    {

        string cModo = "Inicio";

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            this.cModo = "Inicio";
            this.Botones();
            this.txtID.Focus();
        }

        private void Limpiar()
        {
            this.txtID.Clear();
            this.txtCategoria.Clear();
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
                MyCommand.CommandText = "SELECT count(*) FROM categorias";

                // Step 4 - Open connection
                MyConexion.Open();

                // Step 5 - Execute the SQL Statement y Asigno el valor resultante a la variable "codigo"
                int codigo;
                codigo = Convert.ToInt32(MyCommand.ExecuteScalar());
                codigo = codigo + 1;
                txtID.Text = Convert.ToString(codigo);
                txtCategoria.Focus();

                // Step 5 - Close the connection
                MyConexion.Close();
            }
            catch (MySqlException MyEx)
            {
                MessageBox.Show(MyEx.Message);
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
                    //
                    this.txtID.Enabled = true;
                    this.txtCategoria.Enabled = false;
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
                    this.txtID.Enabled = false;
                    this.txtCategoria.Enabled = true;
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
                    //
                    this.txtID.Enabled = true;
                    this.txtCategoria.Enabled = false;
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
                    this.txtID.Enabled = false;
                    this.txtCategoria.Enabled = true;
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
                    this.txtID.Enabled = true;
                    this.txtCategoria.Enabled = false;
                    break;

                case "Eliminar":
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cModo = "Nuevo";
            this.Limpiar();
            this.Botones();
            this.ProximoCodigo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.cModo = "Editar";
            this.Botones();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text != "")
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
            this.txtID.Focus();                
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                MessageBox.Show("No se permite grabar informacion con la descripcion en blanco...");
                txtCategoria.Focus();
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
                        myCommand.CommandText = "INSERT INTO categorias(descripcion) values(@descripcion)";
                        myCommand.Parameters.AddWithValue("@descripcion", txtCategoria.Text);

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
                        myCommand.CommandText = "UPDATE categorias SET descripcion = @descripcion WHERE id = " + txtID.Text + "";
                        myCommand.Parameters.AddWithValue("@descripcion", txtCategoria.Text);                        

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Debe de insertar un numero de ID...");
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
                    MyCommand.CommandText = "SELECT id, descripcion FROM categorias WHERE id = " + txtID.Text + "";

                    // Step 4 - connection open
                    MyConexion.Open();

                    // Step 5 - Creating the DataReader                    
                    MySqlDataReader MyReader = MyCommand.ExecuteReader();

                    // Step 6 - Verifying if Reader has rows
                    if (MyReader.HasRows)
                    {
                        while (MyReader.Read())
                        {
                            txtCategoria.Text = MyReader["descripcion"].ToString();                                                       
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
            string cUsuario = ""; //frmLogin.cUsuarioActual;
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
                //if (txtYear.Text != "")
                //{
                    //// Habilitando los campos necesarios
                    //txtYear.Enabled = true;
                    //txtYear.Focus();

                    // CREANDO EL QUERY DE CONSULTA
                    //string fechadesde = fechaDesde.Value.ToString("yyyy-MM-dd");
                    //string fechahasta = fechaHasta.Value.ToString("yyyy-MM-dd");
                    //cWhere = cWhere + " AND fechacita >= "+"'"+ fechadesde +"'" +" AND fechacita <= "+"'"+ fechahasta +"'"+"";
                    //cWhere = cWhere + " AND year = '" + txtYear.Text + "'";
                    sbQuery.Clear();
                    sbQuery.Append("SELECT id as Id, descripcion as Descripcion");
                    //sbQuery.Append(" doctores.doctores_cedula,upper(CONCAT(doctores.doctores_nombre,' ',doctores.doctores_apellido)) as doctor,departamentos.departamento_descripcion");
                    sbQuery.Append(" FROM categorias");                    
                    //sbQuery.Append(" INNER JOIN departamentos ON departamentos.departamento_id = cita.referimiento");
                    sbQuery.Append(cWhere);
                    sbQuery.Append(" ORDER BY descripcion ASC");
                    
                    // Paso los valores de sbQuery al CommandText
                    myCommand.CommandText = sbQuery.ToString();

                    // Creo el objeto Data Adapter y ejecuto el command en el
                    myAdapter = new MySqlDataAdapter(myCommand);

                    // Creo el objeto Data Table
                    DataTable dtCategoriasProductos = new DataTable();

                    // Lleno el data adapter
                    myAdapter.Fill(dtCategoriasProductos);

                    // Cierro el objeto clsConexion
                    myclsConexion.Close();

                    // Verifico cantidad de datos encontrados
                    int nRegistro = dtCategoriasProductos.Rows.Count;
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
                        cTitulo = "LISTADO DE CATEGORIAS DE PRODUCTOS";

                        //6to Instanciamos nuestro REPORTE
                        //Reportes.ListadoDoctores oListado = new Reportes.ListadoDoctores();
                        REPORTES.rptCategoriasProductos orptCategoriasProductos = new REPORTES.rptCategoriasProductos();
                        //pasamos el nombre del TITULO del Listado
                        //SumaryInfo es un objeto que se utiliza para leer,crear y actualizar las propiedades del reporte
                        // oListado.SummaryInfo.ReportTitle = cTitulo;
                        orptCategoriasProductos.SummaryInfo.ReportTitle = cTitulo;

                        //7mo. instanciamos nuestro el FORMULARIO donde esta nuestro ReportViewer
                        frmPrinter ofrmPrinter = new frmPrinter(dtCategoriasProductos, orptCategoriasProductos, cTitulo);
                        //ParameterFieldInfo Obtiene o establece la colección de campos de parámetros.                                                            
                        ofrmPrinter.CrystalReportViewer1.ParameterFieldInfo = oParametrosCR;
                        ofrmPrinter.ShowDialog();
                    }

                //}
                //else
                //{
                //    MessageBox.Show("No se puede realizar busqueda con campos vacios...");
                //    txtYear.Focus();
                //}

            }
            catch (Exception myEx)
            {
                MessageBox.Show("Error : " + myEx.Message, "Mostrando Reporte", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                // clsExceptionLog.LogError(myEx, false);
                return;
            }
        }
    }
}
