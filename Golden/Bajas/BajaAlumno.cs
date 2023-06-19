using Golden.Clases;
using System;
using System.Windows.Forms;

namespace Golden
{
    public partial class BajaAlumno : Form
    {
        public BajaAlumno()
        {
            InitializeComponent();
            string consulta;
            consulta = "select idAlumno, nomAlumno,apeAlumno,numKardex,numAlumno,titularAlumno,fotoAlumno,status from alumno";
            dgListaAlumno.DataSource = conexion.tablaConsulta(consulta);
            diseñosDG.bajaAlumno(dgListaAlumno);
        }


        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string consulta;
            consulta = "select idAlumno, nomAlumno,apeAlumno,numKardex,numAlumno,titularAlumno,fotoAlumno,status from alumno where nomAlumno like  '%" + txtBuscador.Text + "%' or apeAlumno like '%"
                + txtBuscador.Text + "%' or numKardex like '%" + txtBuscador.Text + "%'";
            dgListaAlumno.DataSource = conexion.tablaConsulta(consulta);
            diseñosDG.bajaAlumno(dgListaAlumno);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string consulta;
            bool estado = cbxActivo.Checked;
            int b = estado ? 1 : 0;
            consulta = "update alumno set nomAlumno = '" + txtNombre.Text + "', apeAlumno = '" + txtApellidos.Text + "',numKardex='" + txtKardex.Text + "'," +
                "numAlumno ='" + txtTelefono.Text + "',titularAlumno ='" + txtTitular.Text + "', status = " + b
                + " where idAlumno = " + dgListaAlumno.SelectedCells[0].Value.ToString();
            MessageBox.Show(consulta);
            conexion.insertarDatos(consulta);
            accionesComunes.datosModificados();
            Close();
        }

        private void dgListaAlumno_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNombre.Text = dgListaAlumno.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApellidos.Text = dgListaAlumno.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtKardex.Text = dgListaAlumno.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTelefono.Text = dgListaAlumno.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTitular.Text = dgListaAlumno.Rows[e.RowIndex].Cells[5].Value.ToString();
            pbAlumno.ImageLocation = dgListaAlumno.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbxActivo.Checked = Convert.ToBoolean(dgListaAlumno.Rows[e.RowIndex].Cells[7].Value.ToString());
            btnModificar.Enabled = true;
        }
        #region "KeyPress"
        private void txtKardex_KeyPress(object sender, KeyPressEventArgs e)
        {
            accionesComunes.SoloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            accionesComunes.SoloNumeros(e);
        }
        #endregion
    }
}
