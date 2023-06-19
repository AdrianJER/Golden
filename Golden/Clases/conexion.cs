using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Golden.Clases
{
    public class conexion
    {
        static SqlConnection cnx;

        public static void conectar()
        {
            cnx = new SqlConnection("Data Source=localhost;Initial Catalog=Golden;Integrated Security=True;");
            cnx.Open();
        } 
        public static void desconectar()
        {
            cnx.Close();
            cnx=null;
        }
        public static DataTable tablaConsulta(string consulta)
        {
            DataTable dt = new DataTable();
            conectar();
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnx);
            da.Fill(dt);
            desconectar();
            return dt;
        }
        public static void insertarDatos(string consulta)
        {
            conectar();
            SqlCommand sqlCommand = new SqlCommand(consulta, cnx);
            sqlCommand.ExecuteNonQuery();
            desconectar();
        }
        public static int ultimoValorAgregado()
        {
            conectar();
            string consulta = "select idAlumno from (select idAlumno, row_number() over (order by idAlumno DESC) as rn from alumno) as subquery where rn = 1";
            SqlCommand sqlCommand = new SqlCommand(consulta, cnx);
            object resultado = sqlCommand.ExecuteScalar();
            int ultimaFila = Int32.Parse(resultado.ToString());
            desconectar();
            return ultimaFila;
        }
        public static void spCrearLecciones(int id)
        {
            conectar();
            SqlCommand cmd = new SqlCommand("sp_AgregarLeciones", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            desconectar();
        }

    }
}
