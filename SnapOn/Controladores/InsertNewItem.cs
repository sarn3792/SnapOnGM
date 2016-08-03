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
        private bool isMain;
        public InsertNewItem(string table, bool isMain)
        {
            this.isMain = isMain;
            if (isMain)
                this.table = table + "Items";
            else
                this.table = table + "Querys";
        }

        public bool Insert(Item item)
        {
            if (!new CheckID(item.ID, table).Check(isMain)) // if ID does not exist
            {
                string query = String.Empty; 
                if (isMain)
                {
                    query = String.Format("INSERT INTO {0} values ('{1}','{2}')", this.table, item.ID, item.Descripcion);
                }
                else
                {
                    query = String.Format("INSERT INTO {0} (FKItem) values ('{1}')", this.table, item.ID);
                }

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
