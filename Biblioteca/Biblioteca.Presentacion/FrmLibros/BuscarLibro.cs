using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Negocio;

namespace Biblioteca.Presentacion.FrmLibros
{
    public partial class BuscarLibro : Form
    {
        public BuscarLibro()
        {
            InitializeComponent();
        }

        private void tablePresentationOptions()
        {
            try
            {
                resultDGLibros.Columns[5].HeaderText = "Año de Edición";
                resultDGLibros.Columns[6].HeaderText = "Número de Edición";
                resultDGLibros.Columns[10].HeaderText = "Número de Páginas";

                countResultLibros.Text = "Filas: " + resultDGLibros.Rows.Count;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void findBook()
        {
            try
            {
                resultDGLibros.DataSource = LibroService.findBook(getFindParamLibro.Text);
                this.tablePresentationOptions();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void buscarLibroButton_Click(object sender, EventArgs e)
        {
            this.findBook();
        }
    }
}
