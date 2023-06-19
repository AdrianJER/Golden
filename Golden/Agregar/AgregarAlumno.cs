using Golden.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golden
{
    public partial class AgregarAlumno : Form
    {
        public Form actualFormHijo;
        string ruta;
        public AgregarAlumno()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            #region "Mensajes"
            if (txtNombre.Text == "") { accionesComunes.AdvertenciaDatos("Nombres"); return; }
            if (txtApellido.Text == "") { accionesComunes.AdvertenciaDatos("Apellidos"); return; }
            if (txtKardex.Text == "") { accionesComunes.AdvertenciaDatos("Numero de telefono"); return; }
            if (txtTelefono.Text == "") { accionesComunes.AdvertenciaDatos("Ocupacion"); return; }
            if (txtNombreTitular.Text == "") { accionesComunes.AdvertenciaDatos("Titular"); return; }
            #endregion
            ruta=accionesComunes.crearImagen(ruta, txtNombre.Text, txtApellido.Text,pcFotoAlumno);
            string consulta;
            consulta = "insert into alumno (nomAlumno,apeAlumno,numKardex,numAlumno,num2Alumno,ocupacion,dirAlumno,titularAlumno,fotoAlumno) "
                + "values('"+txtNombre.Text+"','"+txtApellido.Text+"','"+txtKardex.Text+"','"+txtTelefono.Text+"','" +txtCelular.Text+"','" +txtOcupacion.Text+"','" +txtDireccion.Text +"','" + txtNombreTitular.Text+"','" +ruta+"')";
            MessageBox.Show(consulta);
            conexion.insertarDatos(consulta);
            accionesComunes.abrirForm(new AgregarRegistro(),pnlAlumno);
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            ruta=accionesComunes.subirImagen(pcFotoAlumno);
        }
        #region "KeyPress"
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            accionesComunes.SoloNumeros(e);
        }
        private void txtKardex_KeyPress(object sender, KeyPressEventArgs e)
        {
            accionesComunes.SoloNumeros(e);
        }
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            accionesComunes.SoloNumeros(e);
        }
        #endregion
        #region "Metodos"

        #endregion
    }
}
