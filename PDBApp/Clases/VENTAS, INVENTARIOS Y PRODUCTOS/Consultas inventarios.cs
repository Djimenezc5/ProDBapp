using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.VENTAS__INVENTARIOS_Y_PRODUCTOS
{
    class Consultas_inventarios
    {
        Conexion cn = new Conexion();

        public DataTable MayorCantidad()
        {
            SqlDataAdapter da = new SqlDataAdapter("MAYORCANTIDAD", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable MenorCantidad()
        {
            SqlDataAdapter da = new SqlDataAdapter("MAYORMENOR", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable TOP10MENOR()
        {
            SqlDataAdapter da = new SqlDataAdapter("TOPMENOR", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
