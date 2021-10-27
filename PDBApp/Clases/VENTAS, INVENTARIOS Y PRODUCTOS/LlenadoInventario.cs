using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.VENTAS__INVENTARIOS_Y_PRODUCTOS
{
    class LlenadoInventario
    {
        Conexion cn = new Conexion();

        public void LlenadoInven(string idInven ,string idProd, string fecha, string cantidad)
        {
            SqlCommand da = new SqlCommand("LLENADOINVENTARIO", cn.LeerCadena());
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@id_inven", Int32.Parse(idInven));
            da.Parameters.AddWithValue("@id_pro", idProd);
            da.Parameters.AddWithValue("@fecha", DateTime.Parse(fecha));
            da.Parameters.AddWithValue("@cantidad", Int32.Parse(cantidad));
            da.ExecuteNonQuery();
        }
    }
}
