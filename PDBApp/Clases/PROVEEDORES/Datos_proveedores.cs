using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.PROVEEDORES
{
    class Datos_proveedores
    {
        Conexion cn = new Conexion();

        public DataTable MostrarDatosProveedor()
        {
            SqlDataAdapter da = new SqlDataAdapter("DATOSPROVEEDORES", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
