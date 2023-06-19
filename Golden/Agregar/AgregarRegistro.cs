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
    public partial class AgregarRegistro : Form
    {
        public string valor;
        formPrincipal agre=new formPrincipal();
        public AgregarRegistro()
        {
            InitializeComponent();
        }

        private void cbModoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbModoPago.SelectedIndex == 2)
            {
                txtOtroMetodo.Visible = true;
            }
            else
            {
                txtOtroMetodo.Visible = false;
            }
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            accionesComunes.SoloNumeros(e);
        }

        private void txtEngache_KeyPress(object sender, KeyPressEventArgs e)
        {
            accionesComunes.SoloNumeros(e);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            #region "Mensajes"
            if (txtMeses.Text == "") { accionesComunes.AdvertenciaDatos("Meses a pagar"); return; }
            if (cbModoPago.Text == "Otro")
            {
                if (txtOtroMetodo.Text == "") { accionesComunes.AdvertenciaDatos("Metodo de pago"); return; }
            }
            else
            {
                if (cbModoPago.Text == "") { accionesComunes.AdvertenciaDatos("Metodo de pago"); return; }
            }
            if (txtEjecutivo.Text == "") { accionesComunes.AdvertenciaDatos("Ejecutivo"); return; }
            if (cbEstrategia.Text == "") { accionesComunes.AdvertenciaDatos("Estraegia"); return; }
            if (txtEngache.Text == "") { accionesComunes.AdvertenciaDatos("Enganche"); return; }
            if (txtObservacion.Text == "") { accionesComunes.AdvertenciaDatos("Observaciones"); return; }
            #endregion
            int valor =conexion.ultimoValorAgregado();
            string consulta;
            if (cbModoPago.SelectedIndex == 2)
            {
                consulta = "insert into registro (fechaRegistro,pln,modoPago,ejecutivo,estrategia,enganche,observacion,idAlumno)" +
               "values('" + dtpRegistro.Text + "','" + txtMeses.Text + "','" + txtOtroMetodo.Text + "','" + txtEjecutivo.Text + "','" + cbEstrategia.Text + "'," + txtEngache.Text
               + ",'" + txtObservacion.Text + "'," + valor + ")";
            }
            else
            {
                consulta = "insert into registro (fechaRegistro,pln,modoPago,ejecutivo,estrategia,enganche,observacion,idAlumno)" +
               "values('" + dtpRegistro.Text + "','" + txtMeses.Text + "','" + cbModoPago.Text + "','" + txtEjecutivo.Text + "','" + cbEstrategia.Text + "'," + txtEngache.Text
               + ",'" + txtObservacion.Text + "'," + valor + ")";
            }
            conexion.insertarDatos(consulta);
            conexion.spCrearLecciones(valor);
            accionesComunes.datosCorrectos();
            pnlRegistro.BringToFront();
        }
    }
}
