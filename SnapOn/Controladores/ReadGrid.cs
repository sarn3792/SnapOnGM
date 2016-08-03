using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapOn
{
    public class ReadGrid
    {
        private DataGridView grid;
        private String tableName;

        public ReadGrid(DataGridView grid, String tableName)
        {
            this.grid = grid;
            this.tableName = tableName;
        }

        public void Read()
        {
            int i;
            String fkItem = String.Empty;
            foreach (DataGridViewRow row in grid.Rows)
            {
                i = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    String header = grid.Columns[i].HeaderText;
                    if (header.Equals("PKItem"))
                        fkItem = cell.Value.ToString();

                    if (cell.Value != null && !cell.Value.Equals(String.Empty) && cell.Value != System.DBNull.Value && !OperacionesGenerales.IsDefaultColumnName(header) && !header.Equals("Item"))
                    {
                        //MessageBox.Show(cell.Value.ToString());
                        new SaveQuery(tableName, header, cell.Value.ToString(), fkItem).Save();
                    }
                    i++;
                }
            }
        }
    }
}
