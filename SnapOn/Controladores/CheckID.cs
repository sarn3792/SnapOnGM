using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public class CheckID
    {
        private string ID;
        private string table;
        public CheckID(string ID, string table)
        {
            this.ID = ID;
            this.table = table;
        }

        public bool Check(bool isMain)
        {
            string query = String.Empty;
            if(isMain)
                query = String.Format("select * from {0} where PKItem = '{1}' ", table, ID);
            else
                query = String.Format("select * from {0} where FKItem = '{1}' ", table, ID);

            return ControladorBD.opeBD.QueryATab(query).Rows.Count > 0 ? true : false;
        }
    }
}
