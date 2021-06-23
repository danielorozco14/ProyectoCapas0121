namespace Biblioteca.Presentacion.FrmLibros
{
    partial class VerTodoLibros
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
            this.label1 = new System.Windows.Forms.Label();
            this.todosLibrosTable = new System.Windows.Forms.DataGridView();
            this.SeleccionarLibro = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contRowsLibros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.todosLibrosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Se muestran todos los libros sin prestar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // todosLibrosTable
            // 
            this.todosLibrosTable.AllowUserToAddRows = false;
            this.todosLibrosTable.AllowUserToDeleteRows = false;
            this.todosLibrosTable.AllowUserToOrderColumns = true;
            this.todosLibrosTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todosLibrosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todosLibrosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeleccionarLibro});
            this.todosLibrosTable.Location = new System.Drawing.Point(12, 72);
            this.todosLibrosTable.Name = "todosLibrosTable";
            this.todosLibrosTable.ReadOnly = true;
            this.todosLibrosTable.Size = new System.Drawing.Size(1239, 326);
            this.todosLibrosTable.TabIndex = 1;
            this.todosLibrosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todosLibrosTable_CellContentClick);
            // 
            // SeleccionarLibro
            // 
            this.SeleccionarLibro.HeaderText = "Seleccionar";
            this.SeleccionarLibro.Name = "SeleccionarLibro";
            this.SeleccionarLibro.ReadOnly = true;
            // 
            // contRowsLibros
            // 
            this.contRowsLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.contRowsLibros.AutoSize = true;
            this.contRowsLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.contRowsLibros.Location = new System.Drawing.Point(1151, 425);
            this.contRowsLibros.Name = "contRowsLibros";
            this.contRowsLibros.Size = new System.Drawing.Size(41, 13);
            this.contRowsLibros.TabIndex = 2;
            this.contRowsLibros.Text = "Filas: ";
            // 
            // VerTodoLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 450);
            this.Controls.Add(this.contRowsLibros);
            this.Controls.Add(this.todosLibrosTable);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "VerTodoLibros";
            this.Text = "VerTodoLibros";
            this.Load += new System.EventHandler(this.VerTodoLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todosLibrosTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView todosLibrosTable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionarLibro;
        private System.Windows.Forms.Label contRowsLibros;
    }
}