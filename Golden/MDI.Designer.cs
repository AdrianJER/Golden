namespace Golden
{
    partial class formPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pbGolden = new System.Windows.Forms.PictureBox();
            this.lblFrase = new System.Windows.Forms.Label();
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.pnlBaja = new System.Windows.Forms.Panel();
            this.btnBajaMaestro = new System.Windows.Forms.Button();
            this.btnBajaAlumno = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.pnlReporte = new System.Windows.Forms.Panel();
            this.btnAsignaciones = new System.Windows.Forms.Button();
            this.btnMatriculas = new System.Windows.Forms.Button();
            this.btnCobranza = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnHorario = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnKardex = new System.Windows.Forms.Button();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.btnMaestros = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlMedio = new System.Windows.Forms.Panel();
            this.pbForm = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGolden)).BeginInit();
            this.pnlIzquierdo.SuspendLayout();
            this.pnlBaja.SuspendLayout();
            this.pnlReporte.SuspendLayout();
            this.pnlAgregar.SuspendLayout();
            this.pnlMedio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(154)))), ((int)(((byte)(4)))));
            this.pnlSuperior.Controls.Add(this.lblFrase);
            this.pnlSuperior.Controls.Add(this.pbGolden);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1529, 111);
            this.pnlSuperior.TabIndex = 0;
            // 
            // pbGolden
            // 
            this.pbGolden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbGolden.Image = global::Golden.Properties.Resources.descarga_removebg_preview;
            this.pbGolden.Location = new System.Drawing.Point(8, 12);
            this.pbGolden.Name = "pbGolden";
            this.pbGolden.Size = new System.Drawing.Size(255, 92);
            this.pbGolden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGolden.TabIndex = 2;
            this.pbGolden.TabStop = false;
            this.pbGolden.Click += new System.EventHandler(this.pbGolden_Click);
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(269, 39);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(74, 36);
            this.lblFrase.TabIndex = 0;
            this.lblFrase.Text = "Frase";
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.pnlIzquierdo.Controls.Add(this.lblVersion);
            this.pnlIzquierdo.Controls.Add(this.pnlBaja);
            this.pnlIzquierdo.Controls.Add(this.btnBaja);
            this.pnlIzquierdo.Controls.Add(this.pnlReporte);
            this.pnlIzquierdo.Controls.Add(this.btnReportes);
            this.pnlIzquierdo.Controls.Add(this.btnHorario);
            this.pnlIzquierdo.Controls.Add(this.btnPagos);
            this.pnlIzquierdo.Controls.Add(this.btnKardex);
            this.pnlIzquierdo.Controls.Add(this.pnlAgregar);
            this.pnlIzquierdo.Controls.Add(this.btnAgregar);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 111);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(263, 768);
            this.pnlIzquierdo.TabIndex = 1;
            // 
            // pnlBaja
            // 
            this.pnlBaja.Controls.Add(this.btnBajaMaestro);
            this.pnlBaja.Controls.Add(this.btnBajaAlumno);
            this.pnlBaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBaja.Location = new System.Drawing.Point(0, 544);
            this.pnlBaja.Name = "pnlBaja";
            this.pnlBaja.Size = new System.Drawing.Size(263, 100);
            this.pnlBaja.TabIndex = 1;
            this.pnlBaja.Visible = false;
            // 
            // btnBajaMaestro
            // 
            this.btnBajaMaestro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBajaMaestro.FlatAppearance.BorderSize = 0;
            this.btnBajaMaestro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaMaestro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaMaestro.ForeColor = System.Drawing.Color.White;
            this.btnBajaMaestro.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBajaMaestro.Location = new System.Drawing.Point(0, 49);
            this.btnBajaMaestro.Name = "btnBajaMaestro";
            this.btnBajaMaestro.Size = new System.Drawing.Size(263, 49);
            this.btnBajaMaestro.TabIndex = 4;
            this.btnBajaMaestro.Text = "Maestros";
            this.btnBajaMaestro.UseVisualStyleBackColor = true;
            this.btnBajaMaestro.Click += new System.EventHandler(this.btnBajaMaestro_Click);
            // 
            // btnBajaAlumno
            // 
            this.btnBajaAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBajaAlumno.FlatAppearance.BorderSize = 0;
            this.btnBajaAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaAlumno.ForeColor = System.Drawing.Color.White;
            this.btnBajaAlumno.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBajaAlumno.Location = new System.Drawing.Point(0, 0);
            this.btnBajaAlumno.Name = "btnBajaAlumno";
            this.btnBajaAlumno.Size = new System.Drawing.Size(263, 49);
            this.btnBajaAlumno.TabIndex = 3;
            this.btnBajaAlumno.Text = "Alumnos";
            this.btnBajaAlumno.UseVisualStyleBackColor = true;
            this.btnBajaAlumno.Click += new System.EventHandler(this.btnBajaAlumno_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaja.FlatAppearance.BorderSize = 0;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.ForeColor = System.Drawing.Color.White;
            this.btnBaja.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBaja.Location = new System.Drawing.Point(0, 495);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBaja.Size = new System.Drawing.Size(263, 49);
            this.btnBaja.TabIndex = 6;
            this.btnBaja.Text = "Bajas";
            this.btnBaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // pnlReporte
            // 
            this.pnlReporte.Controls.Add(this.btnAsignaciones);
            this.pnlReporte.Controls.Add(this.btnMatriculas);
            this.pnlReporte.Controls.Add(this.btnCobranza);
            this.pnlReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReporte.Location = new System.Drawing.Point(0, 345);
            this.pnlReporte.Name = "pnlReporte";
            this.pnlReporte.Size = new System.Drawing.Size(263, 150);
            this.pnlReporte.TabIndex = 1;
            this.pnlReporte.Visible = false;
            // 
            // btnAsignaciones
            // 
            this.btnAsignaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsignaciones.FlatAppearance.BorderSize = 0;
            this.btnAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignaciones.ForeColor = System.Drawing.Color.White;
            this.btnAsignaciones.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAsignaciones.Location = new System.Drawing.Point(0, 100);
            this.btnAsignaciones.Name = "btnAsignaciones";
            this.btnAsignaciones.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnAsignaciones.Size = new System.Drawing.Size(263, 50);
            this.btnAsignaciones.TabIndex = 5;
            this.btnAsignaciones.Text = "Asignaciones ";
            this.btnAsignaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignaciones.UseVisualStyleBackColor = true;
            this.btnAsignaciones.Click += new System.EventHandler(this.btnAsignaciones_Click);
            // 
            // btnMatriculas
            // 
            this.btnMatriculas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMatriculas.FlatAppearance.BorderSize = 0;
            this.btnMatriculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatriculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatriculas.ForeColor = System.Drawing.Color.White;
            this.btnMatriculas.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMatriculas.Location = new System.Drawing.Point(0, 50);
            this.btnMatriculas.Name = "btnMatriculas";
            this.btnMatriculas.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnMatriculas.Size = new System.Drawing.Size(263, 50);
            this.btnMatriculas.TabIndex = 4;
            this.btnMatriculas.Text = "RCM Matriculas";
            this.btnMatriculas.UseVisualStyleBackColor = true;
            this.btnMatriculas.Click += new System.EventHandler(this.btnMatriculas_Click);
            // 
            // btnCobranza
            // 
            this.btnCobranza.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCobranza.FlatAppearance.BorderSize = 0;
            this.btnCobranza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobranza.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobranza.ForeColor = System.Drawing.Color.White;
            this.btnCobranza.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCobranza.Location = new System.Drawing.Point(0, 0);
            this.btnCobranza.Name = "btnCobranza";
            this.btnCobranza.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnCobranza.Size = new System.Drawing.Size(263, 50);
            this.btnCobranza.TabIndex = 3;
            this.btnCobranza.Text = "RCM Cobranza";
            this.btnCobranza.UseVisualStyleBackColor = true;
            this.btnCobranza.Click += new System.EventHandler(this.btnCobranza_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 296);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(263, 49);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnHorario
            // 
            this.btnHorario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHorario.FlatAppearance.BorderSize = 0;
            this.btnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario.ForeColor = System.Drawing.Color.White;
            this.btnHorario.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnHorario.Location = new System.Drawing.Point(0, 247);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHorario.Size = new System.Drawing.Size(263, 49);
            this.btnHorario.TabIndex = 4;
            this.btnHorario.Text = "Horario";
            this.btnHorario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorario.UseVisualStyleBackColor = true;
            this.btnHorario.Visible = false;
            this.btnHorario.Click += new System.EventHandler(this.btnHorario_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.White;
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPagos.Location = new System.Drawing.Point(0, 198);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPagos.Size = new System.Drawing.Size(263, 49);
            this.btnPagos.TabIndex = 3;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnKardex
            // 
            this.btnKardex.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKardex.FlatAppearance.BorderSize = 0;
            this.btnKardex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKardex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKardex.ForeColor = System.Drawing.Color.White;
            this.btnKardex.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKardex.Location = new System.Drawing.Point(0, 149);
            this.btnKardex.Name = "btnKardex";
            this.btnKardex.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnKardex.Size = new System.Drawing.Size(263, 49);
            this.btnKardex.TabIndex = 2;
            this.btnKardex.Text = "Kardex";
            this.btnKardex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKardex.UseVisualStyleBackColor = true;
            this.btnKardex.Click += new System.EventHandler(this.btnKardex_Click);
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.Controls.Add(this.btnMaestros);
            this.pnlAgregar.Controls.Add(this.btnAlumnos);
            this.pnlAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAgregar.Location = new System.Drawing.Point(0, 49);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(263, 100);
            this.pnlAgregar.TabIndex = 1;
            this.pnlAgregar.Visible = false;
            // 
            // btnMaestros
            // 
            this.btnMaestros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaestros.FlatAppearance.BorderSize = 0;
            this.btnMaestros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaestros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaestros.ForeColor = System.Drawing.Color.White;
            this.btnMaestros.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMaestros.Location = new System.Drawing.Point(0, 49);
            this.btnMaestros.Name = "btnMaestros";
            this.btnMaestros.Size = new System.Drawing.Size(263, 49);
            this.btnMaestros.TabIndex = 3;
            this.btnMaestros.Text = "Maestros";
            this.btnMaestros.UseVisualStyleBackColor = true;
            this.btnMaestros.Click += new System.EventHandler(this.btnMaestros_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAlumnos.Location = new System.Drawing.Point(0, 0);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(263, 49);
            this.btnAlumnos.TabIndex = 2;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(263, 49);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlMedio
            // 
            this.pnlMedio.Controls.Add(this.pbForm);
            this.pnlMedio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMedio.Location = new System.Drawing.Point(263, 111);
            this.pnlMedio.Name = "pnlMedio";
            this.pnlMedio.Size = new System.Drawing.Size(1266, 768);
            this.pnlMedio.TabIndex = 2;
            // 
            // pbForm
            // 
            this.pbForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbForm.Image = global::Golden.Properties.Resources.MedioGE;
            this.pbForm.Location = new System.Drawing.Point(0, 0);
            this.pbForm.Name = "pbForm";
            this.pbForm.Size = new System.Drawing.Size(1266, 768);
            this.pbForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbForm.TabIndex = 0;
            this.pbForm.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(12, 746);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(73, 16);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version 1.0";
            this.lblVersion.DoubleClick += new System.EventHandler(this.lblVersion_DoubleClick);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 879);
            this.Controls.Add(this.pnlMedio);
            this.Controls.Add(this.pnlIzquierdo);
            this.Controls.Add(this.pnlSuperior);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Golden English";
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGolden)).EndInit();
            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlIzquierdo.PerformLayout();
            this.pnlBaja.ResumeLayout(false);
            this.pnlReporte.ResumeLayout(false);
            this.pnlAgregar.ResumeLayout(false);
            this.pnlMedio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlAgregar;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnMaestros;
        private System.Windows.Forms.Button btnKardex;
        private System.Windows.Forms.Button btnPagos;
        public System.Windows.Forms.Panel pnlMedio;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnHorario;
        private System.Windows.Forms.PictureBox pbForm;
        private System.Windows.Forms.Panel pnlReporte;
        private System.Windows.Forms.Button btnCobranza;
        private System.Windows.Forms.Button btnMatriculas;
        private System.Windows.Forms.Button btnAsignaciones;
        private System.Windows.Forms.Panel pnlBaja;
        private System.Windows.Forms.Button btnBajaMaestro;
        private System.Windows.Forms.Button btnBajaAlumno;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.PictureBox pbGolden;
        private System.Windows.Forms.Label lblVersion;
    }
}

