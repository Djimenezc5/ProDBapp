using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.EMPLEADOS
{
    class Datos_empleado
    {
        Conexion cn = new Conexion();

        public DataTable DatosEmpleados()
        {
            SqlDataAdapter da = new SqlDataAdapter("DATOS_EMPLEADO", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
