using Golden.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golden
{
    public static class accionesComunes
    {
        private static Form actualFormHijo;
        public static void AdvertenciaDatos(string mensaje)
        {
            MessageBox.Show("Por favor llene el siguiente campo: " + mensaje, "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void datosCorrectos()
        {
            MessageBox.Show("Se han agregado correctamente los datos","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public static void datosModificados()
        {
            MessageBox.Show("Se han modificado correctamente los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static string subirImagen(PictureBox pb)
        {
            string rutaImagen;
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Title = "Seleccionar imagen";
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*";

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    rutaImagen = openFileDialog.FileName;
                    pb.Image = new System.Drawing.Bitmap(rutaImagen);
                    openFileDialog.Dispose();
                    return rutaImagen;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Selecciona una imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }
        public static string crearImagen(string ruta, string nombre,string apellido, PictureBox pb)
        {
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nombreCarpeta = "Alumnos Golden English";
            string rutaCarpeta = Path.Combine(rutaDocumentos, nombreCarpeta);
            string nuevoNombre = nombre +" "+apellido+".jpg";
            string rutaNuevaImagen,nombreCopia;     

            try
            {
                Directory.CreateDirectory(rutaCarpeta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la carpeta: " + ex.Message);
            }

            try
            {
                rutaNuevaImagen = Path.Combine(rutaCarpeta, nuevoNombre);
                nombreCopia = rutaNuevaImagen.Substring(0, rutaNuevaImagen.Length - 4);

                if (File.Exists(rutaNuevaImagen))
                {
                    int contador = 1;
                    while (File.Exists(rutaNuevaImagen))
                    {
                        nuevoNombre = nombreCopia+"_" + contador.ToString() + ".jpg";
                        rutaNuevaImagen = Path.Combine(rutaNuevaImagen, nuevoNombre);
                        contador++;
                    }
                    File.Copy(ruta, rutaNuevaImagen);
                    return rutaNuevaImagen;
                }
                else {
                    File.Copy(ruta, rutaNuevaImagen);
                    ruta = rutaNuevaImagen;
                }
            }
            catch (Exception ex)
            {
                try
                {
                    Image imagen = pb.Image;
                    rutaNuevaImagen = Path.Combine(rutaCarpeta, nuevoNombre);
                    nombreCopia = rutaNuevaImagen.Substring(0, rutaNuevaImagen.Length - 4);
                    if (File.Exists(rutaNuevaImagen))
                    {
                        int contador = 1;
                        while (File.Exists(rutaNuevaImagen))
                        {
                            nuevoNombre = nombreCopia + "_" + contador.ToString() + ".jpg";
                            rutaNuevaImagen = Path.Combine(rutaNuevaImagen, nuevoNombre);
                            contador++;
                        }
                        imagen.Save(rutaNuevaImagen);
                        return rutaNuevaImagen;
                    }
                    else
                    {
                        imagen.Save(rutaNuevaImagen);
                        ruta = rutaNuevaImagen;
                    }
                }
                catch {
                    MessageBox.Show("Selecciona una imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return ruta;

        }
        public static string crearImagenMaestro(string ruta, string nombre, string apellido, PictureBox pb)
        {
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nombreCarpeta = "Maestros Golden English";
            string rutaCarpeta = Path.Combine(rutaDocumentos, nombreCarpeta);
            string nuevoNombre = nombre + " " + apellido + ".jpg";
            string rutaNuevaImagen, nombreCopia;

            try
            {
                Directory.CreateDirectory(rutaCarpeta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la carpeta: " + ex.Message);
            }

            try
            {
                rutaNuevaImagen = Path.Combine(rutaCarpeta, nuevoNombre);
                nombreCopia = rutaNuevaImagen.Substring(0, rutaNuevaImagen.Length - 4);

                if (File.Exists(rutaNuevaImagen))
                {
                    int contador = 1;
                    while (File.Exists(rutaNuevaImagen))
                    {
                        nuevoNombre = nombreCopia + "_" + contador.ToString() + ".jpg";
                        rutaNuevaImagen = Path.Combine(rutaNuevaImagen, nuevoNombre);
                        contador++;
                    }
                    File.Copy(ruta, rutaNuevaImagen);
                    return rutaNuevaImagen;
                }
                else
                {
                    File.Copy(ruta, rutaNuevaImagen);
                    ruta = rutaNuevaImagen;
                }
            }
            catch (Exception ex)
            {
                try
                {
                    Image imagen = pb.Image;
                    rutaNuevaImagen = Path.Combine(rutaCarpeta, nuevoNombre);
                    nombreCopia = rutaNuevaImagen.Substring(0, rutaNuevaImagen.Length - 4);
                    if (File.Exists(rutaNuevaImagen))
                    {
                        int contador = 1;
                        while (File.Exists(rutaNuevaImagen))
                        {
                            nuevoNombre = nombreCopia + "_" + contador.ToString() + ".jpg";
                            rutaNuevaImagen = Path.Combine(rutaNuevaImagen, nuevoNombre);
                            contador++;
                        }
                        imagen.Save(rutaNuevaImagen);
                        return rutaNuevaImagen;
                    }
                    else
                    {
                        imagen.Save(rutaNuevaImagen);
                        ruta = rutaNuevaImagen;
                    }
                }
                catch
                {
                    MessageBox.Show("Selecciona una imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return ruta;

        }
        public static void SoloNumeros(KeyPressEventArgs e)
        {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
         }
        public static void abrirForm(Form formHijo, Panel pnl)
        {
            if (actualFormHijo != null)
            {
                actualFormHijo.Close();
            }
            actualFormHijo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnl.Controls.Add(formHijo);
            pnl.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        public static DataGridView dgListaAlumno( DataGridView dg)
        {
            string consulta = "select idAlumno,nomAlumno,apeAlumno,numKardex,fotoAlumno from alumno " +
                "where status = 1 order by numKardex asc";
            dg.DataSource=conexion.tablaConsulta(consulta);
            diseñosDG.alumnos(dg);
            return dg;
        }
        public static void buscador(string cadena, DataGridView dg)
        {
            string consulta;
            consulta = "select idAlumno,nomAlumno,apeAlumno,numKardex,fotoAlumno from alumno where nomAlumno like '%" + cadena + "%' or apeAlumno like '%" + cadena + "%'" +
                " or  numKardex like '%" + cadena + "%' and status =1 order by numKardex asc";
            dg.DataSource = conexion.tablaConsulta(consulta);
        }
        public static string crearCarpeta()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nombre = "Reportes Golden English";
            string rutaCarpeta = Path.Combine(ruta, nombre);
            try
            {
                if (Directory.Exists(rutaCarpeta))
                {
                }
                else
                {
                    Directory.CreateDirectory(rutaCarpeta);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la carpeta: " + ex.Message);
            }
            return rutaCarpeta;
        }

        public static Label FraseMotivadoras(Label lbl)
        {
            List<string> frasesMotivadoras = new List<string>
            {
                "Try to leave the Earth a better place than when you arrived. - Sidney Sheldon",
                "All growth is a leap in the dark. - Henry Miller",
                "The price of greatness is responsibility. - Winston Churchill",
                "The pursuit of perfection often impedes improvement. - George F. Will",
                "The quality of the imagination is to flow and not to freeze. - Ralph Waldo Emerson",
                "Zeal without knowledge is fire without light. - Thomas Fuller, M.D",
                "The world of achievement has always belonged to the optimist. - Harold Wilkins",
                "There is no elevator to success. You have to take the stairs. - Someone",
                "You will never leave where you are, until you decide where you'd rather be. - Dexter Yager",
                "Just go out there and do what you've got to do. - Martina Navratilova",
                "Motivation is that gets you started. Habits is what keeps you going. - Jim Ryun",
                "You will never find time for anything. If you want time you must make it. - Charles Buxton",
                "If we did all we were capable of doing, we would literally astonish ourselves. - Thomas Edison",
                "Fiddlesticks - Teacher Andrea",
            };

            Random random = new Random();
            int indiceFrase = random.Next(frasesMotivadoras.Count);
            string fraseMotivadora = frasesMotivadoras[indiceFrase];

            lbl.Text = fraseMotivadora;
            return lbl;
        }

    }
}

