namespace pry.LopezV.SPBiblioteca
{
    partial class frmConsultaLibros
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
            this.cmdAvanzar = new System.Windows.Forms.Button();
            this.cmdRetroceder = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombreLibro = new System.Windows.Forms.Label();
            this.lblCodigoEditorial = new System.Windows.Forms.Label();
            this.lblCodigoAutor = new System.Windows.Forms.Label();
            this.lblCodigoDistr = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCodigoEdit = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoDistr = new System.Windows.Forms.TextBox();
            this.txtCodigoAut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdAvanzar
            // 
            this.cmdAvanzar.Location = new System.Drawing.Point(215, 293);
            this.cmdAvanzar.Name = "cmdAvanzar";
            this.cmdAvanzar.Size = new System.Drawing.Size(99, 24);
            this.cmdAvanzar.TabIndex = 11;
            this.cmdAvanzar.Text = "Avanzar";
            this.cmdAvanzar.UseVisualStyleBackColor = true;
            this.cmdAvanzar.Click += new System.EventHandler(this.cmdAvanzar_Click);
            // 
            // cmdRetroceder
            // 
            this.cmdRetroceder.Location = new System.Drawing.Point(12, 293);
            this.cmdRetroceder.Name = "cmdRetroceder";
            this.cmdRetroceder.Size = new System.Drawing.Size(99, 24);
            this.cmdRetroceder.TabIndex = 12;
            this.cmdRetroceder.Text = "Retroceder";
            this.cmdRetroceder.UseVisualStyleBackColor = true;
            this.cmdRetroceder.Click += new System.EventHandler(this.cmdRetroceder_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(26, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(258, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Consulta de Libros";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(16, 72);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.AutoSize = true;
            this.txtNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLibro.Location = new System.Drawing.Point(16, 114);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(129, 20);
            this.txtNombreLibro.TabIndex = 2;
            this.txtNombreLibro.Text = "Nombre del Libro";
            // 
            // lblCodigoEditorial
            // 
            this.lblCodigoEditorial.AutoSize = true;
            this.lblCodigoEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEditorial.Location = new System.Drawing.Point(16, 156);
            this.lblCodigoEditorial.Name = "lblCodigoEditorial";
            this.lblCodigoEditorial.Size = new System.Drawing.Size(120, 20);
            this.lblCodigoEditorial.TabIndex = 3;
            this.lblCodigoEditorial.Text = "Codigo Editorial";
            // 
            // lblCodigoAutor
            // 
            this.lblCodigoAutor.AutoSize = true;
            this.lblCodigoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAutor.Location = new System.Drawing.Point(16, 198);
            this.lblCodigoAutor.Name = "lblCodigoAutor";
            this.lblCodigoAutor.Size = new System.Drawing.Size(102, 20);
            this.lblCodigoAutor.TabIndex = 4;
            this.lblCodigoAutor.Text = "Codigo Autor";
            // 
            // lblCodigoDistr
            // 
            this.lblCodigoDistr.AutoSize = true;
            this.lblCodigoDistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDistr.Location = new System.Drawing.Point(16, 240);
            this.lblCodigoDistr.Name = "lblCodigoDistr";
            this.lblCodigoDistr.Size = new System.Drawing.Size(143, 20);
            this.lblCodigoDistr.TabIndex = 5;
            this.lblCodigoDistr.Text = "Codigo Distribuidor";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(165, 74);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtCodigoEdit
            // 
            this.txtCodigoEdit.Enabled = false;
            this.txtCodigoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEdit.Location = new System.Drawing.Point(165, 158);
            this.txtCodigoEdit.Name = "txtCodigoEdit";
            this.txtCodigoEdit.Size = new System.Drawing.Size(148, 20);
            this.txtCodigoEdit.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(165, 114);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 36);
            this.txtNombre.TabIndex = 8;
            // 
            // txtCodigoDistr
            // 
            this.txtCodigoDistr.Enabled = false;
            this.txtCodigoDistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDistr.Location = new System.Drawing.Point(165, 240);
            this.txtCodigoDistr.Name = "txtCodigoDistr";
            this.txtCodigoDistr.Size = new System.Drawing.Size(148, 20);
            this.txtCodigoDistr.TabIndex = 9;
            // 
            // txtCodigoAut
            // 
            this.txtCodigoAut.Enabled = false;
            this.txtCodigoAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAut.Location = new System.Drawing.Point(165, 198);
            this.txtCodigoAut.Name = "txtCodigoAut";
            this.txtCodigoAut.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoAut.TabIndex = 10;
            // 
            // frmConsultaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 329);
            this.Controls.Add(this.cmdRetroceder);
            this.Controls.Add(this.cmdAvanzar);
            this.Controls.Add(this.txtCodigoAut);
            this.Controls.Add(this.txtCodigoDistr);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigoEdit);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigoDistr);
            this.Controls.Add(this.lblCodigoAutor);
            this.Controls.Add(this.lblCodigoEditorial);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmConsultaLibros";
            this.Text = "frmConsultaLibros";
            this.Load += new System.EventHandler(this.frmConsultaLibros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdAvanzar;
        private System.Windows.Forms.Button cmdRetroceder;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label txtNombreLibro;
        private System.Windows.Forms.Label lblCodigoEditorial;
        private System.Windows.Forms.Label lblCodigoAutor;
        private System.Windows.Forms.Label lblCodigoDistr;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCodigoEdit;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoDistr;
        private System.Windows.Forms.TextBox txtCodigoAut;
    }
}