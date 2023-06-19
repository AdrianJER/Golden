namespace Golden
{
    partial class Pagos
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
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.dgListaAlumno = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgListaPagos = new System.Windows.Forms.DataGridView();
            this.pbAlumno = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregarPago = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 73;
            this.label1.Text = "Buscador ";
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(51, 140);
            this.txtBuscador.Multiline = true;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(320, 36);
            this.txtBuscador.TabIndex = 72;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // dgListaAlumno
            // 
            this.dgListaAlumno.AllowUserToAddRows = false;
            this.dgListaAlumno.AllowUserToDeleteRows = false;
            this.dgListaAlumno.AllowUserToResizeColumns = false;
            this.dgListaAlumno.AllowUserToResizeRows = false;
            this.dgListaAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaAlumno.Location = new System.Drawing.Point(51, 230);
            this.dgListaAlumno.MultiSelect = false;
            this.dgListaAlumno.Name = "dgListaAlumno";
            this.dgListaAlumno.ReadOnly = true;
            this.dgListaAlumno.RowHeadersVisible = false;
            this.dgListaAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaAlumno.Size = new System.Drawing.Size(320, 469);
            this.dgListaAlumno.TabIndex = 71;
            this.dgListaAlumno.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgListaAlumno_CellMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Golden.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(203, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(558, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 37);
            this.label4.TabIndex = 75;
            this.label4.Text = "Pagos";
            // 
            // dgListaPagos
            // 
            this.dgListaPagos.AllowUserToAddRows = false;
            this.dgListaPagos.AllowUserToDeleteRows = false;
            this.dgListaPagos.AllowUserToResizeRows = false;
            this.dgListaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaPagos.Location = new System.Drawing.Point(410, 230);
            this.dgListaPagos.Name = "dgListaPagos";
            this.dgListaPagos.ReadOnly = true;
            this.dgListaPagos.RowHeadersVisible = false;
            this.dgListaPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaPagos.Size = new System.Drawing.Size(793, 261);
            this.dgListaPagos.TabIndex = 76;
            // 
            // pbAlumno
            // 
            this.pbAlumno.Image = global::Golden.Properties.Resources._default;
            this.pbAlumno.Location = new System.Drawing.Point(957, 12);
            this.pbAlumno.Name = "pbAlumno";
            this.pbAlumno.Size = new System.Drawing.Size(199, 210);
            this.pbAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlumno.TabIndex = 78;
            this.pbAlumno.TabStop = false;
            this.pbAlumno.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(405, 139);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(101, 29);
            this.lblNombre.TabIndex = 77;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPago.Location = new System.Drawing.Point(1056, 683);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(147, 42);
            this.btnAgregarPago.TabIndex = 80;
            this.btnAgregarPago.Text = "Agregar Pago";
            this.btnAgregarPago.UseVisualStyleBackColor = true;
            this.btnAgregarPago.Visible = false;
            this.btnAgregarPago.Click += new System.EventHandler(this.btnAgregarPago_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(880, 533);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(98, 36);
            this.txtMonto.TabIndex = 84;
            this.txtMonto.Text = "1100";
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(773, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 83;
            this.label3.Text = "Monto";
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golden.Properties.Resources.MedioGE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1266, 768);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarPago);
            this.Controls.Add(this.pbAlumno);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgListaPagos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.dgListaAlumno);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagos";
            this.Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.DataGridView dgListaAlumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgListaPagos;
        private System.Windows.Forms.PictureBox pbAlumno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregarPago;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label3;
    }
}