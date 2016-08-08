using System;
using System.Collections.Generic;
using System.Data;
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
        private string fkItem;

        public SaveQuery(string tableName, string columnName, string columnValue, string fkItem)
        {
            this.tableName = tableName;
            this.columnName = columnName;
            this.columnValue = columnValue;
            this.fkItem = fkItem;
        }

        public void Save()
        {
            String query = String.Empty; 
            query = String.Format(@"UPDATE {0} SET {1}='{2}' WHERE FKItem = '{3}' ", tableName, columnName, columnValue, fkItem);
            //MODIFY IT TO ALLOW ''

            try
            {
                ControladorBD.opeBD.IniciarTransaccion();
                ControladorBD.opeBD.EjeQuery(query);
                ControladorBD.opeBD.FinalizarTransaccion();
            }
            catch (Exception ex)
            {
                ControladorBD.opeBD.CancelarTransaccion(); //rollback
                throw new Exception(String.Format("Ha ocurrido la siguiente excepción : {0}", ex.Message));
            }
        }
    }
}
