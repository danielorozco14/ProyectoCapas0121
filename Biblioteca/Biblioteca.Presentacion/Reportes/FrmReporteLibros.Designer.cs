namespace Biblioteca.Presentacion.Reportes
{
    partial class FrmReporteLibros
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
            this.dataSetLibros = new Biblioteca.Presentacion.Reportes.DataSets.DataSetLibros();
            this.dataSetLibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allbooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.all_booksTableAdapter = new Biblioteca.Presentacion.Reportes.DataSets.DataSetLibrosTableAdapters.all_booksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLibrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allbooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataLibrosRegistrados";
            reportDataSource1.Value = this.allbooksBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Biblioteca.Presentacion.Reportes.ReporteLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetLibros
            // 
            this.dataSetLibros.DataSetName = "DataSetLibros";
            this.dataSetLibros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetLibrosBindingSource
            // 
            this.dataSetLibrosBindingSource.DataSource = this.dataSetLibros;
            this.dataSetLibrosBindingSource.Position = 0;
            // 
            // allbooksBindingSource
            // 
            this.allbooksBindingSource.DataMember = "all_books";
            this.allbooksBindingSource.DataSource = this.dataSetLibros;
            // 
            // all_booksTableAdapter
            // 
            this.all_booksTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteLibros";
            this.Text = "FrmReporteLibros";
            this.Load += new System.EventHandler(this.FrmReporteLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLibrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allbooksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DataSetLibros dataSetLibros;
        private System.Windows.Forms.BindingSource dataSetLibrosBindingSource;
        private System.Windows.Forms.BindingSource allbooksBindingSource;
        private DataSets.DataSetLibrosTableAdapters.all_booksTableAdapter all_booksTableAdapter;
    }
}