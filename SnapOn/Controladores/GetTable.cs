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
            this.table = table + "Layout";
            this.itemsTable = table + "Items";
        }

        public GetTable(string table, bool isNotMain)
        {
            if (isNotMain)
            {
                this.itemsTable = table + "Items";
                this.table = table + "Querys";
            }
            else
            {
                this.table = table + "Layout"; ;
                this.itemsTable = table + "Items";
            }
        } 

        public DataTable GetDataSource()
        {
            DataTable data = new DataTable();
            if (this.table != ComboboxDefaultValue.defaultValues.Value)
            {
                string query = String.Format(@"SELECT *
                                               FROM {0} ITMS LEFT JOIN {1} VH ON VH.FKItem = ITMS.PKItem
                                               Order by OrderInserted", this.itemsTable, this.table);
                data = ControladorBD.opeBD.QueryATab(query);
            }

            return data;
        }
    }
}
