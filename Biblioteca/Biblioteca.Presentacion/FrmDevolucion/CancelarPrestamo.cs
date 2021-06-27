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

namespace Biblioteca.Presentacion.FrmDevolucion
{
    public partial class CancelarPrestamo : Form
    {
        public CancelarPrestamo()
        {
            InitializeComponent();
        }

        private void errorMessage(string mssg)
        {
            MessageBox.Show(mssg, "Biblioteca - Devolucion de Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void okayMessage(string mssg)
        {
            MessageBox.Show(mssg, "Biblioteca - Devoulucion Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool formIsEmpty()
        {
            int cont = 0;

            if (txtBoxIdProfesor.Text == string.Empty)
            {
                errorProvider2.SetError(txtBoxIdProfesor, "Seleccione un Profesor");
                cont++;
            }

            if (txtBoxIdLibro.Text == string.Empty)
            {
                errorProvider3.SetError(txtBoxBuscarProfesor, "Seleccione un Libro");
                cont++;
            }

            if (cont > 0) return true;

            return false;
        }

        private bool searchIsEmpty()
        {
            int cont = 0;
            if (txtBoxBuscarProfesor.Text == string.Empty)
            {
                errorProvider1.SetError(txtBoxBuscarProfesor, "Debe Llenar el campo");
                cont++;
            }

            if (cont > 0) return true;

            return false;
        }

        private void clean()
        {
            txtBoxBuscarProfesor.Clear();
            errorProvider1.SetError(txtBoxBuscarProfesor, "");

            txtBoxIdProfesor.Clear();
            errorProvider2.SetError(txtBoxIdProfesor, "");

            txtBoxIdLibro.Clear();
            errorProvider3.SetError(txtBoxIdLibro, "");

            txtBoxFechaDevolucion.Clear();
            txtBoxNombreProfesor.Clear();
            txtBoxFechaPrestamo.Clear();
          
            txtBoxIdProfesor.Clear();
            txtBoxNombreProfesor.Clear();
            txtBoxTituloLibro.Clear();

        }

        private void btnBuscarProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.searchIsEmpty())
                {
                    dataGridView1.DataSource = PersonaService.find(Convert.ToString(txtBoxBuscarProfesor.Text.Trim()));
                    this.okayMessage("Busqueda Exitosa");
                }
                else
                {
                    this.errorMessage("Se necesita un Nombre o un Apellido de un Profesor para realizar la busqueda");
                }

            }
            catch(Exception ex)
            {
                this.errorMessage(ex.Message + ex.StackTrace);
            }
        }

        private void CancelarPrestamo_Load(object sender, EventArgs e)
        {
        }

        private void btnCancelarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {

                string response = "";

                if (!this.formIsEmpty())
                {
                    int idLibro = Convert.ToInt32(txtBoxIdLibro.Text.Trim());
                    int idProfesor = Convert.ToInt32(txtBoxIdProfesor.Text.Trim());


                    response = PrestamoService.deactivateLoan(idLibro, idProfesor);

                    if(response.Equals("Prestamo desactivado correctamente"))
                    {
                        if(LibroService.activateBook(idLibro).Equals("Libro Activado"))
                        {
                            this.clean();
                            dataGridView2.DataSource = PrestamoService.listProffesorLoan(idProfesor);
                            this.okayMessage("Libro devuelto correctamente");
                        }
                        else
                        {
                            this.errorMessage("Hubo un error al activar el libro");
                        }

                    }
                    else
                    {
                        this.errorMessage("Hubo un error al desactivar el prestamo");
                    }
                }
                else
                {
                    this.errorMessage("Seleccione todos los campos necesarios haciendo doble click sobre las filas deseadas");
                }

            }catch(Exception ex)
            {
                this.errorMessage(ex.Message + ex.StackTrace);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.clean();
        }

        private void dataGridProfesores_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.clean();

                int idProfesor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                dataGridView2.DataSource = PrestamoService.listProffesorLoan(idProfesor);

            }
            catch (Exception ex)
            {
                this.errorMessage(ex.Message);
            }
        }

        //Double Click 
        private void dataGridPrestamosProfesor(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtBoxIdProfesor.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["CodigoProfesor"].Value);
                txtBoxIdLibro.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["CodigoLibro"].Value);

                txtBoxTituloLibro.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["Libro"].Value);
                txtBoxNombreProfesor.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["Profesor"].Value);

                txtBoxFechaPrestamo.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["Fecha_Prestamo"].Value);
                txtBoxFechaDevolucion.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["Fecha_Devolucion"].Value);

            }
            catch (Exception ex)
            {
                this.errorMessage(ex.Message + ex.StackTrace);
            }
        }
    }
}
