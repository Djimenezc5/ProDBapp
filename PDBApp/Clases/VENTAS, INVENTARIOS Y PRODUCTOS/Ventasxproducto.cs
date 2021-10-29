using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.VENTAS__INVENTARIOS_Y_PRODUCTOS
{
    class Ventasxproducto
    {
        Conexion cn = new Conexion();
        public DataTable Ventasporproducto()
        {
            SqlDataAdapter da = new SqlDataAdapter("VENTASPORPRODUCTO", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
