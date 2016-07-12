using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public class SQLAnalycer
    {
        private string query;

        public SQLAnalycer(string query)
        {
            this.query = query;
        }

        public DataTable ExecuteQuery()
        {
            try
            {
                return ControladorBD.opeBD.QueryATab(this.query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
