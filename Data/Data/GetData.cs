using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class GetData
    {
        Conexion conexion = new Conexion();

        string cn = Conexion.conection;


        public DataTable GetUsuarios(string sql) {


            DataTable DtResultado = new DataTable("tabla");
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                string consulta = sql;
                SqlCon.ConnectionString = cn;
                SqlCommand SqlCmd = new SqlCommand(consulta, SqlCon);
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            return DtResultado;

        }
    }
}
