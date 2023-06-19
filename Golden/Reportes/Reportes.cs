using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using Golden.Clases;

namespace Golden
{
    public partial class Reportes : Form
    {
        
        public Reportes()
        {
            InitializeComponent();
            /*MessageBox.Show(DateTime.Now.Month.ToString());
            string consulta = "";
            consulta = "select alumno.idAlumno,concat(alumno.nomAlumno,' ',alumno.apeAlumno) as nombre,alumno.numKardex,pagos.numCuota,pagos.monto from alumno " +
                "inner join pagos on alumno.idAlumno=pagos.idAlumno where MONTH(pagos.mes) =" + DateTime.Now.Month.ToString() + "and YEAR(pagos.mes)=" + DateTime.Now.Year;
            dgReporte.DataSource = conexion.tablaConsulta(consulta);
            diseñosDG.reporte(dgReporte);
            lblVista.Text = "Vista previa de reporte del mes actual" ;*/
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            string ruta = accionesComunes.crearCarpeta();
            try {
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
                    hoja.Range["C1:F1"].Merge();
                    hoja.Range["H1:I1"].Merge();
                    hoja.Range["F2:G2"].Merge();
                    hoja.Range["B1"].ColumnWidth = 40;
                    hoja.Range["C1"].ColumnWidth = 10;
                    hoja.Range["D1"].ColumnWidth = 13;
                    hoja.Range["E1"].ColumnWidth = 23;
                    hoja.Range["F1"].ColumnWidth = 18;
                    hoja.Range["G1"].ColumnWidth = 14;
                    hoja.Range["C1:F1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    hoja.Range["G1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; ;
                    hoja.Range["F2:G2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; ;
                    hoja.Range["B3:F3"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; ;
                    // La segunda línea Asigna el nombre del encabezado.
                    hoja.Range["B1"].Value = "San Buenaventura, Coah";
                    hoja.Range["C1:F1"].Value = "RCM DE COBRANZA";
                    hoja.Range["G1"].Value = "RCM No" + txtRCM.Text;
                    hoja.Range["F2:G2"].Value = "ADMINISTRATIVAS";
                    hoja.Range["B3"].Value = "NOMBRE DE TITULAR";
                    hoja.Range["C3"].Value = "MAT";
                    hoja.Range["D3"].Value = "CUOTA";
                    hoja.Range["E3"].Value = "EFECTIVO";
                    hoja.Range["F3"].Value = "CANTIDAD";
                    // La tercera línea asigna negrita al titulo.
                    hoja.Range["B1:F1"].Font.Bold = true;
                    hoja.Range["A3:F3"].Font.Bold = true;
                    hoja.Range["F2:G2"].Font.Bold = true;
                    //Colores 
                    hoja.Range["C1:F1"].Interior.Color = Color.Black;
                    hoja.Range["A3:F3"].Interior.Color = Color.Black;
                    hoja.Range["C1:F1"].Font.Color = Color.White;
                    hoja.Range["A3:F3"].Font.Color = Color.White;

                    // La cuarta línea signa un Size a titulo de 15.
                    hoja.Range["B1:F1"].Font.Size = 20;
                    hoja.Range["A3:F3"].Font.Size = 20;
                    hoja.Range["G1"].Font.Size = 14;
                    hoja.Range["F2:G2"].Font.Size = 14;

                    //Llena datos del data al Excel
                    int k = 4;
                    for (int i = 0; i < dgReporte.RowCount; i++)
                    {
                        for (int j = 0; j < dgReporte.ColumnCount; j++)
                        {
                            if (j == 1)
                            {
                                string mayus = dgReporte.Rows[i].Cells[j].Value.ToString();
                                hoja.Cells[k, j + 1] = mayus.ToUpper();
                            }
                            else
                            {
                                hoja.Cells[k, j + 1] = dgReporte.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        k++;
                    }
                    k = k - 1;
                    hoja.Range["B4:B" + k].Font.Bold = true;
                    hoja.Range["A4:F" + k].Font.Size = 12;
                    hoja.Range["E4:E" + k].Copy(hoja.Cells[k - 1, 6]);
                    hoja.Range["A4:F" + k].Borders.Color = Excel.XlRgbColor.rgbBlack;
                    hoja.Range["E4:F" + k].NumberFormat = "$#,##0.00";
                    hoja.Cells[k + 2, 5].Formula = "=SUM(E4:E" + k + ")";
                    hoja.Cells[k + 2, 6].Formula = "=SUM(F4:F" + k + ")";
                    ruta = ruta + "/Reeporte Cobranza-"+cbMes.Text+"de"+DateTime.Now.Year.ToString()+".xlsx";
                    MessageBox.Show(ruta);
                    libro.SaveAs(ruta);
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
            consulta = "select alumno.idAlumno,concat(alumno.nomAlumno,' ',alumno.apeAlumno) as nombre,alumno.numKardex,pagos.numCuota,pagos.monto from alumno " +
                "inner join pagos on alumno.idAlumno=pagos.idAlumno where MONTH(pagos.mes) ="+ (cbMes.SelectedIndex+1) + "and YEAR(pagos.mes)="+DateTime.Now.Year;
            dgReporte.DataSource = conexion.tablaConsulta(consulta);
            diseñosDG.reporte(dgReporte);
            lblVista.Text = "Vista previa de reporte del mes "+cbMes.Text;
            lblVista.Visible = true;
            dgReporte.Visible = true;
        }

        private void txtRCM_KeyPress(object sender, KeyPressEventArgs e)
        {
            accionesComunes.SoloNumeros(e);
        }
    }
}
