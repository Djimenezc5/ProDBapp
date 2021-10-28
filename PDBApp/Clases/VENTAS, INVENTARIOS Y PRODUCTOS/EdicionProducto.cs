using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.VENTAS__INVENTARIOS_Y_PRODUCTOS
{
    class EdicionProducto
    {
        Conexion cn = new Conexion();
        public void EditProd(string idp, string idpr, string pre, string nombre, string desc, string idest)
        {
            SqlCommand da = new SqlCommand("EDITARPRODUCTO", cn.LeerCadena());
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@IDPROD", idp);
            da.Parameters.AddWithValue("@IDPROV", Int32.Parse(idpr));
            da.Parameters.AddWithValue("@PRECIO", float.Parse(pre));
            da.Parameters.AddWithValue("@NOMBRE", nombre);
            da.Parameters.AddWithValue("@DESCRI", desc);
            da.Parameters.AddWithValue("@IDESTA", idest);
            da.ExecuteNonQuery();
        }
    }
}
