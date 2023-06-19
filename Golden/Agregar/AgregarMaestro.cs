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
    public partial class AgregarMaestro : Form
    {
        string ruta;

        public AgregarMaestro()
        {
            InitializeComponent();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            ruta=accionesComunes.subirImagen(pcFotoMaestro);
            
        }
       
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            #region
            if (txtNombre.Text == "") { accionesComunes.AdvertenciaDatos("Nombres"); return; }
            if (txtApellido.Text == "") { accionesComunes.AdvertenciaDatos("Apellido"); return; }
            if (txtNumero.Text == "") { accionesComunes.AdvertenciaDatos("Numero de telefono"); return; }
            #endregion
            ruta = accionesComunes.crearImagenMaestro(ruta, txtNombre.Text, txtApellido.Text, pcFotoMaestro);
            string consulta = "insert into maestro(nomMaestro,apeMaestro,numMaestro,fotoMaestro)" +
                "values('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtNumero.Text + "','" + ruta + "')";
            conexion.insertarDatos(consulta);
            accionesComunes.datosCorrectos();
            Close();
        }
        #region "KeyPress"
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            accionesComunes.SoloNumeros(e);
        }
        #endregion
    }
}
