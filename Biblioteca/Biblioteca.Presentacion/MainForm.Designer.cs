namespace Biblioteca.Presentacion
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodoLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodoPrestamosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUnPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUnPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(898, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(53, 20);
            this.helpMenu.Text = "Ay&uda";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.contentsToolStripMenuItem.Text = "&Contenido";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.indexToolStripMenuItem.Text = "&Índice";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.searchToolStripMenuItem.Text = "&Buscar";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(173, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.devolucionToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(898, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTodoLibrosToolStripMenuItem,
            this.agregarLibroToolStripMenuItem,
            this.actualizarLibroToolStripMenuItem,
            this.eliminarLibroToolStripMenuItem,
            this.buscarLibroToolStripMenuItem});
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // verTodoLibrosToolStripMenuItem
            // 
            this.verTodoLibrosToolStripMenuItem.Name = "verTodoLibrosToolStripMenuItem";
            this.verTodoLibrosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.verTodoLibrosToolStripMenuItem.Text = "Todos los Libros...";
            this.verTodoLibrosToolStripMenuItem.Click += new System.EventHandler(this.verTodoToolStripMenuItem_Click);
            // 
            // agregarLibroToolStripMenuItem
            // 
            this.agregarLibroToolStripMenuItem.Name = "agregarLibroToolStripMenuItem";
            this.agregarLibroToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.agregarLibroToolStripMenuItem.Text = "Agregar Libro";
            this.agregarLibroToolStripMenuItem.Click += new System.EventHandler(this.agregarLibroToolStripMenuItem_Click);
            // 
            // actualizarLibroToolStripMenuItem
            // 
            this.actualizarLibroToolStripMenuItem.Name = "actualizarLibroToolStripMenuItem";
            this.actualizarLibroToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.actualizarLibroToolStripMenuItem.Text = "Actualizar Libro";
            this.actualizarLibroToolStripMenuItem.Click += new System.EventHandler(this.actualizarLibroToolStripMenuItem_Click);
            // 
            // eliminarLibroToolStripMenuItem
            // 
            this.eliminarLibroToolStripMenuItem.Name = "eliminarLibroToolStripMenuItem";
            this.eliminarLibroToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.eliminarLibroToolStripMenuItem.Text = "Eliminar Libro";
            this.eliminarLibroToolStripMenuItem.Click += new System.EventHandler(this.eliminarLibroToolStripMenuItem_Click);
            // 
            // buscarLibroToolStripMenuItem
            // 
            this.buscarLibroToolStripMenuItem.Name = "buscarLibroToolStripMenuItem";
            this.buscarLibroToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.buscarLibroToolStripMenuItem.Text = "Buscar Libro";
            this.buscarLibroToolStripMenuItem.Click += new System.EventHandler(this.buscarLibroToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTodoPrestamosToolStripMenuItem1,
            this.crearUnPrestamoToolStripMenuItem,
            this.buscarUnPrestamoToolStripMenuItem});
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            this.prestamosToolStripMenuItem.Click += new System.EventHandler(this.prestamosToolStripMenuItem_Click);
            // 
            // verTodoPrestamosToolStripMenuItem1
            // 
            this.verTodoPrestamosToolStripMenuItem1.Name = "verTodoPrestamosToolStripMenuItem1";
            this.verTodoPrestamosToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.verTodoPrestamosToolStripMenuItem1.Text = "Ver todos los prestamos...";
            this.verTodoPrestamosToolStripMenuItem1.Click += new System.EventHandler(this.verTodoToolStripMenuItem1_Click);
            // 
            // crearUnPrestamoToolStripMenuItem
            // 
            this.crearUnPrestamoToolStripMenuItem.Name = "crearUnPrestamoToolStripMenuItem";
            this.crearUnPrestamoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.crearUnPrestamoToolStripMenuItem.Text = "Crear un prestamo";
            this.crearUnPrestamoToolStripMenuItem.Click += new System.EventHandler(this.crearUnPrestamoToolStripMenuItem_Click);
            // 
            // buscarUnPrestamoToolStripMenuItem
            // 
            this.buscarUnPrestamoToolStripMenuItem.Name = "buscarUnPrestamoToolStripMenuItem";
            this.buscarUnPrestamoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.buscarUnPrestamoToolStripMenuItem.Text = "Buscar un prestamo";
            // 
            // devolucionToolStripMenuItem
            // 
            this.devolucionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarPrestamoToolStripMenuItem});
            this.devolucionToolStripMenuItem.Name = "devolucionToolStripMenuItem";
            this.devolucionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.devolucionToolStripMenuItem.Text = "Devolucion";
            // 
            // cancelarPrestamoToolStripMenuItem
            // 
            this.cancelarPrestamoToolStripMenuItem.Name = "cancelarPrestamoToolStripMenuItem";
            this.cancelarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cancelarPrestamoToolStripMenuItem.Text = "Cancelar prestamo";
            this.cancelarPrestamoToolStripMenuItem.Click += new System.EventHandler(this.devolverUnLibroToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Gestion de Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodoLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodoPrestamosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crearUnPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUnPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarPrestamoToolStripMenuItem;
    }
}



