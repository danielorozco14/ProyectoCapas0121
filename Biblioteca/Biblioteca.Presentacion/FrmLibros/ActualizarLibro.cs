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
    public partial class ActualizarLibro : Form
    {
        public ActualizarLibro()
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
            if (txtNumEdicion.Text == string.Empty)
            {
                errorProvider8.SetError(txtNumEdicion, "Ingrese un numero de Edición");
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
            txtBoxCodigo.Clear();

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


            txtNumEdicion.Clear();
            errorProvider8.SetError(txtNumEdicion, "");

            txtBoxNumPaginas.Clear();
            errorProvider9.SetError(txtBoxNumPaginas, "");

            txtBoxPais.Clear();
            errorProvider10.SetError(txtBoxPais, "");

            txtBoxTitulo.Clear();
            errorProvider11.SetError(txtBoxTitulo, "");

            txtBoxUbicacion.Clear();
            errorProvider12.SetError(txtBoxUbicacion, "");
            chkBoxEstado.Checked = false;

        }






        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.clean();

                txtBoxCodigo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Codigo"].Value);

                txtBoxAnioEdicion.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Anio_de_Edicion"].Value);
                txtBoxAutor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Autor"].Value);

                txtBoxDescripcion.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Descripcion"].Value);
                txtBoxEditorial.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Editorial"].Value);

                txtBoxIdioma.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Idioma"].Value);
                txtBoxISBM.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["ISBM"].Value);

                txtBoxMateria.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Materia"].Value);
                txtBoxNumPaginas.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Numero_Paginas"].Value);

                txtBoxPais.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Pais"].Value);
                txtBoxTitulo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Titulo"].Value);

                txtBoxUbicacion.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Ubicacion"].Value);
                txtNumEdicion.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Numero_de_Edicion"].Value);

                chkBoxEstado.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Estado"].Value);

            }
            catch (Exception ex)
            {
                this.errorMessage(ex.Message);
            }
        }




        private void ActualizarLibro_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LibroService.allBooks();
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string response = "";
                if (!this.formIsEmpty())
                {
                    response = LibroService.updateBook(Convert.ToInt32(txtBoxCodigo.Text.Trim()),
                    txtBoxTitulo.Text.Trim(),
                    txtBoxAutor.Text.Trim(),
                    txtBoxISBM.Text.Trim(),
                    txtBoxEditorial.Text.Trim(),
                    txtBoxAnioEdicion.Text.Trim(),
                    txtNumEdicion.Text.Trim(),
                    txtBoxPais.Text.Trim(),
                    txtBoxIdioma.Text.Trim(),
                    txtBoxMateria.Text.Trim(),
                    Convert.ToInt32(txtBoxNumPaginas.Text.Trim()),
                    txtBoxUbicacion.Text.Trim(),
                    txtBoxDescripcion.Text.Trim(),
                    Convert.ToBoolean(chkBoxEstado.Checked)
                    );
                    if (response.Equals("Libro Actualizado"))
                    {
                        dataGridView1.DataSource = LibroService.allBooks();
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
            catch (Exception ex)
            {
                this.errorMessage(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.clean();
        }

        private void chkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
