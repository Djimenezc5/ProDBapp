using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.VENTAS__INVENTARIOS_Y_PRODUCTOS
{
    class AñadirProducto
    {
        Conexion cn = new Conexion();
        public void LlenadoProducto(string idPro, string idProv, string precio, string nom, string des, string status)
        {
            SqlCommand da = new SqlCommand("LLENADOPRODUCTO", cn.LeerCadena());
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@ID_PRO", idPro);
            da.Parameters.AddWithValue("@ID_PROV", Int32.Parse(idProv));
            da.Parameters.AddWithValue("@PRECIO", float.Parse(precio));
            da.Parameters.AddWithValue("@NOM", nom);
            da.Parameters.AddWithValue("@DES", des);
            da.Parameters.AddWithValue("@ESTATUS", status);
            da.ExecuteNonQuery();
        }
    }
}
