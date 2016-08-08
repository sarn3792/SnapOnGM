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
            int i = 0;
            String fkItem = String.Empty;
            foreach (DataGridViewRow row in mainGrid.Rows)
            {
                i = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    String header = mainGrid.Columns[i].HeaderText;
                    if (header.Equals("PKItem"))
                        fkItem = cell.Value.ToString();

                    if (cell.Value != null && !cell.Value.Equals(String.Empty) && cell.Value != System.DBNull.Value && !OperacionesGenerales.IsDefaultColumnName(header) && !header.Equals("Item"))
                    { //NOW IS LOPPING THE GRID, SO THAT'S WHY IT DOESN'T CALL THE SEARCH VALUE. IT MUST READ THE GRID
                        //MessageBox.Show(cell.Value.ToString());
                        //new SaveQuery(tableName, header, cell.Value.ToString(), fkItem).Save();
                        SearchValue(cell.Value.ToString());
                    }
                    i++;
                }
            }
        }

        private void SearchValue(String columnValue)
        {
            DataRow [] result = dataTableWithQuerys.Select(string.Format("{0} = '{1}'", "PKItem", columnValue));
        }
    }
}
