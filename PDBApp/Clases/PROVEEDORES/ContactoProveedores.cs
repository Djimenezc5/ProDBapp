using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.PROVEEDORES
{
    class ContactoProveedores
    {
        Conexion cn = new Conexion();

        public DataTable ContactoP()
        {
            SqlDataAdapter da = new SqlDataAdapter("CONTACTO PROVEEDORES", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
