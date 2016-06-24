using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public class InsertNewColumn
    {
        public string table;

        public InsertNewColumn(string table)
        {
            this.table = table;
        }

        public bool Insert(string descriptionColumn)
        {
            try
            {
                ControladorBD.opeBD.IniciarTransaccion(); //begin tran

                String query = String.Format(@"IF NOT EXISTS 
                                               (SELECT 1 FROM syscolumns sc JOIN sysobjects so ON sc.id = so.id WHERE so.Name = '{0}' AND sc.Name = '{1}') 
                                                BEGIN ALTER TABLE {2} ADD {3} MONEY NULL 
                                                END", this.table, descriptionColumn, this.table, descriptionColumn);
                ControladorBD.opeBD.EjeQuery(query);

                ControladorBD.opeBD.FinalizarTransaccion(); //commit
            }
            catch (Exception ex)
            {
                ControladorBD.opeBD.CancelarTransaccion(); //rollback
                throw new Exception(String.Format("Ha ocurrido la siguiente excepción : {0}", ex.Message));
            }
            return true;
        }
    }
}
