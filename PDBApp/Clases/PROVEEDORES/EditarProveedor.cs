using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.PROVEEDORES
{
    class EditarProveedor
    {
        Conexion cn = new Conexion();
        public void EditProd(string idpr, string nombre, string dep, string direc, string tel, string correo, string idest)
        {
            SqlCommand da = new SqlCommand("EDITARPREVEEDOR", cn.LeerCadena());
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@IDPROV", Int32.Parse(idpr));
            da.Parameters.AddWithValue("@NOMBRE", nombre);
            da.Parameters.AddWithValue("@IDDEPA", dep);
            da.Parameters.AddWithValue("@DIRECC", direc);
            da.Parameters.AddWithValue("@TELEFO", tel);
            da.Parameters.AddWithValue("@CORREO", correo);
            da.Parameters.AddWithValue("@IDESTA", idest);
            da.ExecuteNonQuery();
        }
    }
}
