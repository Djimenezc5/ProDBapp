using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBApp.Clases.EMPLEADOS
{
    class EditarDatosEmpleado
    {
        Conexion cn = new Conexion();
        public void EdicionEmpleados(string idemp, string nom, string ape, string telC, string telR, string Dep, string DirRes, string CorrEle, string usu, string con, string pue, string ide )
        {
            SqlCommand da = new SqlCommand("ACTULIZACIONEMPLEADO", cn.LeerCadena());
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@ID_EMP", Int32.Parse(idemp));
            da.Parameters.AddWithValue("@NOM", nom);
            da.Parameters.AddWithValue("@APE", ape);
            da.Parameters.AddWithValue("@TEC", telC);
            da.Parameters.AddWithValue("@TER", telR);
            da.Parameters.AddWithValue("@IDD", Dep);
            da.Parameters.AddWithValue("@DIR", DirRes);
            da.Parameters.AddWithValue("@COE", CorrEle);
            da.Parameters.AddWithValue("@USU", usu);
            da.Parameters.AddWithValue("@CON", con);
            da.Parameters.AddWithValue("@PUE", pue);
            da.Parameters.AddWithValue("@IDE", ide);
            da.ExecuteNonQuery();
        }
    }
}
