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
    public partial class BajaMaestro : Form
    {
        public BajaMaestro()
        {
            InitializeComponent();
            string consulta;
            consulta = "select idMaestro,nomMaestro,apeMaestro,numMaestro,fotoMaestro,status from maestro";
            dgListaMaestro.DataSource = conexion.tablaConsulta(consulta);
            diseñosDG.bajaMaestro(dgListaMaestro);
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string consulta;
            consulta = "select idMaestro,nomMaestro,apeMaestro,numMaestro,fotoMaestro,status from maestro where nomMaestro like  '%"+txtBuscador.Text+ "%' or apeMaestro like '%"
                + txtBuscador.Text + "%'";
            dgListaMaestro.DataSource = conexion.tablaConsulta(consulta);
            diseñosDG.bajaMaestro(dgListaMaestro);
        }

        private void dgListaMaestro_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try{
                    txtNombre.Text = dgListaMaestro.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtApellidos.Text = dgListaMaestro.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtNumero.Text = dgListaMaestro.Rows[e.RowIndex].Cells[3].Value.ToString();
                    pbMaestro.ImageLocation = dgListaMaestro.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cbxActivo.Checked = Convert.ToBoolean(dgListaMaestro.Rows[e.RowIndex].Cells[5].Value.ToString());
                    btnModificar.Enabled = true;
            }
            catch {
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string consulta;
            bool estado = cbxActivo.Checked;
            int b = estado ? 1 : 0;
            consulta = "update maestro set nomMaestro = '" + txtNombre.Text + "', apeMaestro = '" + txtApellidos.Text + "',numMaestro ='" + txtNumero.Text + "', status =" + b
                +"where idMaestro = "+ dgListaMaestro.SelectedCells[0].Value.ToString();
            conexion.insertarDatos(consulta);
            accionesComunes.datosModificados();
            Close();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            accionesComunes.SoloNumeros(e);
        }
    }
}
