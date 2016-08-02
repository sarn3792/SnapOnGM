using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public class SaveQuery
    {
        private string tableName;
        private string columnName;
        private string columnValue;

        public SaveQuery(string tableName, string columnName, string columnValue)
        {
            this.tableName = tableName;
            this.columnName = columnName;
            this.columnValue = columnValue;
        }

        public void Save()
        {
            string query = String.Format("Insert into {0} ");
        }
    }
}
