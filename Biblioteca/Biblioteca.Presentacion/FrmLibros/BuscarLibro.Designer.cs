namespace Biblioteca.Presentacion.FrmLibros
{
    partial class BuscarLibro
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
            this.getFindParamLibro = new System.Windows.Forms.TextBox();
            this.findBookLabel = new System.Windows.Forms.Label();
            this.buscarLibroButton = new System.Windows.Forms.Button();
            this.resultDGLibros = new System.Windows.Forms.DataGridView();
            this.countResultLibros = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resultDGLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // getFindParamLibro
            // 
            this.getFindParamLibro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getFindParamLibro.Location = new System.Drawing.Point(100, 80);
            this.getFindParamLibro.Name = "getFindParamLibro";
            this.getFindParamLibro.Size = new System.Drawing.Size(451, 20);
            this.getFindParamLibro.TabIndex = 0;
            this.getFindParamLibro.TextChanged += new System.EventHandler(this.getFindParamLibro_TextChanged);
            // 
            // findBookLabel
            // 
            this.findBookLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findBookLabel.AutoSize = true;
            this.findBookLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBookLabel.Location = new System.Drawing.Point(95, 26);
            this.findBookLabel.Name = "findBookLabel";
            this.findBookLabel.Size = new System.Drawing.Size(116, 25);
            this.findBookLabel.TabIndex = 1;
            this.findBookLabel.Text = "Buscar Libro";
            // 
            // buscarLibroButton
            // 
            this.buscarLibroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarLibroButton.Location = new System.Drawing.Point(566, 77);
            this.buscarLibroButton.Name = "buscarLibroButton";
            this.buscarLibroButton.Size = new System.Drawing.Size(138, 23);
            this.buscarLibroButton.TabIndex = 2;
            this.buscarLibroButton.Text = "Buscar";
            this.buscarLibroButton.UseVisualStyleBackColor = true;
            this.buscarLibroButton.Click += new System.EventHandler(this.buscarLibroButton_Click);
            // 
            // resultDGLibros
            // 
            this.resultDGLibros.AllowUserToAddRows = false;
            this.resultDGLibros.AllowUserToDeleteRows = false;
            this.resultDGLibros.AllowUserToOrderColumns = true;
            this.resultDGLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultDGLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDGLibros.Location = new System.Drawing.Point(53, 146);
            this.resultDGLibros.Name = "resultDGLibros";
            this.resultDGLibros.ReadOnly = true;
            this.resultDGLibros.Size = new System.Drawing.Size(682, 220);
            this.resultDGLibros.TabIndex = 3;
            // 
            // countResultLibros
            // 
            this.countResultLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.countResultLibros.AutoSize = true;
            this.countResultLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.countResultLibros.Location = new System.Drawing.Point(650, 418);
            this.countResultLibros.Name = "countResultLibros";
            this.countResultLibros.Size = new System.Drawing.Size(48, 13);
            this.countResultLibros.TabIndex = 4;
            this.countResultLibros.Text = "Filas: 0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BuscarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countResultLibros);
            this.Controls.Add(this.resultDGLibros);
            this.Controls.Add(this.buscarLibroButton);
            this.Controls.Add(this.findBookLabel);
            this.Controls.Add(this.getFindParamLibro);
            this.MinimizeBox = false;
            this.Name = "BuscarLibro";
            this.Text = "BuscarLibro";
            ((System.ComponentModel.ISupportInitialize)(this.resultDGLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox getFindParamLibro;
        private System.Windows.Forms.Label findBookLabel;
        private System.Windows.Forms.Button buscarLibroButton;
        private System.Windows.Forms.DataGridView resultDGLibros;
        private System.Windows.Forms.Label countResultLibros;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}