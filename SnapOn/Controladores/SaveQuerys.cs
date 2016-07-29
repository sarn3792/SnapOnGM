using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapOn
{
    public class SaveQuerys
    {
        private DataGridView grid;

        public SaveQuerys(DataGridView grid)
        {
            this.grid = grid;
        }

        public void Save()
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string value = cell.Value.ToString();

                }
            }
        }
    }
}
