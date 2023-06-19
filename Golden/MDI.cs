using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golden
{
    public partial class formPrincipal : Form
    {
        public Form actualFormHijo;
        public formPrincipal()
        {
            InitializeComponent();
            accionesComunes.FraseMotivadoras(lblFrase);
            abrirForm(new Kardex());
        }
        public void cerrarPanel()
        {
            if (pnlAgregar.Visible == true)
                pnlAgregar.Visible = false;
            if (pnlReporte.Visible == true)
                pnlReporte.Visible = false;
            if (pnlBaja.Visible == true)
                pnlBaja.Visible = false;
        }
        private void MostrarBtn(Panel pnl)
        {
            if(pnl.Visible == false)
            {
                cerrarPanel();
                pnl.Visible = true;
            }
            else
            {
                pnl.Visible = false;
            }

        }
        public void abrirForm(Form formHijo)
        {
            if (actualFormHijo != null)
            {
                actualFormHijo.Close();
            }
            actualFormHijo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlMedio.Controls.Add(formHijo);
            pnlMedio.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MostrarBtn(pnlAgregar);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            abrirForm(new AgregarAlumno());     
        }

        private void btnKardex_Click(object sender, EventArgs e)
        {
            abrirForm(new Kardex());
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            abrirForm(new AgregarMaestro());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            abrirForm(new Pagos());
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            //No se hizo el formulario por no saber como hacerlo, una alternativa seria crearlo en un html
            /*Horario horario = new Horario();
            horario.ShowDialog();*/
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MostrarBtn(pnlReporte);
        }

        private void btnCobranza_Click(object sender, EventArgs e)
        {
            abrirForm(new Reportes());
        }

        private void btnMatriculas_Click(object sender, EventArgs e)
        {
            abrirForm(new ReporteMatriculas());
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            abrirForm(new Asignaciones());
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            MostrarBtn(pnlBaja);
        }

        private void btnBajaAlumno_Click(object sender, EventArgs e)
        {
            abrirForm(new BajaAlumno());
        }

        private void btnBajaMaestro_Click(object sender, EventArgs e)
        {
            abrirForm(new BajaMaestro());
        }

        private void pbGolden_Click(object sender, EventArgs e)
        {
            abrirForm(new Kardex());
        }

        private void lblVersion_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Uso exclusivo para Golden English San Buenaventura.\n Creado por Adrian Jose Escalante Rodriguez - 19/06/2023", "Sistema Golden English",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
