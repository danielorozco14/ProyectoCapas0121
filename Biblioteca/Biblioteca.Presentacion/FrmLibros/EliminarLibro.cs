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
    public partial class EliminarLibro : Form
    {
        public EliminarLibro()
        {
            InitializeComponent();
        }


        private void errorMessage(string mssg)
        {
            MessageBox.Show(mssg, "Biblioteca - Eliminar Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void okayMessage(string mssg)
        {
            MessageBox.Show(mssg, "Biblioteca - Eliminar Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void tableEliminarLibros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EliminarLibro_Load(object sender, EventArgs e)
        {
            try
            {
                tableEliminarLibros.DataSource = LibroService.allBooks();

            }
            catch (Exception ex)
            {
                errorMessage(ex.Message);
            }
        }

        private void tableEliminarLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == tableEliminarLibros.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)tableEliminarLibros.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value); 
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Desea Eliminar Estos Libros?", "Biblioteca", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(dialogResult == DialogResult.OK)
                {
                    int Codigo;
                    string response = "";

                    foreach (DataGridViewRow data in tableEliminarLibros.Rows)
                    {
                        if (Convert.ToBoolean(data.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(data.Cells[1].Value);
                            response = LibroService.deleteBook(Codigo);

                            if (response.Equals("Libro Eliminado"))
                                this.okayMessage("Se eliminaron los registros seleccionados");
                            else
                                this.errorMessage(response);
                        }
                    }

                    tableEliminarLibros.DataSource = LibroService.allBooks();
                }
            }
            catch(Exception ex)
            {
                this.errorMessage(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            tableEliminarLibros.DataSource = LibroService.allBooks();
        }
    }
}
