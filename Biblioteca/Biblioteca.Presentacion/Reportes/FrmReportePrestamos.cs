using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Presentacion.Reportes.DataSets;

namespace Biblioteca.Presentacion.Reportes
{
    public partial class FrmReportePrestamos : Form
    {
        public FrmReportePrestamos()
        {
            InitializeComponent();
        }

        private void FrmReportePrestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrestamos.all_loans' Puede moverla o quitarla según sea necesario.
            this.all_loansTableAdapter.Fill(this.dataSetPrestamos.all_loans);


            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
