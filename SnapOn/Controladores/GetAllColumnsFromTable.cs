using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public class GetAllColumnsFromTable
    {
        private string table = string.Empty;

        public GetAllColumnsFromTable(string table)
        {
            this.table = table;
        }

        public DataTable Get()
        {
            DataTable aux = new DataTable();
            try
            {
                aux = ControladorBD.opeBD.QueryATab(String.Format(@"SELECT COLUMN_NAME 
                                                                    FROM INFORMATION_SCHEMA.COLUMNS
                                                                    WHERE TABLE_NAME = '{0}'", this.table));
            } catch(Exception ex)
            {
                throw ex;
            }

            return aux;
        }
    }
}
