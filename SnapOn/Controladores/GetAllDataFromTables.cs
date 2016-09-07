using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SnapOn
{
    public class GetAllDataFromTables
    {
        private String tableName;
        public GetAllDataFromTables(String tableName)
        {
            this.tableName = tableName;
        }
        public String GetData(String periodo)
        {
            String result = String.Empty;
            String separator = " ";
            DataTable tableInformation = (new GetTable(tableName, 1)).GetDataSource(periodo);

            foreach(DataColumn column in tableInformation.Columns) // Save the headers
            {
                if(!IsDefaultValue(column.ToString()))
                    result += column.ToString() + separator;
            }
            result += Environment.NewLine; //new line

            foreach(DataRow row in tableInformation.Rows)
            {
                foreach(DataColumn column in tableInformation.Columns)
                {
                    if(!IsDefaultValue(column.ToString()))
                        result += row[column].ToString() == String.Empty || row[column] == DBNull.Value ? "0" + separator : row[column].ToString() + separator;
                }
                result += Environment.NewLine; //new line
            }
            return result;
        }

        private bool IsDefaultValue(String value)
        {
            return value == "OrderInserted" || value == "FKItem" ? true : false;
        }
    }
}
