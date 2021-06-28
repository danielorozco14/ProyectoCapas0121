using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Presentacion.Reportes
{
    public partial class FrmReporteLibros : Form
    {
        public FrmReporteLibros()
        {
            InitializeComponent();
        }

        private void FrmReporteLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetLibros.all_books' Puede moverla o quitarla según sea necesario.
            this.all_booksTableAdapter.Fill(this.dataSetLibros.all_books);

            this.reportViewer1.RefreshReport();
        }
    }
}
