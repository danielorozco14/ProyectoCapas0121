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

namespace Biblioteca.Presentacion.FrmPrestamos
{
    public partial class AgregarPrestamo : Form
    {
        public AgregarPrestamo()
        {
            InitializeComponent();
            //Fecha de prestamo daytime picker deshabilitado de edicion

            dateTimePicker1.Enabled = false;
        }
        private void errorMessage(string mssg)
        {
            MessageBox.Show(mssg, "Biblioteca - Agregar Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void okayMessage(string mssg)
        {
            MessageBox.Show(mssg, "Biblioteca - Agregar Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool formIsEmpty()
        {
            int cont = 0;
            if (txtBoxIdLibro.Text == string.Empty)
            {
                errorProvider1.SetError(txtBoxIdLibro, "Debe seleccionar un Libro");
                cont++;
            }
            if (txtBoxIdProfesor.Text == string.Empty)
            {
                errorProvider2.SetError(txtBoxIdProfesor, "Debe seleccionar un Profesor");
                cont++;
            }
            if (cont > 0) return true;

            return false;

        }
        
        private void clean()
        {
            txtBoxIdLibro.Clear();
            errorProvider1.SetError(txtBoxIdLibro, "");

            txtBoxIdProfesor.Clear();
            errorProvider2.SetError(txtBoxIdProfesor, "");
            
            txtBoxNombreLibro.Clear();
            
            txtBoxNombreProfesor.Clear();
            
        }



        private void tableProfesores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxIdProfesor.Text = Convert.ToString(tableProfesores.CurrentRow.Cells["Codigo"].Value);
            txtBoxNombreProfesor.Text = Convert.ToString(tableProfesores.CurrentRow.Cells["Nombre"].Value);
        }

        private void tableLibrosSinPrestar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxIdLibro.Text = Convert.ToString(tableLibrosSinPrestar.CurrentRow.Cells["Codigo"].Value);
            txtBoxNombreLibro.Text = Convert.ToString(tableLibrosSinPrestar.CurrentRow.Cells["Titulo"].Value);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateFechaDeDevolucion_ValueChanged(object sender, EventArgs e)
        {
            if(dateFechaDeDevolucion.Value <= dateTimePicker1.Value)
            {
                this.errorMessage("La fecha de devolucion debe ser mayor a la fecha actual");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string response = "";

                if (!this.formIsEmpty())
                {
                    int idProfesor = Convert.ToInt32(txtBoxIdProfesor.Text.Trim());
                    int idLibro = Convert.ToInt32(txtBoxIdLibro.Text.Trim());

                    DateTime fechaPrestamo = Convert.ToDateTime(dateTimePicker1.Value);
                    DateTime fechaDevolucion = Convert.ToDateTime(dateFechaDeDevolucion.Value);


                    if (fechaDevolucion <= fechaPrestamo)
                    {
                        this.errorMessage("La fecha de devolucion debe ser mayor que a la fecha de prestamo");
                    }
                    else
                    {
                        response = PrestamoService.addLoan(idProfesor, idLibro, fechaPrestamo, fechaDevolucion);

                        if (response.Equals("Prestamo Realizado"))
                        {
                            if (LibroService.deactivateBook(idLibro).Equals("Libro Desactivado"))
                            {
                                this.clean();
                                this.okayMessage("Prestamo agregado correctamente");
                                tableLibrosSinPrestar.DataSource = LibroService.availableBooks();
                            }
                        }
                        else
                        {
                            this.errorMessage(response);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                this.errorMessage(ex.Message + ex.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.clean();
        }

        private void AgregarPrestamo_Load(object sender, EventArgs e)
        {
            try
            {
                tableLibrosSinPrestar.DataSource = LibroService.availableBooks();
                tableProfesores.DataSource = PersonaService.listAll();
            }
            catch(Exception ex)
            {
                this.errorMessage(ex.Message + ex.StackTrace);
            }
        }
    }
}
