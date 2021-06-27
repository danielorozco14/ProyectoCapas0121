namespace Biblioteca.Presentacion.FrmPrestamos
{
    partial class AgregarPrestamo
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
            this.tableProfesores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLibrosSinPrestar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateFechaDeDevolucion = new System.Windows.Forms.DateTimePicker();
            this.txtBoxIdProfesor = new System.Windows.Forms.TextBox();
            this.txtBoxIdLibro = new System.Windows.Forms.TextBox();
            this.txtBoxNombreProfesor = new System.Windows.Forms.TextBox();
            this.txtBoxNombreLibro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBoxApellidoProfesor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableProfesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLibrosSinPrestar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableProfesores
            // 
            this.tableProfesores.AllowUserToAddRows = false;
            this.tableProfesores.AllowUserToDeleteRows = false;
            this.tableProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableProfesores.Location = new System.Drawing.Point(30, 52);
            this.tableProfesores.Name = "tableProfesores";
            this.tableProfesores.ReadOnly = true;
            this.tableProfesores.Size = new System.Drawing.Size(538, 200);
            this.tableProfesores.TabIndex = 0;
            this.tableProfesores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableProfesores_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profesores";
            // 
            // tableLibrosSinPrestar
            // 
            this.tableLibrosSinPrestar.AllowUserToAddRows = false;
            this.tableLibrosSinPrestar.AllowUserToDeleteRows = false;
            this.tableLibrosSinPrestar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLibrosSinPrestar.Location = new System.Drawing.Point(30, 315);
            this.tableLibrosSinPrestar.Name = "tableLibrosSinPrestar";
            this.tableLibrosSinPrestar.ReadOnly = true;
            this.tableLibrosSinPrestar.Size = new System.Drawing.Size(538, 271);
            this.tableLibrosSinPrestar.TabIndex = 2;
            this.tableLibrosSinPrestar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableLibrosSinPrestar_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libros Disponibles para Prestar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(663, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Realizar Prestamo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(695, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID Profesor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(863, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre del Profesor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(695, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha de Prestamo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(863, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nombre del Libro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(695, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ID Libro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(987, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Fecha de Devolucion";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(698, 315);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateFechaDeDevolucion
            // 
            this.dateFechaDeDevolucion.Location = new System.Drawing.Point(990, 315);
            this.dateFechaDeDevolucion.MaxDate = new System.DateTime(2280, 12, 31, 0, 0, 0, 0);
            this.dateFechaDeDevolucion.MinDate = new System.DateTime(2021, 6, 26, 0, 0, 0, 0);
            this.dateFechaDeDevolucion.Name = "dateFechaDeDevolucion";
            this.dateFechaDeDevolucion.Size = new System.Drawing.Size(200, 20);
            this.dateFechaDeDevolucion.TabIndex = 12;
            this.dateFechaDeDevolucion.ValueChanged += new System.EventHandler(this.dateFechaDeDevolucion_ValueChanged);
            // 
            // txtBoxIdProfesor
            // 
            this.txtBoxIdProfesor.Enabled = false;
            this.txtBoxIdProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIdProfesor.Location = new System.Drawing.Point(698, 169);
            this.txtBoxIdProfesor.Name = "txtBoxIdProfesor";
            this.txtBoxIdProfesor.ReadOnly = true;
            this.txtBoxIdProfesor.Size = new System.Drawing.Size(100, 24);
            this.txtBoxIdProfesor.TabIndex = 13;
            // 
            // txtBoxIdLibro
            // 
            this.txtBoxIdLibro.Enabled = false;
            this.txtBoxIdLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIdLibro.Location = new System.Drawing.Point(698, 232);
            this.txtBoxIdLibro.Name = "txtBoxIdLibro";
            this.txtBoxIdLibro.ReadOnly = true;
            this.txtBoxIdLibro.Size = new System.Drawing.Size(100, 24);
            this.txtBoxIdLibro.TabIndex = 14;
            // 
            // txtBoxNombreProfesor
            // 
            this.txtBoxNombreProfesor.Enabled = false;
            this.txtBoxNombreProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombreProfesor.Location = new System.Drawing.Point(866, 169);
            this.txtBoxNombreProfesor.Name = "txtBoxNombreProfesor";
            this.txtBoxNombreProfesor.ReadOnly = true;
            this.txtBoxNombreProfesor.Size = new System.Drawing.Size(145, 24);
            this.txtBoxNombreProfesor.TabIndex = 15;
            // 
            // txtBoxNombreLibro
            // 
            this.txtBoxNombreLibro.Enabled = false;
            this.txtBoxNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombreLibro.Location = new System.Drawing.Point(866, 232);
            this.txtBoxNombreLibro.Name = "txtBoxNombreLibro";
            this.txtBoxNombreLibro.ReadOnly = true;
            this.txtBoxNombreLibro.Size = new System.Drawing.Size(145, 24);
            this.txtBoxNombreLibro.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Crear Prestamo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(927, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // txtBoxApellidoProfesor
            // 
            this.txtBoxApellidoProfesor.Enabled = false;
            this.txtBoxApellidoProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxApellidoProfesor.Location = new System.Drawing.Point(1054, 169);
            this.txtBoxApellidoProfesor.Name = "txtBoxApellidoProfesor";
            this.txtBoxApellidoProfesor.ReadOnly = true;
            this.txtBoxApellidoProfesor.Size = new System.Drawing.Size(155, 24);
            this.txtBoxApellidoProfesor.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1056, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Apellido del Profesor";
            // 
            // AgregarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 598);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxApellidoProfesor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxNombreLibro);
            this.Controls.Add(this.txtBoxNombreProfesor);
            this.Controls.Add(this.txtBoxIdLibro);
            this.Controls.Add(this.txtBoxIdProfesor);
            this.Controls.Add(this.dateFechaDeDevolucion);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLibrosSinPrestar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableProfesores);
            this.Name = "AgregarPrestamo";
            this.Text = "AgregarPrestamo";
            this.Load += new System.EventHandler(this.AgregarPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableProfesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLibrosSinPrestar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableProfesores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableLibrosSinPrestar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateFechaDeDevolucion;
        private System.Windows.Forms.TextBox txtBoxIdProfesor;
        private System.Windows.Forms.TextBox txtBoxIdLibro;
        private System.Windows.Forms.TextBox txtBoxNombreProfesor;
        private System.Windows.Forms.TextBox txtBoxNombreLibro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxApellidoProfesor;
    }
}