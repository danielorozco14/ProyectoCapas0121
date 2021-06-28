namespace Biblioteca.Presentacion.Reportes
{
    partial class FrmReportePrestamos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetPrestamos = new Biblioteca.Presentacion.Reportes.DataSets.DataSetPrestamos();
            this.allloansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.all_loansTableAdapter = new Biblioteca.Presentacion.Reportes.DataSets.DataSetPrestamosTableAdapters.all_loansTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allloansBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPrestamosActivos";
            reportDataSource1.Value = this.allloansBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Biblioteca.Presentacion.Reportes.ReportePrestamosActivos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1064, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetPrestamos
            // 
            this.dataSetPrestamos.DataSetName = "DataSetPrestamos";
            this.dataSetPrestamos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allloansBindingSource
            // 
            this.allloansBindingSource.DataMember = "all_loans";
            this.allloansBindingSource.DataSource = this.dataSetPrestamos;
            // 
            // all_loansTableAdapter
            // 
            this.all_loansTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 539);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportePrestamos";
            this.Text = "FrmReportePrestamos";
            this.Load += new System.EventHandler(this.FrmReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allloansBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DataSetPrestamos dataSetPrestamos;
        private System.Windows.Forms.BindingSource allloansBindingSource;
        private DataSets.DataSetPrestamosTableAdapters.all_loansTableAdapter all_loansTableAdapter;
    }
}