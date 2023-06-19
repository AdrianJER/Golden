namespace Golden
{
    partial class AgregarRegistro
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.txtOtroMetodo = new System.Windows.Forms.TextBox();
            this.txtEjecutivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpRegistro = new System.Windows.Forms.DateTimePicker();
            this.txtEngache = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.cbModoPago = new System.Windows.Forms.ComboBox();
            this.cbEstrategia = new System.Windows.Forms.ComboBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 37);
            this.label4.TabIndex = 75;
            this.label4.Text = "Registro";
            // 
            // txtMeses
            // 
            this.txtMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeses.Location = new System.Drawing.Point(323, 262);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(106, 26);
            this.txtMeses.TabIndex = 66;
            this.txtMeses.Text = "16";
            this.txtMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeses_KeyPress);
            // 
            // txtOtroMetodo
            // 
            this.txtOtroMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtroMetodo.Location = new System.Drawing.Point(514, 311);
            this.txtOtroMetodo.Name = "txtOtroMetodo";
            this.txtOtroMetodo.Size = new System.Drawing.Size(185, 26);
            this.txtOtroMetodo.TabIndex = 67;
            this.txtOtroMetodo.Visible = false;
            // 
            // txtEjecutivo
            // 
            this.txtEjecutivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjecutivo.Location = new System.Drawing.Point(323, 362);
            this.txtEjecutivo.Name = "txtEjecutivo";
            this.txtEjecutivo.Size = new System.Drawing.Size(300, 26);
            this.txtEjecutivo.TabIndex = 68;
            this.txtEjecutivo.Text = "Alejandra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 70;
            this.label1.Text = "Fecha de registro";
            // 
            // dtpRegistro
            // 
            this.dtpRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistro.Location = new System.Drawing.Point(323, 214);
            this.dtpRegistro.Name = "dtpRegistro";
            this.dtpRegistro.Size = new System.Drawing.Size(106, 26);
            this.dtpRegistro.TabIndex = 76;
            // 
            // txtEngache
            // 
            this.txtEngache.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEngache.Location = new System.Drawing.Point(323, 462);
            this.txtEngache.Name = "txtEngache";
            this.txtEngache.Size = new System.Drawing.Size(160, 26);
            this.txtEngache.TabIndex = 77;
            this.txtEngache.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEngache_KeyPress);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(323, 512);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(300, 121);
            this.txtObservacion.TabIndex = 79;
            // 
            // cbModoPago
            // 
            this.cbModoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModoPago.FormattingEnabled = true;
            this.cbModoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia",
            "Otro"});
            this.cbModoPago.Location = new System.Drawing.Point(323, 312);
            this.cbModoPago.Name = "cbModoPago";
            this.cbModoPago.Size = new System.Drawing.Size(185, 26);
            this.cbModoPago.TabIndex = 81;
            this.cbModoPago.SelectedIndexChanged += new System.EventHandler(this.cbModoPago_SelectedIndexChanged);
            // 
            // cbEstrategia
            // 
            this.cbEstrategia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstrategia.FormattingEnabled = true;
            this.cbEstrategia.Items.AddRange(new object[] {
            "Facebook",
            "Referido",
            "Volante"});
            this.cbEstrategia.Location = new System.Drawing.Point(323, 412);
            this.cbEstrategia.Name = "cbEstrategia";
            this.cbEstrategia.Size = new System.Drawing.Size(185, 26);
            this.cbEstrategia.TabIndex = 82;
            this.cbEstrategia.Text = "Facebook";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(1000, 659);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(144, 47);
            this.btnSiguiente.TabIndex = 83;
            this.btnSiguiente.Text = "Registrar Alumno";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.BackgroundImage = global::Golden.Properties.Resources.MedioGE;
            this.pnlRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistro.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(1266, 768);
            this.pnlRegistro.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 71;
            this.label2.Text = "Meses a pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 72;
            this.label3.Text = "Modo de pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 73;
            this.label5.Text = "Ejecutivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 74;
            this.label6.Text = "Estrategia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 78;
            this.label7.Text = "Enganche";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(122, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 24);
            this.label8.TabIndex = 80;
            this.label8.Text = "Observaciones";
            // 
            // AgregarRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golden.Properties.Resources.MedioGE;
            this.ClientSize = new System.Drawing.Size(1266, 768);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.cbEstrategia);
            this.Controls.Add(this.cbModoPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEngache);
            this.Controls.Add(this.dtpRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.txtOtroMetodo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEjecutivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlRegistro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarRegistro";
            this.Text = "AgregarRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.TextBox txtOtroMetodo;
        private System.Windows.Forms.TextBox txtEjecutivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpRegistro;
        private System.Windows.Forms.TextBox txtEngache;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.ComboBox cbModoPago;
        private System.Windows.Forms.ComboBox cbEstrategia;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}