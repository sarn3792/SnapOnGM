using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapOn
{
    public partial class ArchivoTxt : Form
    {
        private String fileName = String.Empty;

        public ArchivoTxt()
        {
            InitializeComponent();
            svdTxt.FileName = SnapOn.periodo;
            lblArchivo.Text = svdTxt.FileName + ".txt";
        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            if(svdTxt.ShowDialog() == DialogResult.OK)
            {
                lblArchivo.Text = svdTxt.FileName;
                new GenerateTxt(svdTxt.FileName, SnapOn.periodo).GenerateFile();
                MessageBox.Show("Archivo guardado exitosamente", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
