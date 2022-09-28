namespace pryParedesBiblioteca
{
    partial class frmBiblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiblioteca));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodigoEditorial = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.lblCodigoAutor = new System.Windows.Forms.Label();
            this.lblCodigoDistruibidor = new System.Windows.Forms.Label();
            this.txtCodigoEditorial = new System.Windows.Forms.TextBox();
            this.txtCodigoAutor = new System.Windows.Forms.TextBox();
            this.txtCodigoDistruibidor = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lstCodigo = new System.Windows.Forms.ListBox();
            this.lstNombreLibro = new System.Windows.Forms.ListBox();
            this.pbxFondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCodigoEditorial
            // 
            this.lblCodigoEditorial.AutoSize = true;
            this.lblCodigoEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEditorial.Location = new System.Drawing.Point(12, 94);
            this.lblCodigoEditorial.Name = "lblCodigoEditorial";
            this.lblCodigoEditorial.Size = new System.Drawing.Size(136, 20);
            this.lblCodigoEditorial.TabIndex = 1;
            this.lblCodigoEditorial.Text = "Codigo Editorial";
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLibro.Location = new System.Drawing.Point(12, 53);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(116, 20);
            this.lblNombreLibro.TabIndex = 2;
            this.lblNombreLibro.Text = "Nombre Libro";
            // 
            // lblCodigoAutor
            // 
            this.lblCodigoAutor.AutoSize = true;
            this.lblCodigoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAutor.Location = new System.Drawing.Point(12, 135);
            this.lblCodigoAutor.Name = "lblCodigoAutor";
            this.lblCodigoAutor.Size = new System.Drawing.Size(114, 20);
            this.lblCodigoAutor.TabIndex = 3;
            this.lblCodigoAutor.Text = "Codigo Autor";
            // 
            // lblCodigoDistruibidor
            // 
            this.lblCodigoDistruibidor.AutoSize = true;
            this.lblCodigoDistruibidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDistruibidor.Location = new System.Drawing.Point(12, 176);
            this.lblCodigoDistruibidor.Name = "lblCodigoDistruibidor";
            this.lblCodigoDistruibidor.Size = new System.Drawing.Size(162, 20);
            this.lblCodigoDistruibidor.TabIndex = 4;
            this.lblCodigoDistruibidor.Text = "Codigo Distriubidor";
            // 
            // txtCodigoEditorial
            // 
            this.txtCodigoEditorial.Location = new System.Drawing.Point(182, 96);
            this.txtCodigoEditorial.Name = "txtCodigoEditorial";
            this.txtCodigoEditorial.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEditorial.TabIndex = 7;
            // 
            // txtCodigoAutor
            // 
            this.txtCodigoAutor.Location = new System.Drawing.Point(182, 135);
            this.txtCodigoAutor.Name = "txtCodigoAutor";
            this.txtCodigoAutor.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoAutor.TabIndex = 8;
            // 
            // txtCodigoDistruibidor
            // 
            this.txtCodigoDistruibidor.Location = new System.Drawing.Point(182, 176);
            this.txtCodigoDistruibidor.Name = "txtCodigoDistruibidor";
            this.txtCodigoDistruibidor.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDistruibidor.TabIndex = 9;
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(16, 218);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(142, 23);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "<--";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(164, 218);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(142, 23);
            this.btnSiguiente.TabIndex = 11;
            this.btnSiguiente.Text = "--->";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lstCodigo
            // 
            this.lstCodigo.FormattingEnabled = true;
            this.lstCodigo.Location = new System.Drawing.Point(182, 15);
            this.lstCodigo.Name = "lstCodigo";
            this.lstCodigo.Size = new System.Drawing.Size(41, 17);
            this.lstCodigo.TabIndex = 12;
            // 
            // lstNombreLibro
            // 
            this.lstNombreLibro.FormattingEnabled = true;
            this.lstNombreLibro.Location = new System.Drawing.Point(182, 53);
            this.lstNombreLibro.Name = "lstNombreLibro";
            this.lstNombreLibro.Size = new System.Drawing.Size(159, 17);
            this.lstNombreLibro.TabIndex = 13;
            // 
            // pbxFondo
            // 
            this.pbxFondo.Image = ((System.Drawing.Image)(resources.GetObject("pbxFondo.Image")));
            this.pbxFondo.Location = new System.Drawing.Point(-3, 0);
            this.pbxFondo.Name = "pbxFondo";
            this.pbxFondo.Size = new System.Drawing.Size(357, 256);
            this.pbxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFondo.TabIndex = 14;
            this.pbxFondo.TabStop = false;
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 256);
            this.Controls.Add(this.lstNombreLibro);
            this.Controls.Add(this.lstCodigo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtCodigoDistruibidor);
            this.Controls.Add(this.txtCodigoAutor);
            this.Controls.Add(this.txtCodigoEditorial);
            this.Controls.Add(this.lblCodigoDistruibidor);
            this.Controls.Add(this.lblCodigoAutor);
            this.Controls.Add(this.lblNombreLibro);
            this.Controls.Add(this.lblCodigoEditorial);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pbxFondo);
            this.Name = "frmBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.frmBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodigoEditorial;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.Label lblCodigoAutor;
        private System.Windows.Forms.Label lblCodigoDistruibidor;
        private System.Windows.Forms.TextBox txtCodigoEditorial;
        private System.Windows.Forms.TextBox txtCodigoAutor;
        private System.Windows.Forms.TextBox txtCodigoDistruibidor;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ListBox lstCodigo;
        private System.Windows.Forms.ListBox lstNombreLibro;
        private System.Windows.Forms.PictureBox pbxFondo;
    }
}