using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases
{
    class InsertarDetalleFactura
    {

        Conexion cn = new Conexion();

        public void Detalle_Factura(string id_fac, string Id_prod, string TP, string Cantidad, string Precio)
        {
            SqlCommand da = new SqlCommand("INSERCIONDF", cn.LeerCadena());
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@Id_fac", Int32.Parse(id_fac));
            da.Parameters.AddWithValue("@Id_pro", Id_prod);
            da.Parameters.AddWithValue("@IdTipo_pago", TP);
            da.Parameters.AddWithValue("@cantidad", Int32.Parse(Cantidad));
            da.Parameters.AddWithValue("@precio", float.Parse(Precio));
            da.ExecuteNonQuery();
        }
        public string Consulta_precio(string idProd) 
        {
            DataTable pre = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter();
            SqlCommand da = new SqlCommand("PRECIOPRODUCTO", cn.LeerCadena());
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@Id_pro", idProd);
            adap.SelectCommand = da;
            adap.Fill(pre);
            string precio = string.Empty;
            if (pre.Rows.Count > 0)
            {
                precio = pre.Rows[0][0].ToString();
            }
            return precio;
        }

        public DataTable MostrarFactura(string idf)
        {
            DataTable df = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter();
            SqlCommand da = new SqlCommand("CANTIDADDF", cn.LeerCadena());
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@idf", idf);
            adap.SelectCommand = da;
            adap.Fill(df);
            return df;
        }
    }
}
