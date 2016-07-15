using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapOn
{
    public partial class SQL : Form
    {
        public SQL()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtQuery.Text.Trim() != String.Empty)
            {
                try
                {
                    gvResults.DataSource = new SQLAnalycer(txtQuery.Text.Trim()).ExecuteQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("SQL Error: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor de ingresar el query a ejecutar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
