namespace BLISoft
{
    partial class frmPrinter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrinter));
            this.txtUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdUltimaPag = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.cmdPrimeraPag = new System.Windows.Forms.Button();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.cmdZoom = new System.Windows.Forms.Button();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.cmdExportarPdf = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBuscarText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIrPag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.Text = "Vista Previa de Reportes";
            // 
            // txtUpDown
            // 
            this.txtUpDown.Location = new System.Drawing.Point(902, 20);
            this.txtUpDown.Name = "txtUpDown";
            this.txtUpDown.Size = new System.Drawing.Size(41, 20);
            this.txtUpDown.TabIndex = 47;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.cmdUltimaPag);
            this.groupBox2.Controls.Add(this.cmdSiguiente);
            this.groupBox2.Controls.Add(this.cmdPrimeraPag);
            this.groupBox2.Controls.Add(this.cmdAnterior);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox2.Location = new System.Drawing.Point(227, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 37);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // cmdUltimaPag
            // 
            this.cmdUltimaPag.Image = ((System.Drawing.Image)(resources.GetObject("cmdUltimaPag.Image")));
            this.cmdUltimaPag.Location = new System.Drawing.Point(89, 11);
            this.cmdUltimaPag.Name = "cmdUltimaPag";
            this.cmdUltimaPag.Size = new System.Drawing.Size(30, 20);
            this.cmdUltimaPag.TabIndex = 16;
            this.cmdUltimaPag.UseVisualStyleBackColor = true;
            this.cmdUltimaPag.Click += new System.EventHandler(this.cmdUltimaPag_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("cmdSiguiente.Image")));
            this.cmdSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSiguiente.Location = new System.Drawing.Point(59, 11);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(30, 20);
            this.cmdSiguiente.TabIndex = 3;
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdPrimeraPag
            // 
            this.cmdPrimeraPag.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrimeraPag.Image")));
            this.cmdPrimeraPag.Location = new System.Drawing.Point(2, 11);
            this.cmdPrimeraPag.Name = "cmdPrimeraPag";
            this.cmdPrimeraPag.Size = new System.Drawing.Size(30, 20);
            this.cmdPrimeraPag.TabIndex = 15;
            this.cmdPrimeraPag.UseVisualStyleBackColor = true;
            this.cmdPrimeraPag.Click += new System.EventHandler(this.cmdPrimeraPag_Click);
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Image = ((System.Drawing.Image)(resources.GetObject("cmdAnterior.Image")));
            this.cmdAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAnterior.Location = new System.Drawing.Point(31, 11);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(30, 20);
            this.cmdAnterior.TabIndex = 2;
            this.cmdAnterior.UseVisualStyleBackColor = true;
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // cmdZoom
            // 
            this.cmdZoom.Image = ((System.Drawing.Image)(resources.GetObject("cmdZoom.Image")));
            this.cmdZoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdZoom.Location = new System.Drawing.Point(943, 17);
            this.cmdZoom.Name = "cmdZoom";
            this.cmdZoom.Size = new System.Drawing.Size(56, 26);
            this.cmdZoom.TabIndex = 45;
            this.cmdZoom.Text = "Zoom";
            this.cmdZoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdZoom.UseVisualStyleBackColor = true;
            this.cmdZoom.Click += new System.EventHandler(this.cmdZoom_Click);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.Image")));
            this.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdImprimir.Location = new System.Drawing.Point(825, 17);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(75, 27);
            this.cmdImprimir.TabIndex = 48;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdImprimir.UseVisualStyleBackColor = true;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // cmdExportarPdf
            // 
            this.cmdExportarPdf.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportarPdf.Image")));
            this.cmdExportarPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExportarPdf.Location = new System.Drawing.Point(721, 17);
            this.cmdExportarPdf.Name = "cmdExportarPdf";
            this.cmdExportarPdf.Size = new System.Drawing.Size(103, 27);
            this.cmdExportarPdf.TabIndex = 44;
            this.cmdExportarPdf.Text = "   Guardar como";
            this.cmdExportarPdf.UseVisualStyleBackColor = true;
            this.cmdExportarPdf.Click += new System.EventHandler(this.cmdExportarPdf_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.txtBuscarText);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtIrPag);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(356, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 37);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            // 
            // txtBuscarText
            // 
            this.txtBuscarText.Location = new System.Drawing.Point(169, 12);
            this.txtBuscarText.Name = "txtBuscarText";
            this.txtBuscarText.Size = new System.Drawing.Size(168, 20);
            this.txtBuscarText.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buscar Texto";
            // 
            // txtIrPag
            // 
            this.txtIrPag.Location = new System.Drawing.Point(71, 12);
            this.txtIrPag.Name = "txtIrPag";
            this.txtIrPag.Size = new System.Drawing.Size(27, 20);
            this.txtIrPag.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ir A Pag. No.";
            // 
            // CrystalReportViewer1
            // 
            this.CrystalReportViewer1.ActiveViewIndex = -1;
            this.CrystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrystalReportViewer1.Location = new System.Drawing.Point(2, 55);
            this.CrystalReportViewer1.Name = "CrystalReportViewer1";
            this.CrystalReportViewer1.Size = new System.Drawing.Size(997, 497);
            this.CrystalReportViewer1.TabIndex = 49;
            // 
            // frmPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 564);
            this.Controls.Add(this.CrystalReportViewer1);
            this.Controls.Add(this.txtUpDown);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdZoom);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.cmdExportarPdf);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmPrinter";
            this.Text = "frmPrinter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrinter_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.cmdExportarPdf, 0);
            this.Controls.SetChildIndex(this.cmdImprimir, 0);
            this.Controls.SetChildIndex(this.cmdZoom, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.txtUpDown, 0);
            this.Controls.SetChildIndex(this.CrystalReportViewer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtUpDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdUltimaPag;
        private System.Windows.Forms.Button cmdSiguiente;
        private System.Windows.Forms.Button cmdPrimeraPag;
        private System.Windows.Forms.Button cmdAnterior;
        private System.Windows.Forms.Button cmdZoom;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.Button cmdExportarPdf;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscarText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIrPag;
        private System.Windows.Forms.Label label3;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer1;
    }
}