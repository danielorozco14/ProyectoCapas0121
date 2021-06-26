namespace Biblioteca.Presentacion.FrmPrestamos
{
    partial class VerTodoPrestamos
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
            this.tableTodoPrestamos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableTodoPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos los prestamos realizados: ";
            // 
            // tableTodoPrestamos
            // 
            this.tableTodoPrestamos.AllowUserToAddRows = false;
            this.tableTodoPrestamos.AllowUserToDeleteRows = false;
            this.tableTodoPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableTodoPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableTodoPrestamos.Location = new System.Drawing.Point(16, 148);
            this.tableTodoPrestamos.Name = "tableTodoPrestamos";
            this.tableTodoPrestamos.ReadOnly = true;
            this.tableTodoPrestamos.Size = new System.Drawing.Size(772, 255);
            this.tableTodoPrestamos.TabIndex = 1;
            // 
            // VerTodoPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.tableTodoPrestamos);
            this.Controls.Add(this.label1);
            this.Name = "VerTodoPrestamos";
            this.Text = "VerTodoPrestamos";
            this.Load += new System.EventHandler(this.VerTodoPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableTodoPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableTodoPrestamos;
    }
}