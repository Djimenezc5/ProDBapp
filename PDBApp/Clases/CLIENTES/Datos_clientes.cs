using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDBApp.Clases;

namespace PDBApp.Clases.CLIENTES
{
    class Datos_clientes
    {
        Conexion cn = new Conexion();

        public DataTable MostrarClientes()
        {
            SqlDataAdapter da = new SqlDataAdapter("MOSTRARDATOSCLIENTES",cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
