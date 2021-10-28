using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.SUCURSALES
{
    class Menosventas
    {
        Conexion cn = new Conexion();
        public DataTable ConsultarMenosVentasSucursal()
        {
            SqlDataAdapter da = new SqlDataAdapter("MENORVENTASSUCURSALES", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
