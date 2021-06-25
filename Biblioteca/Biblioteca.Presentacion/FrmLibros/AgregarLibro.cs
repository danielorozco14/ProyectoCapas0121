using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Negocio;
using System.Windows.Forms;

namespace Biblioteca.Presentacion.FrmLibros
{
    public partial class AgregarLibro : Form
    {
        public AgregarLibro()
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
            txtBoxAnioEdicion.Clear();
            txtBoxAutor.Clear();

            txtBoxDescripcion.Clear();
            txtBoxEditorial.Clear();

            txtBoxIdioma.Clear();
            txtBoxUbicacion.Clear();

            txtBoxISBM.Clear();
            txtBoxMateria.Clear();

            txtBoxNumEdicion.Clear();
            txtBoxNumPaginas.Clear();

            txtBoxPais.Clear();
            txtBoxTitulo.Clear();

        }

        

        private void AgregarLibro_Load(object sender, EventArgs e) 
        {
            try
            {
                addBooksDG.DataSource = LibroService.allBooks();

            }
            catch(Exception ex)
            {
                errorMessage(ex.Message);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                string response = "";
                response = LibroService.addBook(0,
                    txtBoxTitulo.Text.Trim(),
                    txtBoxAutor.Text.Trim(),
                    txtBoxISBM.Text.Trim(),
                    txtBoxEditorial.Text.Trim(),
                    txtBoxAnioEdicion.Text.Trim(),
                    txtBoxNumEdicion.Text.Trim(),
                    txtBoxPais.Text.Trim(),
                    txtBoxIdioma.Text.Trim(),
                    txtBoxMateria.Text.Trim(),
                    Convert.ToInt32(txtBoxNumPaginas.Text.Trim()),
                    txtBoxUbicacion.Text.Trim(),
                    txtBoxDescripcion.Text.Trim()
                    );
                if(response.Equals("Libro agregado"))
                {
                    addBooksDG.DataSource = LibroService.allBooks();
                    this.okayMessage(response);
                    this.clean();
                }
                else
                {
                    this.errorMessage(response);
                }

            }
            catch(Exception ex)
            {
                this.errorMessage(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.clean();
        }

        private void addBooksDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
