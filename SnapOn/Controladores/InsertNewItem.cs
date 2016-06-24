using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public class InsertNewItem
    {
        private string table;
        public InsertNewItem(string table)
        {
            this.table = table + "Items";
        }

        public bool Insert(Item item)
        {
            //get FK from subgroup
            if (!new CheckID(item.ID, table).Check()) // if ID does not exist
            {
                string query = String.Format("INSERT INTO {0} values ('{1}','{2}')", this.table, item.ID, item.Descripcion);
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
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
