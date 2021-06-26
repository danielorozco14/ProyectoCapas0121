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
    public partial class VerTodoPrestamos : Form
    {
        public VerTodoPrestamos()
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


        private void VerTodoPrestamos_Load(object sender, EventArgs e)
        {
            try
            {
                tableTodoPrestamos.DataSource = PrestamoService.listAll();

            }
            catch (Exception ex)
            {
                errorMessage(ex.Message);
            }
        }
    }
}
