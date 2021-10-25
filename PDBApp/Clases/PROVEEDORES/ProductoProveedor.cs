using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.PROVEEDORES
{
    class ProductoProveedor
    {
        Conexion cn = new Conexion();
        public DataTable ProductoP()
        {
            SqlDataAdapter da = new SqlDataAdapter("PRODUCTO_PROVEEDOR", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
