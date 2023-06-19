using Golden.Clases;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using OfficeOpenXml.Style;
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
    public partial class ReporteMatriculas : Form
    {
        public ReporteMatriculas()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            string ruta=accionesComunes.crearCarpeta();
            try
            {
                if (cbMes.SelectedIndex > -1 && txtRCM.Text != "")
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
                    hoja.Range["A1:B1"].Merge();
                    hoja.Range["C1:F1"].Merge();
                    hoja.Range["G1:H1"].Merge();
                    hoja.Range["A1"].ColumnWidth = 5;
                    hoja.Range["B1"].ColumnWidth = 40;
                    hoja.Range["C1"].ColumnWidth = 10;
                    hoja.Range["D1"].ColumnWidth = 20;
                    hoja.Range["E1"].ColumnWidth = 20;
                    hoja.Range["F1"].ColumnWidth = 23;
                    hoja.Range["G1"].ColumnWidth = 20;
                    hoja.Range["C1:F1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    hoja.Range["G1:H1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; 
                    hoja.Range["A1:B1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; 
                    hoja.Range["A3:G3"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; 
                    // La segunda línea Asigna el nombre del encabezado.
                    hoja.Range["A1:B1"].Value = "San Buenaventura, Coah";
                    hoja.Range["C1:F1"].Value = "RCM DE MATRICULAS ADVAS.";
                    hoja.Range["G1:H1"].Value = "RCM No" + txtRCM.Text;
                    hoja.Range["B3"].Value = "NOMBRE DE TITULAR";
                    hoja.Range["C3"].Value = "MAT";
                    hoja.Range["D3"].Value = "EJECUTIVO";
                    hoja.Range["E3"].Value = "CANTIDAD";
                    hoja.Range["F3"].Value = "METODO DE PAGO";
                    hoja.Range["G3"].Value = "TOTAL";

                    // La tercera línea asigna negrita al titulo.   
                    hoja.Range["A1:H1"].Font.Bold = true;
                    hoja.Range["A3:G3"].Font.Bold = true;

                    //Colores 
                    hoja.Range["C1:F1"].Interior.Color = Color.Black;
                    hoja.Range["A3:G3"].Interior.Color = Color.LightGray;
                    hoja.Range["C1:F1"].Font.Color = Color.White;

                    // La cuarta línea signa un Size a titulo de 15.
                    hoja.Range["A1:B1"].Font.Size = 16;
                    hoja.Range["C1:F1"].Font.Size = 20;
                    hoja.Range["A3:G3"].Font.Size = 14;
                    hoja.Range["G1"].Font.Size = 14;

                    //Llena datos del data al Excel
                    int k = 4;
                    for (int i = 0; i < dgMatriculas.RowCount; i++)
                    {
                        for (int j = 0; j < dgMatriculas.ColumnCount; j++)
                        {
                            if (j == 0)
                            {
                                hoja.Cells[k, j + 1] = i+1;
                            }
                            else 
                            if (j == 1)
                            {
                                string mayus = dgMatriculas.Rows[i].Cells[j].Value.ToString();
                                hoja.Cells[k, j + 1] = mayus.ToUpper();
                            }
                            else
                            {
                                hoja.Cells[k, j + 1] = dgMatriculas.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        k++;
                        i++;
                    }
                    k = k - 1;
                    hoja.Range["B4:B" + k].Borders.Color = Excel.XlRgbColor.rgbBlack;
                    hoja.Range["B4:B" + k].Font.Bold = true;
                    hoja.Range["A4:F" + k].Font.Size = 12;
                    hoja.Range["E4:E" + k].NumberFormat = "$#,##0.00";
                    hoja.Range["E4:E" + k].Copy(hoja.Cells[k , 7]);
                    hoja.Cells[k + 2, 5].Formula = "=SUM(E4:E" + k + ")";
                    hoja.Cells[k + 2, 7].Formula = "=SUM(G4:G" + k + ")";
                    hoja.Range["C4:D"+k].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    hoja.Range["A4:A" + k].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    hoja.Range["F4:F" + k].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
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
            consulta = "select alumno.idAlumno,concat(alumno.nomAlumno,' ',alumno.apeAlumno) as nombre ,alumno.numKardex,registro.ejecutivo,registro.enganche,registro.modoPago " +
                "from alumno inner join registro on alumno.idAlumno=registro.idAlumno where MONTH(registro.fechaRegistro) ="+ (cbMes.SelectedIndex + 1) + " and YEAR(registro.fechaRegistro)= "+DateTime.Now.Year;
            dgMatriculas.DataSource = conexion.tablaConsulta(consulta);
            diseñosDG.matriculas    (dgMatriculas);
            lblVista.Text = "Vista previa de reporte del mes " + cbMes.Text;
            lblVista.Visible = true;
            dgMatriculas.Visible = true;
        }
    }
}
