using Golden.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golden
{
    public partial class Kardex : Form
    {
        public Kardex()
        {
            InitializeComponent();
            accionesComunes.dgListaAlumno(dgListaAlumno);
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            accionesComunes.buscador(txtBuscador.Text, dgListaAlumno);
        }

        private void dgListaAlumno_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try {
                string consulta;
                consulta = "select numLeccion,nomLeccion,warmUp,workshop,audio,gathering from leccion  where idAlumno=" + dgListaAlumno.Rows[e.RowIndex].Cells[0].Value.ToString();
                dgKardex.DataSource = conexion.tablaConsulta(consulta);
                diseñosDG.leccionesKardex(dgKardex);
                lblNombre.Text = dgListaAlumno.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dgListaAlumno.Rows[e.RowIndex].Cells[2].Value.ToString();
                pbAlumno.ImageLocation = dgListaAlumno.Rows[e.RowIndex].Cells[4].Value.ToString();
                lblNombre.Visible = true;
                pbAlumno.Visible = true;
                btnModificar.Visible = true;
            } catch
            {

            }
            
        }

        private void dgKardex_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 2)
            {
                dgKardex.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgKardex.BeginEdit(true);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string consulta="delete from leccion where idAlumno= "+ dgListaAlumno.SelectedCells[0].Value.ToString(); ;
            conexion.insertarDatos(consulta);
            for (int i = 0; i < dgKardex.RowCount; i++)
            {
                string nombre = dgKardex.Rows[i].Cells[1].Value.ToString();
                string numero = dgKardex.Rows[i].Cells[0].Value.ToString();
                string warmup = dgKardex.Rows[i].Cells[2].Value.ToString();
                string workshop = dgKardex.Rows[i].Cells[3].Value.ToString();
                string audio = dgKardex.Rows[i].Cells[4].Value.ToString();
                string id = dgListaAlumno.SelectedCells[0].Value.ToString();
                consulta = "insert into leccion (nomLeccion,numLeccion,warmUp,workshop,audio,gathering,idAlumno)"+
                    "values('"+nombre+"',"+numero+",'"+warmup+"','"+warmup+"','"+workshop+"','"+audio+"',"+id+")";
                conexion.insertarDatos(consulta);
            }
            accionesComunes.datosCorrectos();
        }
    }
}
