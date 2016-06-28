using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libmx.BaseDatos;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SnapOn
{
    public class ControladorBD
    {
        public static OperacionesBD opeBD = new OperacionesBD
        {
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["localhost"].ToString()
        };
    }
}
