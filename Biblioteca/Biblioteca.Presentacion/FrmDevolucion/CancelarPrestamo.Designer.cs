namespace Biblioteca.Presentacion.FrmDevolucion
{
    partial class CancelarPrestamo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnCancelarPrestamo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxBuscarProfesor = new System.Windows.Forms.TextBox();
            this.btnBuscarProfesor = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxFechaPrestamo = new System.Windows.Forms.TextBox();
            this.txtBoxFechaDevolucion = new System.Windows.Forms.TextBox();
            this.txtBoxIdLibro = new System.Windows.Forms.TextBox();
            this.txtBoxTituloLibro = new System.Windows.Forms.TextBox();
            this.txtBoxIdProfesor = new System.Windows.Forms.TextBox();
            this.txtBoxNombreProfesor = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(156, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(458, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProfesores_DoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(156, 291);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(458, 204);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPrestamosProfesor);
            // 
            // btnCancelarPrestamo
            // 
            this.btnCancelarPrestamo.Location = new System.Drawing.Point(799, 372);
            this.btnCancelarPrestamo.Name = "btnCancelarPrestamo";
            this.btnCancelarPrestamo.Size = new System.Drawing.Size(138, 37);
            this.btnCancelarPrestamo.TabIndex = 2;
            this.btnCancelarPrestamo.Text = "Devolver";
            this.btnCancelarPrestamo.UseVisualStyleBackColor = true;
            this.btnCancelarPrestamo.Click += new System.EventHandler(this.btnCancelarPrestamo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar Profesor (Nombre o Apellido)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prestamos Activos";
            // 
            // txtBoxBuscarProfesor
            // 
            this.txtBoxBuscarProfesor.Location = new System.Drawing.Point(156, 68);
            this.txtBoxBuscarProfesor.Name = "txtBoxBuscarProfesor";
            this.txtBoxBuscarProfesor.Size = new System.Drawing.Size(306, 20);
            this.txtBoxBuscarProfesor.TabIndex = 5;
            // 
            // btnBuscarProfesor
            // 
            this.btnBuscarProfesor.Location = new System.Drawing.Point(468, 68);
            this.btnBuscarProfesor.Name = "btnBuscarProfesor";
            this.btnBuscarProfesor.Size = new System.Drawing.Size(146, 20);
            this.btnBuscarProfesor.TabIndex = 6;
            this.btnBuscarProfesor.Text = "Buscar";
            this.btnBuscarProfesor.UseVisualStyleBackColor = true;
            this.btnBuscarProfesor.Click += new System.EventHandler(this.btnBuscarProfesor_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(990, 372);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 37);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(798, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha del Prestamo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(987, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de Devolucion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(798, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID Libro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(987, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Titulo del Libro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(798, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "ID Profesor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(987, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nombre del Profesor";
            // 
            // txtBoxFechaPrestamo
            // 
            this.txtBoxFechaPrestamo.Enabled = false;
            this.txtBoxFechaPrestamo.Location = new System.Drawing.Point(799, 141);
            this.txtBoxFechaPrestamo.Name = "txtBoxFechaPrestamo";
            this.txtBoxFechaPrestamo.ReadOnly = true;
            this.txtBoxFechaPrestamo.Size = new System.Drawing.Size(102, 20);
            this.txtBoxFechaPrestamo.TabIndex = 16;
            // 
            // txtBoxFechaDevolucion
            // 
            this.txtBoxFechaDevolucion.Enabled = false;
            this.txtBoxFechaDevolucion.Location = new System.Drawing.Point(990, 141);
            this.txtBoxFechaDevolucion.Name = "txtBoxFechaDevolucion";
            this.txtBoxFechaDevolucion.ReadOnly = true;
            this.txtBoxFechaDevolucion.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFechaDevolucion.TabIndex = 17;
            // 
            // txtBoxIdLibro
            // 
            this.txtBoxIdLibro.Enabled = false;
            this.txtBoxIdLibro.Location = new System.Drawing.Point(801, 207);
            this.txtBoxIdLibro.Name = "txtBoxIdLibro";
            this.txtBoxIdLibro.ReadOnly = true;
            this.txtBoxIdLibro.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIdLibro.TabIndex = 18;
            // 
            // txtBoxTituloLibro
            // 
            this.txtBoxTituloLibro.Enabled = false;
            this.txtBoxTituloLibro.Location = new System.Drawing.Point(990, 207);
            this.txtBoxTituloLibro.Name = "txtBoxTituloLibro";
            this.txtBoxTituloLibro.ReadOnly = true;
            this.txtBoxTituloLibro.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTituloLibro.TabIndex = 19;
            // 
            // txtBoxIdProfesor
            // 
            this.txtBoxIdProfesor.Enabled = false;
            this.txtBoxIdProfesor.Location = new System.Drawing.Point(799, 282);
            this.txtBoxIdProfesor.Name = "txtBoxIdProfesor";
            this.txtBoxIdProfesor.ReadOnly = true;
            this.txtBoxIdProfesor.Size = new System.Drawing.Size(102, 20);
            this.txtBoxIdProfesor.TabIndex = 20;
            // 
            // txtBoxNombreProfesor
            // 
            this.txtBoxNombreProfesor.Enabled = false;
            this.txtBoxNombreProfesor.Location = new System.Drawing.Point(990, 282);
            this.txtBoxNombreProfesor.Name = "txtBoxNombreProfesor";
            this.txtBoxNombreProfesor.ReadOnly = true;
            this.txtBoxNombreProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombreProfesor.TabIndex = 21;
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
            // CancelarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 523);
            this.Controls.Add(this.txtBoxNombreProfesor);
            this.Controls.Add(this.txtBoxIdProfesor);
            this.Controls.Add(this.txtBoxTituloLibro);
            this.Controls.Add(this.txtBoxIdLibro);
            this.Controls.Add(this.txtBoxFechaDevolucion);
            this.Controls.Add(this.txtBoxFechaPrestamo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscarProfesor);
            this.Controls.Add(this.txtBoxBuscarProfesor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarPrestamo);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CancelarPrestamo";
            this.Text = "CancelarPrestamo";
            this.Load += new System.EventHandler(this.CancelarPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnCancelarPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxBuscarProfesor;
        private System.Windows.Forms.Button btnBuscarProfesor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxFechaPrestamo;
        private System.Windows.Forms.TextBox txtBoxFechaDevolucion;
        private System.Windows.Forms.TextBox txtBoxIdLibro;
        private System.Windows.Forms.TextBox txtBoxTituloLibro;
        private System.Windows.Forms.TextBox txtBoxIdProfesor;
        private System.Windows.Forms.TextBox txtBoxNombreProfesor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}