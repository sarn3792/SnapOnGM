using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapOn
{
    public class SaveReflection
    {
        private DataTable grid;
        private String table;
        private String period;

        public SaveReflection(DataTable information, String table, String period)
        {
            this.grid = information;
            this.table = table;
            this.period = period;
        }

        public void Insert()
        {
            String fkItem = String.Empty;
            String header = String.Empty;
            String value = String.Empty;
            String query = String.Empty;
            String queryLast = String.Empty;

            bool flag = false;
            bool firstTime = true;
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                query = String.Format("INSERT INTO {0} (FKItem,", table);
                queryLast = String.Format("VALUES (");
                firstTime = true;
                for (int j = 0; j < grid.Columns.Count; j++)
                {
                    header = grid.Columns[j].ToString();
                    value = grid.Rows[i][j].ToString();
                    if (header.Equals("PKItem"))
                        fkItem = value;

                    if (value != null && !value.Equals(String.Empty) && !value.Equals(DBNull.Value) && !OperacionesGenerales.IsDefaultColumnName(header) && !header.Equals("Item"))
                    {
                        query += String.Format("{0},", header); //save columns to insert
                        if (firstTime) //save values to insert
                        {
                            queryLast += String.Format("'{0}',{1},",fkItem, value);
                            firstTime = false;
                        }
                        else
                        {
                            queryLast += String.Format("{0},",value);
                        }

                        flag = true;
                    }
                }
                if (flag)
                {
                    //query = query.Remove(query.Length - 1);
                    query += String.Format(" Fecha, Periodo) ");
                    //queryLast = queryLast.Remove(queryLast.Length - 1);
                    queryLast += String.Format("'{0}', '{1}') ", DateTime.Now.ToString("yyyy-MM-dd HH:mm"), this.period);
                    flag = false;

                    try
                    {
                        ControladorBD.opeBD.IniciarTransaccion();
                        ControladorBD.opeBD.EjeQuery(query + queryLast);
                        ControladorBD.opeBD.FinalizarTransaccion();
                    }
                    catch (Exception ex)
                    {
                        ControladorBD.opeBD.CancelarTransaccion(); //rollback
                        throw ex;
                    }
                }
            }
        }
    }
}
