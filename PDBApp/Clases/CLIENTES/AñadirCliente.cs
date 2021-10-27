using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.CLIENTES
{
    class AñadirCliente
    {
        Conexion cn = new Conexion();
        public void RegistroCliente(string nom, string ape, string telC, string telR, string Dep, string DirRes,  string CorrEle, string NIT)
        {
            SqlCommand da = new SqlCommand("AÑADIRCLIENTE", cn.LeerCadena());
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@NOM", nom);
            da.Parameters.AddWithValue("@APE", ape);
            da.Parameters.AddWithValue("@TEL_C", telC);
            da.Parameters.AddWithValue("@TEL_R", telR);
            da.Parameters.AddWithValue("@ID_DEP", Dep);
            da.Parameters.AddWithValue("@DIR", DirRes);
            da.Parameters.AddWithValue("@CORR_ELE", CorrEle);
            da.Parameters.AddWithValue("@NIT", NIT);
            da.ExecuteNonQuery();
        }
    }
}
