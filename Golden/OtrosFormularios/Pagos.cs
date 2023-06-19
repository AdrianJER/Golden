using Golden.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golden
{
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
            accionesComunes.dgListaAlumno(dgListaAlumno);
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            string consulta;
            try
            {
                string id = dgListaAlumno.SelectedCells[0].Value.ToString();
                int ultimoValor = Int32.Parse(dgListaPagos.RowCount.ToString()) + 1;
                int totalCuotas = Int32.Parse(dgListaPagos.Rows[0].Cells[5].Value.ToString());
                consulta = "insert into pagos (numCuota,totalCuotas,monto,mes,idAlumno) values(" + ultimoValor + "," + totalCuotas
                    + "," + txtMonto.Text + ",'" + DateTime.Today.ToString("yyyy-MM-dd") + "'," + id + ")";
            }
            catch {
                string id = dgListaAlumno.SelectedCells[0].Value.ToString();
                consulta = "insert into pagos (numCuota,totalCuotas,monto,mes,idAlumno) values(" + 1 + "," + 1
                    + "," + txtMonto.Text + ",'" + DateTime.Today.ToString("yyyy-MM-dd") + "'," + id + ")";
            }
            MessageBox.Show(consulta);
            conexion.insertarDatos(consulta);
            accionesComunes.datosCorrectos();
            Close();
        }

        private void dgListaAlumno_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            #region "Mensajes"
            if (txtMonto.Text == "") { accionesComunes.AdvertenciaDatos("Monto"); return; }
            #endregion
            string consulta;
            string id = dgListaAlumno.Rows[e.RowIndex].Cells[0].Value.ToString();
            consulta = "select alumno.idAlumno,alumno.nomAlumno, alumno.apeAlumno,alumno.numKardex, pagos.numCuota, registro.pln,pagos.monto,pagos.mes from alumno " +
                "inner join pagos on alumno.idAlumno =pagos.idAlumno inner join registro on alumno.idAlumno=registro.idAlumno where alumno.idAlumno ="+id;
            dgListaPagos.DataSource= conexion.tablaConsulta(consulta);
            diseñosDG.pagos(dgListaPagos);
            lblNombre.Text = dgListaAlumno.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dgListaAlumno.Rows[e.RowIndex].Cells[2].Value.ToString();
            pbAlumno.ImageLocation = dgListaAlumno.Rows[e.RowIndex].Cells[4].Value.ToString();
            lblNombre.Visible = true;
            pbAlumno.Visible = true;
            btnAgregarPago.Visible = true;
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            accionesComunes.SoloNumeros(e);
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            accionesComunes.buscador(txtBuscador.Text,dgListaAlumno);
        }
    }
}
