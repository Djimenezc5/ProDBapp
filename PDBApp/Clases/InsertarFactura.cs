using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases
{
    class InsertarFactura
    {
        Conexion cn = new Conexion();

        public string Factura(string sucursal, string empleado, string cliente, string fecha, string total_fac)
        {
            SqlCommand da = new SqlCommand("INSERCIONENCABEZADOFACTURA", cn.LeerCadena());
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@ID_SUCURSAL", Int32.Parse(sucursal));
            da.Parameters.AddWithValue("@ID_EMPLEADO", Int32.Parse(empleado));
            da.Parameters.AddWithValue("@ID_CLIENTE", Int32.Parse(cliente));
            da.Parameters.AddWithValue("@FECHA", DateTime.Parse(fecha));
            da.Parameters.AddWithValue("@TOTAL_FAC", float.Parse(total_fac));
            da.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            da.ExecuteNonQuery();
            string Idfac = da.Parameters["@RETURN_VALUE"].Value.ToString();
            return Idfac;
        }
    }
}
