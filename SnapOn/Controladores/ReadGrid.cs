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

        public ReadGrid(DataGridView grid)
        {
            this.grid = grid;
        }

        public void Read()
        {
            int i;
            foreach (DataGridViewRow row in grid.Rows)
            {
                i = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string header = grid.Columns[i].HeaderText;
                    if (cell.Value != null && !cell.Value.Equals(String.Empty))
                    {
                        
                    }
                    i++;
                }
            }
        }
    }
}
