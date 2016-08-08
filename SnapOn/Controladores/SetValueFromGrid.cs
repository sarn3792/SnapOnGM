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

        public SetValueFromGrid(DataGridView main, DataTable gridWithAllQuerys)
        {
            this.mainGrid = main;
            this.dataTableWithQuerys = gridWithAllQuerys;
        }

        public void Set()
        {
            //int i = 0;
            //String fkItem = String.Empty;
            //foreach (DataGridViewRow row in mainGrid.Rows)
            //{
            //    i = 0;
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        String header = mainGrid.Columns[i].HeaderText;
            //        if (header.Equals("PKItem"))
            //            fkItem = cell.Value.ToString();

            //        if (cell.Value != null && !cell.Value.Equals(String.Empty) && cell.Value != System.DBNull.Value && !OperacionesGenerales.IsDefaultColumnName(header) && !header.Equals("Item"))
            //        { //NOW IS LOPPING THE GRID, SO THAT'S WHY IT DOESN'T CALL THE SEARCH VALUE. IT MUST READ THE GRID
            //            SearchValue(cell.Value.ToString());
            //        }
            //        i++;
            //    }
            //}
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
                        DataTable aux = ControladorBD.opeBD.QueryATab(value);
                        if(aux.Rows.Count > 1 || aux.Columns.Count > 1) //Query returns more than one result.
                        {
                            //error
                        }
                        else
                        {
                            //dataTableWithQuerys.Rows[i][j] = aux.Rows[0][0];
                            this.mainGrid.Rows[i].Cells[j].Value = Convert.ToDecimal(aux.Rows[0][0]);
                        }
                    }
                }
            }
        }
    }
}
