using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.EMPLEADOS
{
    class Ventasempleados
    {
        Conexion cn = new Conexion();
        public DataTable VentasEmpleados()
        {
            SqlDataAdapter da = new SqlDataAdapter("VENTAS DE EMPLEADOS", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
