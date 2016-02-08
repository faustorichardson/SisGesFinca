using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLISoft
{
    public partial class frmMenu : frmBase
    {

        public string cUsuarioActual = frmLogin.cUsuarioActual;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rEGISTROCAMPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCampos frmFormCampo = new frmCampos();
            frmFormCampo.ShowDialog();
        }

        private void registroCalendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalendarioEncintado frmFormCalendarioEncintado = new frmCalendarioEncintado();
            frmFormCalendarioEncintado.ShowDialog();
        }


        private void reporteDescriptivoFincaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrintCampos ofrmPrintCampos = new frmPrintCampos();
            ofrmPrintCampos.ShowDialog();
        }

        private void rEGISTROEMBOLSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroEmbolse ofrmRegistroEmbolse = new frmRegistroEmbolse();
            ofrmRegistroEmbolse.ShowDialog();
        }

        private void rEGISTROCOSECHAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroCosecha ofrmRegistroCosecha = new frmRegistroCosecha();
            ofrmRegistroCosecha.ShowDialog();
        }

        private void rEGISTRODEEXPORTACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroExportacion ofrmRegistroExportacion = new frmRegistroExportacion();
            ofrmRegistroExportacion.ShowDialog();
        }

        private void acercaDelSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Gestion de Plantacion V1.0");
        }

        private void cmdRegistroCampos_Click(object sender, EventArgs e)
        {
            frmCampos frmFormCampo = new frmCampos();
            frmFormCampo.ShowDialog();
        }

        private void cmdRegistroCalendario_Click(object sender, EventArgs e)
        {
            frmCalendarioEncintado frmFormCalendarioEncintado = new frmCalendarioEncintado();
            frmFormCalendarioEncintado.ShowDialog();
        }

        private void cmdFormularioEmbolse_Click(object sender, EventArgs e)
        {
            frmRegistroEmbolse ofrmRegistroEmbolse = new frmRegistroEmbolse();
            ofrmRegistroEmbolse.ShowDialog();
        }

        private void cmdFormularioCosecha_Click(object sender, EventArgs e)
        {
            frmRegistroCosecha ofrmRegistroCosecha = new frmRegistroCosecha();
            ofrmRegistroCosecha.ShowDialog();
        }

        private void cmdRegistroExportacion_Click(object sender, EventArgs e)
        {
            frmRegistroExportacion ofrmRegistroExportacion = new frmRegistroExportacion();
            ofrmRegistroExportacion.ShowDialog();
        }

        private void registroDeInsumosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInsumos ofrmInsumos = new frmInsumos();
            ofrmInsumos.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            frmCampos frmFormCampo = new frmCampos();
            frmFormCampo.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmCalendarioEncintado frmFormCalendarioEncintado = new frmCalendarioEncintado();
            frmFormCalendarioEncintado.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmInsumos ofrmInsumos = new frmInsumos();
            ofrmInsumos.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registroUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnidadesMedidas ofrmUnidadesMedidas = new frmUnidadesMedidas();
            ofrmUnidadesMedidas.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmUnidadesMedidas ofrmUnidadesMedidas = new frmUnidadesMedidas();
            ofrmUnidadesMedidas.ShowDialog();
        }

        private void calendarioEncintadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmGnrRptCalendario ofrmGnrRptCalendario = new frmGnrRptCalendario();
            ofrmGnrRptCalendario.ShowDialog();
        }

        private void cantidadDeRacimosCosechadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGnrRptCosecha ofrmGnrRptCosecha = new frmGnrRptCosecha();
            ofrmGnrRptCosecha.ShowDialog();
        }

        private void tIPODEPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria ofrmCategoria = new frmCategoria();
            ofrmCategoria.ShowDialog();
        }

        private void sUBCATEGORIASPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubCategoria ofrmSubCategoria = new frmSubCategoria();
            ofrmSubCategoria.ShowDialog();
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroProductos ofrmRegistroProductos = new frmRegistroProductos();
            ofrmRegistroProductos.ShowDialog();
        }

        private void sUPLIDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroSuplidores ofrmRegistroSuplidores = new frmRegistroSuplidores();
            ofrmRegistroSuplidores.ShowDialog();
        }

        private void mAESTRODECLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes ofrmClientes = new frmClientes();
            ofrmClientes.ShowDialog();
        }

    }
}
