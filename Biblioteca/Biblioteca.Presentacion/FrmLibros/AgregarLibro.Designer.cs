namespace Biblioteca.Presentacion.FrmLibros
{
    public partial class AgregarLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtBoxTitulo = new System.Windows.Forms.TextBox();
            this.txtBoxAutor = new System.Windows.Forms.TextBox();
            this.txtBoxAnioEdicion = new System.Windows.Forms.TextBox();
            this.txtBoxNumEdicion = new System.Windows.Forms.TextBox();
            this.txtBoxMateria = new System.Windows.Forms.TextBox();
            this.txtBoxIdioma = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelAnioEdicion = new System.Windows.Forms.Label();
            this.labelNumEdicion = new System.Windows.Forms.Label();
            this.labelMateria = new System.Windows.Forms.Label();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelUbicacion = new System.Windows.Forms.Label();
            this.labelNumPaginas = new System.Windows.Forms.Label();
            this.labelPais = new System.Windows.Forms.Label();
            this.labelEditorial = new System.Windows.Forms.Label();
            this.labelISBM = new System.Windows.Forms.Label();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.txtBoxUbicacion = new System.Windows.Forms.TextBox();
            this.txtBoxNumPaginas = new System.Windows.Forms.TextBox();
            this.txtBoxPais = new System.Windows.Forms.TextBox();
            this.txtBoxEditorial = new System.Windows.Forms.TextBox();
            this.txtBoxISBM = new System.Windows.Forms.TextBox();
            this.addBooksDG = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider9 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider10 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider11 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider12 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addBooksDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider12)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(455, 247);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(187, 28);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Agregar";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtBoxTitulo
            // 
            this.txtBoxTitulo.Location = new System.Drawing.Point(36, 70);
            this.txtBoxTitulo.Name = "txtBoxTitulo";
            this.txtBoxTitulo.Size = new System.Drawing.Size(137, 20);
            this.txtBoxTitulo.TabIndex = 1;
            // 
            // txtBoxAutor
            // 
            this.txtBoxAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAutor.Location = new System.Drawing.Point(240, 70);
            this.txtBoxAutor.Name = "txtBoxAutor";
            this.txtBoxAutor.Size = new System.Drawing.Size(137, 20);
            this.txtBoxAutor.TabIndex = 2;
            // 
            // txtBoxAnioEdicion
            // 
            this.txtBoxAnioEdicion.Location = new System.Drawing.Point(36, 122);
            this.txtBoxAnioEdicion.Name = "txtBoxAnioEdicion";
            this.txtBoxAnioEdicion.Size = new System.Drawing.Size(137, 20);
            this.txtBoxAnioEdicion.TabIndex = 3;
            // 
            // txtBoxNumEdicion
            // 
            this.txtBoxNumEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNumEdicion.Location = new System.Drawing.Point(240, 122);
            this.txtBoxNumEdicion.Name = "txtBoxNumEdicion";
            this.txtBoxNumEdicion.Size = new System.Drawing.Size(137, 20);
            this.txtBoxNumEdicion.TabIndex = 4;
            // 
            // txtBoxMateria
            // 
            this.txtBoxMateria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMateria.Location = new System.Drawing.Point(681, 122);
            this.txtBoxMateria.Name = "txtBoxMateria";
            this.txtBoxMateria.Size = new System.Drawing.Size(137, 20);
            this.txtBoxMateria.TabIndex = 5;
            // 
            // txtBoxIdioma
            // 
            this.txtBoxIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIdioma.Location = new System.Drawing.Point(240, 177);
            this.txtBoxIdioma.Name = "txtBoxIdioma";
            this.txtBoxIdioma.Size = new System.Drawing.Size(137, 20);
            this.txtBoxIdioma.TabIndex = 6;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(33, 54);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 7;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(237, 54);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(32, 13);
            this.labelAutor.TabIndex = 8;
            this.labelAutor.Text = "Autor";
            // 
            // labelAnioEdicion
            // 
            this.labelAnioEdicion.AutoSize = true;
            this.labelAnioEdicion.Location = new System.Drawing.Point(33, 106);
            this.labelAnioEdicion.Name = "labelAnioEdicion";
            this.labelAnioEdicion.Size = new System.Drawing.Size(79, 13);
            this.labelAnioEdicion.TabIndex = 9;
            this.labelAnioEdicion.Text = "Año de Edición";
            // 
            // labelNumEdicion
            // 
            this.labelNumEdicion.AutoSize = true;
            this.labelNumEdicion.Location = new System.Drawing.Point(237, 106);
            this.labelNumEdicion.Name = "labelNumEdicion";
            this.labelNumEdicion.Size = new System.Drawing.Size(97, 13);
            this.labelNumEdicion.TabIndex = 10;
            this.labelNumEdicion.Text = "Número de Edición";
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Location = new System.Drawing.Point(678, 106);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(42, 13);
            this.labelMateria.TabIndex = 11;
            this.labelMateria.Text = "Materia";
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Location = new System.Drawing.Point(237, 161);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(38, 13);
            this.labelIdioma.TabIndex = 12;
            this.labelIdioma.Text = "Idioma";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(678, 161);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 24;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelUbicacion
            // 
            this.labelUbicacion.AutoSize = true;
            this.labelUbicacion.Location = new System.Drawing.Point(452, 161);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(94, 13);
            this.labelUbicacion.TabIndex = 23;
            this.labelUbicacion.Text = "Ubicacion Estante";
            // 
            // labelNumPaginas
            // 
            this.labelNumPaginas.AutoSize = true;
            this.labelNumPaginas.Location = new System.Drawing.Point(452, 106);
            this.labelNumPaginas.Name = "labelNumPaginas";
            this.labelNumPaginas.Size = new System.Drawing.Size(100, 13);
            this.labelNumPaginas.TabIndex = 22;
            this.labelNumPaginas.Text = "Número de Paginas";
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(33, 161);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(27, 13);
            this.labelPais.TabIndex = 21;
            this.labelPais.Text = "Pais";
            // 
            // labelEditorial
            // 
            this.labelEditorial.AutoSize = true;
            this.labelEditorial.Location = new System.Drawing.Point(678, 54);
            this.labelEditorial.Name = "labelEditorial";
            this.labelEditorial.Size = new System.Drawing.Size(44, 13);
            this.labelEditorial.TabIndex = 20;
            this.labelEditorial.Text = "Editorial";
            // 
            // labelISBM
            // 
            this.labelISBM.AutoSize = true;
            this.labelISBM.Location = new System.Drawing.Point(452, 54);
            this.labelISBM.Name = "labelISBM";
            this.labelISBM.Size = new System.Drawing.Size(33, 13);
            this.labelISBM.TabIndex = 19;
            this.labelISBM.Text = "ISBM";
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescripcion.Location = new System.Drawing.Point(681, 177);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(137, 50);
            this.txtBoxDescripcion.TabIndex = 18;
            // 
            // txtBoxUbicacion
            // 
            this.txtBoxUbicacion.Location = new System.Drawing.Point(455, 177);
            this.txtBoxUbicacion.Name = "txtBoxUbicacion";
            this.txtBoxUbicacion.Size = new System.Drawing.Size(137, 20);
            this.txtBoxUbicacion.TabIndex = 17;
            // 
            // txtBoxNumPaginas
            // 
            this.txtBoxNumPaginas.Location = new System.Drawing.Point(455, 122);
            this.txtBoxNumPaginas.Name = "txtBoxNumPaginas";
            this.txtBoxNumPaginas.Size = new System.Drawing.Size(137, 20);
            this.txtBoxNumPaginas.TabIndex = 16;
            // 
            // txtBoxPais
            // 
            this.txtBoxPais.Location = new System.Drawing.Point(36, 177);
            this.txtBoxPais.Name = "txtBoxPais";
            this.txtBoxPais.Size = new System.Drawing.Size(137, 20);
            this.txtBoxPais.TabIndex = 15;
            // 
            // txtBoxEditorial
            // 
            this.txtBoxEditorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxEditorial.Location = new System.Drawing.Point(681, 70);
            this.txtBoxEditorial.Name = "txtBoxEditorial";
            this.txtBoxEditorial.Size = new System.Drawing.Size(137, 20);
            this.txtBoxEditorial.TabIndex = 14;
            // 
            // txtBoxISBM
            // 
            this.txtBoxISBM.Location = new System.Drawing.Point(455, 70);
            this.txtBoxISBM.Name = "txtBoxISBM";
            this.txtBoxISBM.Size = new System.Drawing.Size(137, 20);
            this.txtBoxISBM.TabIndex = 13;
            // 
            // addBooksDG
            // 
            this.addBooksDG.AllowUserToAddRows = false;
            this.addBooksDG.AllowUserToDeleteRows = false;
            this.addBooksDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBooksDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addBooksDG.Location = new System.Drawing.Point(36, 296);
            this.addBooksDG.Name = "addBooksDG";
            this.addBooksDG.ReadOnly = true;
            this.addBooksDG.Size = new System.Drawing.Size(782, 142);
            this.addBooksDG.TabIndex = 25;
            this.addBooksDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addBooksDG_CellContentClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(217, 247);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(188, 28);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // errorProvider9
            // 
            this.errorProvider9.ContainerControl = this;
            // 
            // errorProvider10
            // 
            this.errorProvider10.ContainerControl = this;
            // 
            // errorProvider11
            // 
            this.errorProvider11.ContainerControl = this;
            // 
            // errorProvider12
            // 
            this.errorProvider12.ContainerControl = this;
            // 
            // AgregarLibro
            // 
            this.AcceptButton = this.btnAddBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.addBooksDG);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelUbicacion);
            this.Controls.Add(this.labelNumPaginas);
            this.Controls.Add(this.labelPais);
            this.Controls.Add(this.labelEditorial);
            this.Controls.Add(this.labelISBM);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtBoxUbicacion);
            this.Controls.Add(this.txtBoxNumPaginas);
            this.Controls.Add(this.txtBoxPais);
            this.Controls.Add(this.txtBoxEditorial);
            this.Controls.Add(this.txtBoxISBM);
            this.Controls.Add(this.labelIdioma);
            this.Controls.Add(this.labelMateria);
            this.Controls.Add(this.labelNumEdicion);
            this.Controls.Add(this.labelAnioEdicion);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.txtBoxIdioma);
            this.Controls.Add(this.txtBoxMateria);
            this.Controls.Add(this.txtBoxNumEdicion);
            this.Controls.Add(this.txtBoxAnioEdicion);
            this.Controls.Add(this.txtBoxAutor);
            this.Controls.Add(this.txtBoxTitulo);
            this.Controls.Add(this.btnAddBook);
            this.MinimizeBox = false;
            this.Name = "AgregarLibro";
            this.ShowInTaskbar = false;
            this.Text = "Libros - Agregar Libro";
            this.Load += new System.EventHandler(this.AgregarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addBooksDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtBoxTitulo;
        private System.Windows.Forms.TextBox txtBoxAutor;
        private System.Windows.Forms.TextBox txtBoxAnioEdicion;
        private System.Windows.Forms.TextBox txtBoxNumEdicion;
        private System.Windows.Forms.TextBox txtBoxMateria;
        private System.Windows.Forms.TextBox txtBoxIdioma;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelAnioEdicion;
        private System.Windows.Forms.Label labelNumEdicion;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelUbicacion;
        private System.Windows.Forms.Label labelNumPaginas;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.Label labelEditorial;
        private System.Windows.Forms.Label labelISBM;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.TextBox txtBoxUbicacion;
        private System.Windows.Forms.TextBox txtBoxNumPaginas;
        private System.Windows.Forms.TextBox txtBoxPais;
        private System.Windows.Forms.TextBox txtBoxEditorial;
        private System.Windows.Forms.TextBox txtBoxISBM;
        private System.Windows.Forms.DataGridView addBooksDG;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.ErrorProvider errorProvider9;
        private System.Windows.Forms.ErrorProvider errorProvider10;
        private System.Windows.Forms.ErrorProvider errorProvider11;
        private System.Windows.Forms.ErrorProvider errorProvider12;
    }
}