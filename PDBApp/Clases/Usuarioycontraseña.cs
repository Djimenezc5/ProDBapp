using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases
{
    class Usuarioycontraseña
    {
        Conexion cn = new Conexion();
        public string UsuarioyContraseña(string usu, string con)
        {
            SqlCommand da = new SqlCommand("USUARIO", cn.LeerCadena());
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@USU", usu);
            da.Parameters.AddWithValue("@CON", con);
            da.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            da.ExecuteNonQuery();
            string Idfac = da.Parameters["@RETURN_VALUE"].Value.ToString();
            return Idfac;
        }
    }
}
