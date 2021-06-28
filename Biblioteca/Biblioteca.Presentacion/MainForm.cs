using Biblioteca.Presentacion.FrmLibros;
using Biblioteca.Presentacion.FrmPrestamos;
using Biblioteca.Presentacion.FrmDevolucion;
using Biblioteca.Presentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Presentacion
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void closeChildForms()
        {
            this.MdiChildren.OfType<Form>().ToList().ForEach(x => x.Close());
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actualizarUnPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void devolverUnLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelarPrestamo cancelarPrestamo = new CancelarPrestamo();

            cancelarPrestamo.MdiParent = this;
            cancelarPrestamo.Dock = DockStyle.Fill;
            cancelarPrestamo.Show();
            cancelarPrestamo.WindowState = FormWindowState.Maximized;

        }

        private void agregarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AgregarLibro agregarLibro = new AgregarLibro();
            
            agregarLibro.MdiParent = this;
            agregarLibro.Dock = DockStyle.Fill;
          
            agregarLibro.Show();
            agregarLibro.WindowState = FormWindowState.Maximized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            
        }


        //LISTA TODOS LOS LIBROS EN LA BD
        private void verTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerTodoLibros verTodoLibros = new VerTodoLibros();

            verTodoLibros.MdiParent = this;
            verTodoLibros.Dock = DockStyle.Fill;
            verTodoLibros.Show();
            verTodoLibros.WindowState = FormWindowState.Maximized;

        }

        private void verTodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerTodoPrestamos todoPrestamos = new VerTodoPrestamos();

            todoPrestamos.MdiParent = this;
            todoPrestamos.Dock = DockStyle.Fill;
            todoPrestamos.Show();
            todoPrestamos.WindowState = FormWindowState.Maximized;
        }

        private void actualizarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarLibro actualizarLibro = new ActualizarLibro();

            actualizarLibro.MdiParent = this;
            actualizarLibro.Dock = DockStyle.Fill;
            actualizarLibro.Show();
            actualizarLibro.WindowState = FormWindowState.Maximized;
        }

        private void buscarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarLibro buscarLibro = new BuscarLibro();

            buscarLibro.MdiParent = this;
            buscarLibro.Dock = DockStyle.Fill;
            buscarLibro.Show();
            buscarLibro.WindowState = FormWindowState.Maximized;
        }

        private void eliminarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarLibro eliminarLibro = new EliminarLibro();

            eliminarLibro.MdiParent = this;
            eliminarLibro.Dock = DockStyle.Fill;
            eliminarLibro.Show();
            eliminarLibro.WindowState = FormWindowState.Maximized;

        }

        private void crearUnPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPrestamo agregarPrestamo = new AgregarPrestamo();
            agregarPrestamo.MdiParent = this;
            agregarPrestamo.Dock = DockStyle.Fill;
            agregarPrestamo.Show();
            agregarPrestamo.WindowState = FormWindowState.Maximized;
        }

        private void reporteDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePrestamos frmReportePrestamos = new FrmReportePrestamos();
            frmReportePrestamos.ShowDialog();
        }

        private void reporteDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Load ReporteLibros
        }
    }
}
