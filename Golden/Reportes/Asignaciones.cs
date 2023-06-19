using Golden.Clases;
using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Golden
{
    public partial class Asignaciones : Form
    {
        public Asignaciones()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            string ruta = accionesComunes.crearCarpeta();
            if (dgAsignaciones.RowCount == 0)
            {
                MessageBox.Show("Ingres datos para poder generar un reporte","Falta de datos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                if (cbMes.SelectedIndex > -1)
                {
                    #region"Excel"

                    Excel.Application excel = default(Excel.Application);
                    Excel.Workbook libro = default(Excel.Workbook);
                    Excel.Worksheet hoja = default(Excel.Worksheet);

                    // Iniciamos una instancia a Excel, y Hacemos visibles para ver como se va creando el reporte, 
                    // podemos hacerlo visible al final si se desea.
                    excel = new Excel.Application();

                    /* Ahora creamos un nuevo documento y seleccionamos la primera hoja del 
                     * documento en la cual crearemos nuestro informe. 
                     */
                    // Creamos una instancia del Workbooks de excel.            
                    libro = excel.Workbooks.Add();
                    // Creamos una instancia de la primera hoja de trabajo de excel            
                    hoja = libro.Worksheets[1];
                    hoja.Visible = Excel.XlSheetVisibility.xlSheetVisible;

                    // Hacemos esta hoja la visible en pantalla 
                    // (como seleccionamos la primera esto no es necesario
                    // si seleccionamos una diferente a la primera si lo
                    // necesitariamos).
                    hoja.Activate();

                    // Crear el encabezado de nuestro informe.
                    // La primera línea une las celdas y las convierte un en una sola.
                    // 
                    hoja.Range["B1:J1"].Merge();
                    hoja.Range["B2:J2"].Merge();
                    hoja.Range["B3:J3"].Merge();
                    hoja.Range["A1"].ColumnWidth = 5;
                    hoja.Range["B1"].ColumnWidth = 10;
                    hoja.Range["C1"].ColumnWidth = 10;
                    hoja.Range["D1"].ColumnWidth = 70;
                    hoja.Range["E1"].ColumnWidth = 20;
                    hoja.Range["F1"].ColumnWidth = 15;
                    hoja.Range["G1"].ColumnWidth = 25;
                    hoja.Range["H1"].ColumnWidth = 25;
                    hoja.Range["I1"].ColumnWidth = 25;
                    hoja.Range["J1"].ColumnWidth = 40;
                    hoja.Range["B1:J1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    hoja.Range["B2:J2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    hoja.Range["A4:J4"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    // La segunda línea Asigna el nombre del encabezado.
                    hoja.Range["B1:J1"].Value = "RECORD DE PRODUCCION SAN BUENAVENTURA COAHUILA";
                    hoja.Range["B2:J2"].Value = "MES DE " + cbMes.Text.ToUpper() +" "+DateTime.Today.Year.ToString();
                    hoja.Range["C4"].Value = "MAT";
                    hoja.Range["D4"].Value = "TITULAR";
                    hoja.Range["E4"].Value = "ENGANCHE";
                    hoja.Range["F4"].Value = "PLAN";
                    hoja.Range["G4"].Value = "METODO DE PAGO";
                    hoja.Range["H4"].Value = "EJECUTIVO";
                    hoja.Range["I4"].Value = "ESTRATEGIA";
                    hoja.Range["J4"].Value = "OBSERVACIONES";

                    // La tercera línea asigna negrita al titulo.   
                    hoja.Range["B1:J1"].Font.Bold = true;

                    //Colores 
                    hoja.Range["B3:J3"].Interior.Color = Color.Black;
                    hoja.Range["B4:J4"].Interior.Color = Color.LightGray;

                    // La cuarta línea signa un Size a titulo de 15.
                    hoja.Range["B1:J1"].Font.Size = 28;
                    hoja.Range["B2:B2"].Font.Size = 28;
                    hoja.Range["B4:J4"].Font.Size = 14;

                    //Llena datos del data al Excel
                    int k = 5;
                    for (int i = 0; i < dgAsignaciones.RowCount; i++)
                    {
                        for (int j = 0; j < dgAsignaciones.ColumnCount; j++)
                        {
                            if (j == 0)
                            {
                                hoja.Cells[k+1, j + 2] = i + 1;
                                hoja.Cells[k + 1, j + 3]= dgAsignaciones.Rows[i].Cells[j + 1].Value.ToString();
                                j = j + 1;
                            }
                            else
                            if (j == 2)
                            {
                                string mayus = dgAsignaciones.Rows[i].Cells[j].Value.ToString();
                                hoja.Cells[k, j + 2] =mayus.ToUpper();
                                hoja.Cells[k+1, j + 2] = dgAsignaciones.Rows[i].Cells[j+1].Value.ToString();
                                hoja.Cells[k+2, j + 2] = dgAsignaciones.Rows[i].Cells[j+2].Value.ToString();
                                j = j + 2;  
                            }
                            else
                            {
                                hoja.Cells[k+1, j] = dgAsignaciones.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        k=k+3;
                        i++;
                    }
                    k = k - 1;
                    hoja.Range["A4:J" + k].Font.Size = 12;
                    hoja.Range["E4:E" + k].NumberFormat = "$#,##0.00";
                    hoja.Cells[k + 2, 5].Formula = "=SUM(E4:E" + k + ")";
                    hoja.Range["D5:D" + k].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                    hoja.Range["B5:C" + k].HorizontalAlignment= Excel.XlHAlign.xlHAlignCenter;
                    hoja.Range["F5:I" + k].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    excel.Visible = true;
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(hoja);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(libro);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                    #endregion
                }
                else
                {
                    MessageBox.Show("Ingrese todos los campos", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            }
            catch
            {
                MessageBox.Show("Ingrese un pago antes de crear el reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "";
            consulta = "select alumno.idAlumno,alumno.numKardex,concat(alumno.nomAlumno,' ',alumno.apeAlumno) as nombre,alumno.dirAlumno, alumno.numAlumno, registro.enganche,registro.pln,"+
            "registro.modoPago,registro.ejecutivo,registro.estrategia,registro.observacion"+
            " from alumno inner join registro on alumno.idAlumno = registro.idAlumno where MONTH(registro.fechaRegistro) = "+ (cbMes.SelectedIndex + 1) + " and YEAR(registro.fechaRegistro)= "+DateTime.Now.Year.ToString();
            dgAsignaciones.DataSource = conexion.tablaConsulta(consulta);
            diseñosDG.asignaciones(dgAsignaciones);
            lblVista.Text = "Vista previa de reporte del mes " + cbMes.Text;
            lblVista.Visible = true;
            dgAsignaciones.Visible = true;
        }
    }
}
