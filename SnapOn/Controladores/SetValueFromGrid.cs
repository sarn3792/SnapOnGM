using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapOn
{
    public class SetValueFromGrid
    {
        private DataGridView mainGrid;
        private DataTable dataTableWithQuerys;
        private String periodo;

        public SetValueFromGrid(DataGridView main, DataTable gridWithAllQuerys, String periodo)
        {
            this.mainGrid = main;
            this.dataTableWithQuerys = gridWithAllQuerys;
            this.periodo = periodo;
        }

        public void Set()
        {
            String fkItem = String.Empty;
            String header = String.Empty;
            String value = String.Empty;
            for(int i=0; i < dataTableWithQuerys.Rows.Count; i++)
            {
                for(int j=0; j < dataTableWithQuerys.Columns.Count; j++)
                {
                    header = dataTableWithQuerys.Columns[j].ToString();
                    value = dataTableWithQuerys.Rows[i][j].ToString();
                    if (header.Equals("PKItem"))
                        fkItem = value;

                    if (value != null && !value.Equals(String.Empty) && !value.Equals(DBNull.Value) && !OperacionesGenerales.IsDefaultColumnName(header) && !header.Equals("Item"))
                    {
                        //Int32 queryExecuted = Convert.ToInt32(ControladorBD.opeBD.QueryATab(value).Rows[0]);
                        if (value.Contains("@Periodo")) //this variable was added in query. It's replaced with the period inserted by the user
                        {
                            value = value.Replace("@Periodo", periodo);
                        }
                        DataTable aux = ControladorBD.opeBD.QueryATab(value);
                        if (aux.Rows.Count > 0)
                        {
                            if (aux.Rows.Count > 1 || aux.Columns.Count > 1) //Query returns more than one result.
                            {
                                //error
                            }
                            else
                            {
                                //dataTableWithQuerys.Rows[i][j] = aux.Rows[0][0];
                                if(aux.Rows[0][0] != null && !aux.Rows[0][0].Equals(DBNull.Value))
                                    this.mainGrid.Rows[i].Cells[j].Value = Convert.ToDecimal(aux.Rows[0][0]);
                            }
                        }else
                        {
                            //No rows
                        }
                    }
                }
            }
        }
    }
}
