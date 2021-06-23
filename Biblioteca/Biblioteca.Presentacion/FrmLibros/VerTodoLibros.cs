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
    public partial class VerTodoLibros : Form
    {
        public VerTodoLibros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void todosLibrosTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablePresentationOptions()
        {
            try
            {
                todosLibrosTable.Columns[6].HeaderText = "Año de Edición";
                todosLibrosTable.Columns[7].HeaderText = "Número de Edición";
                todosLibrosTable.Columns[11].HeaderText = "Número de Páginas";

                contRowsLibros.Text = "Filas: " + todosLibrosTable.Rows.Count;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
          



        }

        private void allBooks()
        {
            try
            {
                todosLibrosTable.DataSource = LibroService.allBooks();
                this.tablePresentationOptions(); 
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void VerTodoLibros_Load(object sender, EventArgs e)
        {
            this.allBooks();
        }
    }
}
