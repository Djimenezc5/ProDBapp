using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.SUCURSALES
{
    class ConsultaSucursal
    {
        Conexion cn = new Conexion();
        public DataTable ConsultarDatosSucursal()
        {
            SqlDataAdapter da = new SqlDataAdapter("CONSULTASUCURSALES", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
