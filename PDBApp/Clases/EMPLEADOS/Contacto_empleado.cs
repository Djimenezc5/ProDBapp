using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDBApp.Clases.EMPLEADOS;

namespace PDBApp.Clases.EMPLEADOS
{
    class Contacto_empleado
    {
        Conexion cn = new Conexion();

        public DataTable ContactoEmpleados()
        {
            SqlDataAdapter da = new SqlDataAdapter("CONTACTO_EMPLEADO", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
