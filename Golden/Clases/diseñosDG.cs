using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golden.Clases
{
    public static class diseñosDG
    {
        public static DataGridView alumnos(DataGridView dg)
        {
            dg.Columns[0].HeaderText = "ID";
            dg.Columns[1].HeaderText = "Nombres";
            dg.Columns[2].HeaderText = "Apellidos";
            dg.Columns[3].HeaderText = "Kardex";
            dg.Columns[4].Visible = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            return dg;
        }
        public static DataGridView leccionesKardex(DataGridView dg)
        {
            dg.Columns[0].HeaderText = "Leccion";
            dg.Columns[1].HeaderText = "Nombre";
            dg.Columns[2].HeaderText = "Warm Up";
            dg.Columns[3].HeaderText = "Workshop";
            dg.Columns[4].HeaderText = "Audio";
            dg.Columns[5].HeaderText = "Gathering";
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;   
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[0].ReadOnly = true;
            dg.Columns[1].ReadOnly = true;
            return dg;
        }
        public static DataGridView pagos(DataGridView dg)
        {
            dg.Columns[0].HeaderText = "ID";
            dg.Columns[1].HeaderText = "Nombre";
            dg.Columns[2].HeaderText = "Apellido";
            dg.Columns[3].HeaderText = "Kardex";
            dg.Columns[4].HeaderText = "Numero de cuota";
            dg.Columns[5].HeaderText = "Total de cuota";
            dg.Columns[6].HeaderText = "Monto";
            dg.Columns[7].HeaderText = "Mes";
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            return dg;
        }
        public static DataGridView reporte(DataGridView dg)
        {
            dg.Columns[0].HeaderText = "ID";
            dg.Columns[1].HeaderText = "Nombre del titular";
            dg.Columns[2].HeaderText = "Kardex";
            dg.Columns[3].HeaderText = "Numero de cuota";
            dg.Columns[4].HeaderText = "Monto";
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            return dg;
        }
        public static DataGridView matriculas(DataGridView dg)
        {
            dg.Columns[0].HeaderText = "ID";
            dg.Columns[1].HeaderText = "Nombre del titular";
            dg.Columns[2].HeaderText = "Kardex";
            dg.Columns[3].HeaderText = "Ejecutivo";
            dg.Columns[4].HeaderText = "Monto";
            dg.Columns[5].HeaderText = "Metodo de pago";
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            return dg;
        }
        public static DataGridView asignaciones(DataGridView dg)
        {
            dg.Columns[0].HeaderText = "ID";
            dg.Columns[1].HeaderText = "Kardex";
            dg.Columns[2].HeaderText = "Nombre del titular";
            dg.Columns[3].HeaderText = "Direccion";
            dg.Columns[4].HeaderText = "Numero de telefono";
            dg.Columns[5].HeaderText = "Enganche";
            dg.Columns[6].HeaderText = "Plan";
            dg.Columns[7].HeaderText = "Metodo de pago";
            dg.Columns[8].HeaderText = "Ejecutivo";
            dg.Columns[9].HeaderText = "Estrategia";
            dg.Columns[10].HeaderText = "Observacion";
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            return dg;
        }
        public static DataGridView bajaMaestro(DataGridView dg)
        {
            dg.Columns[0].HeaderText = "ID";
            dg.Columns[1].HeaderText = "Nombres";
            dg.Columns[2].HeaderText = "Apellidos";
            dg.Columns[3].HeaderText = "Telefono";
            dg.Columns[4].HeaderText = "Foto";
            dg.Columns[4].Visible = false;
            dg.Columns[5].HeaderText = "Estado";
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            return dg;
        }
        public static DataGridView bajaAlumno(DataGridView dg)
        {
            dg.Columns[0].HeaderText = "ID";
            dg.Columns[1].HeaderText = "Nombres";
            dg.Columns[2].HeaderText = "Apellidos";
            dg.Columns[3].HeaderText = "Kardex";
            dg.Columns[4].HeaderText = "Numero";
            dg.Columns[5].HeaderText = "Titular";
            dg.Columns[6].HeaderText = "Foto";
            dg.Columns[6].Visible = false;
            dg.Columns[7].HeaderText = "Estado";
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            return dg;
        }
    }
}

