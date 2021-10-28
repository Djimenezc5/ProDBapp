using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.SUCURSALES
{
    class Masventas
    {
        Conexion cn = new Conexion();
        public DataTable ConsultarMasVentasSucursal()
        {
            SqlDataAdapter da = new SqlDataAdapter("MAYORESVENTASSUCURSALES", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
