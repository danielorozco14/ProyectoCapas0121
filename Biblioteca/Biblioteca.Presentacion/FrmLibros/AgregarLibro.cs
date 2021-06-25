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

        private bool formIsEmpty()
        {
            int cont = 0;
            if (txtBoxAnioEdicion.Text == string.Empty)
            {
                errorProvider1.SetError(txtBoxAnioEdicion, "Ingrese un año de Edición");
                cont++;
            }
            if (txtBoxAutor.Text == string.Empty)
            {
                errorProvider2.SetError(txtBoxAutor, "Ingrese un Autor");
                cont++;
            }
            if (txtBoxDescripcion.Text == string.Empty)
            {
                errorProvider3.SetError(txtBoxDescripcion, "Ingrese una Descripcion");
                cont++;
            }
            if (txtBoxEditorial.Text == string.Empty)
            {
                errorProvider4.SetError(txtBoxEditorial, "Ingrese una Editorial");
                cont++;
            }
            if (txtBoxIdioma.Text == string.Empty)
            {
                errorProvider5.SetError(txtBoxIdioma, "Ingrese un Idioma");
                cont++;
            }
            if (txtBoxISBM.Text == string.Empty)
            {
                errorProvider6.SetError(txtBoxISBM, "Ingrese un ISBM");
                cont++;
            }
            if (txtBoxMateria.Text == string.Empty)
            {
                errorProvider7.SetError(txtBoxMateria, "Ingrese una Materia");
                cont++;
            }
            if (txtBoxNumEdicion.Text == string.Empty)
            {
                errorProvider8.SetError(txtBoxNumEdicion, "Ingrese un numero de Edición");
                cont++;
            }
            if (txtBoxNumPaginas.Text == string.Empty)
            {
                errorProvider9.SetError(txtBoxNumPaginas, "Ingrese el Numero de Paginas");
                cont++;
            }
            if (txtBoxPais.Text == string.Empty)
            {
                errorProvider10.SetError(txtBoxPais, "Ingrese un Pais");
                cont++;
            }
            if (txtBoxTitulo.Text == string.Empty)
            {
                errorProvider11.SetError(txtBoxTitulo, "Ingrese un Titulo");
                cont++;
            }
            if (txtBoxUbicacion.Text == string.Empty)
            {
                errorProvider12.SetError(txtBoxUbicacion, "Ingrese una Ubicacion de Estante");
                cont++;
            }
            
            if (cont > 0) return true;

            return false;
        }

        private void clean()
        {
            txtBoxAnioEdicion.Clear();
            errorProvider1.SetError(txtBoxAnioEdicion, "");

            txtBoxAutor.Clear();
            errorProvider2.SetError(txtBoxAutor, "");

            txtBoxDescripcion.Clear();
            errorProvider3.SetError(txtBoxDescripcion, "");

            txtBoxEditorial.Clear();
            errorProvider4.SetError(txtBoxEditorial, "");


            txtBoxIdioma.Clear();
            errorProvider5.SetError(txtBoxIdioma, "");

            txtBoxISBM.Clear();
            errorProvider6.SetError(txtBoxISBM, "");

            txtBoxMateria.Clear();
            errorProvider7.SetError(txtBoxMateria, "");


            txtBoxNumEdicion.Clear();
            errorProvider8.SetError(txtBoxNumEdicion, "");

            txtBoxNumPaginas.Clear();
            errorProvider9.SetError(txtBoxNumPaginas, "");

            txtBoxPais.Clear();
            errorProvider10.SetError(txtBoxPais, "");

            txtBoxTitulo.Clear();
            errorProvider11.SetError(txtBoxTitulo, "");

            txtBoxUbicacion.Clear();
            errorProvider12.SetError(txtBoxUbicacion, "");

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
                if (!this.formIsEmpty())
                {
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
                    if (response.Equals("Libro agregado"))
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
                else
                {
                    errorMessage("Faltan campos por llenar");
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
