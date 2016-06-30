using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public class GetTable
    {
        string table = string.Empty;
        string itemsTable = string.Empty;

        public GetTable(string table)
        {
            this.table = table;
            this.itemsTable = table + "Items";
        }

        public DataTable GetDataSource()
        {
            DataTable data = new DataTable();
            if (this.table != ComboboxDefaultValue.defaultValues.Value)
            {
                string query = String.Format(@"SELECT *
                                               FROM {0} ITMS LEFT JOIN {1} VH ON VH.FKItem = ITMS.PKItem", this.itemsTable, this.table);
                data = ControladorBD.opeBD.QueryATab(query);
            }

            return data;
        }
    }
}
