namespace Biblioteca.Presentacion.FrmLibros
{
    partial class EliminarLibro
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
            this.tableEliminarLibros = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableEliminarLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione los libros a eliminar:";
            // 
            // tableEliminarLibros
            // 
            this.tableEliminarLibros.AllowUserToAddRows = false;
            this.tableEliminarLibros.AllowUserToDeleteRows = false;
            this.tableEliminarLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableEliminarLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableEliminarLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.tableEliminarLibros.Location = new System.Drawing.Point(50, 108);
            this.tableEliminarLibros.Name = "tableEliminarLibros";
            this.tableEliminarLibros.ReadOnly = true;
            this.tableEliminarLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableEliminarLibros.Size = new System.Drawing.Size(543, 308);
            this.tableEliminarLibros.TabIndex = 1;
            this.tableEliminarLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableEliminarLibros_CellContentClick);
            this.tableEliminarLibros.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableEliminarLibros_CellContentDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarLibro.Location = new System.Drawing.Point(653, 161);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(82, 62);
            this.btnEliminarLibro.TabIndex = 2;
            this.btnEliminarLibro.Text = "Eliminar";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(653, 275);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(82, 57);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Recargar";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // EliminarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnEliminarLibro);
            this.Controls.Add(this.tableEliminarLibros);
            this.Controls.Add(this.label1);
            this.Name = "EliminarLibro";
            this.Text = "EliminarLibro";
            this.Load += new System.EventHandler(this.EliminarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableEliminarLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableEliminarLibros;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.Button btnReload;
    }
}