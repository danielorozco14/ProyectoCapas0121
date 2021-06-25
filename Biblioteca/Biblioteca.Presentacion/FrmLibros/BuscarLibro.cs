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

        private void errorMessage(string mssg)
        {
            MessageBox.Show(mssg, "Biblioteca - Agregar Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void okayMessage(string mssg)
        {
            MessageBox.Show(mssg, "Biblioteca - Agregar Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clean()
        {
            getFindParamLibro.Clear();
        }

        private bool formIsEmpty()
        {
            int cont = 0;
            if (getFindParamLibro.Text == string.Empty)
            {
                errorProvider1.SetError(getFindParamLibro, "Ingrese algo para buscar. Ej: nombre libro, autor, fecha de publicacion, etc.");
                cont++;
            }
            if (cont > 0) return true;

            return false;
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
                if (!this.formIsEmpty())
                {

                    resultDGLibros.DataSource = LibroService.findBook(getFindParamLibro.Text);
                    this.tablePresentationOptions();
                    this.okayMessage("Busqueda Realizada Correctamente");
                }
                else
                {
                    this.errorMessage("Hubo un error");
                    this.clean();
                }
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

        private void getFindParamLibro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
