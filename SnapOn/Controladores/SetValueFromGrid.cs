using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapOn.Controladores
{
    public class SetValueFromGrid
    {
        private DataGridView mainGrid;
        private DataTable gridWithQuerys;

        public SetValueFromGrid(DataGridView main, DataTable gridWithAllQuerys)
        {
            this.mainGrid = main;
            this.gridWithQuerys = gridWithAllQuerys;
        }

        public void Set()
        {

        }
    }
}
