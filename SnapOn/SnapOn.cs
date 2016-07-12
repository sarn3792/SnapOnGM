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
    public partial class SnapOn : Form
    {
        public SnapOn()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
           (new Configuracion()).Show();
        }

        private void ConfiguracionInicial()
        {
            cmbGrupos.DataSource = ComboboxController.ObtenerDatosGrupos();
            cmbCategoria.Enabled = false;
            cmbItem.Enabled = false;
            pnlGrid.Visible = false;
            gbTipo.Enabled = false;
            pnlTipo.Enabled = false;
            pnlTipo.Visible = false;

            lblCuentaEntidad.Visible = false;
            txtCuentaEntidad.Visible = false;
            lblSQL.Visible = false;
            txtQuery.Visible = false;
        }

        private void cmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = (cmbGrupos.SelectedItem as ComboboxItem).Value.ToString();
            cmbCategoria.DataSource = (ComboboxController.ObtenerDatosCategorias(new ComboboxItem(cmbGrupos.SelectedItem.ToString(), (cmbGrupos.SelectedItem as ComboboxItem).Value.ToString())));
            if (value != ComboboxDefaultValue.defaultValues.Value) //If <Seleccionar> text is not selected
            {
                cmbCategoria.Enabled = true;
                cmbCategoria.Focus();
            }
            else
            {
                cmbCategoria.Enabled = false;
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = (cmbCategoria.SelectedItem as ComboboxItem).Value.ToString();
            cmbItem.DataSource = (new GetItems(value)).GetItemByTable(); 
            
            if (value != ComboboxDefaultValue.defaultValues.Value)
            {
                gvMain.DataSource = (new GetTable(value)).GetDataSource();

                HideDefaultColumnsInGrid();
                pnlGrid.Visible = true;

                gbTipo.Enabled = true;
                pnlTipo.Visible = true;
                pnlTipo.Enabled = true;

                cmbItem.Enabled = true;
                cmbItem.Focus();
            }
            else
            {
                cmbItem.Enabled = false;
            }
        }

        private void rbCuentaEntidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuentaEntidad.Checked)
            {
                lblCuentaEntidad.Visible = true;
                txtCuentaEntidad.Visible = true;
                txtCuentaEntidad.Focus();
            }
            else
            {
                lblCuentaEntidad.Visible = false;
                txtCuentaEntidad.Visible = false;
            }
        }

        private void rbVistas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVistas.Checked)
            {
                pnlTipo.Enabled = false;
            }
            else
            {
                pnlTipo.Enabled = true;
            }
        }

        private void rbSQL_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSQL.Checked)
            {
                lblSQL.Visible = true;
                txtQuery.Visible = true;
                txtQuery.Focus();
            }
            else
            {
                lblSQL.Visible = false;
                txtQuery.Visible = false;
            }
        }

        private void HideDefaultColumnsInGrid()
        {
            foreach (string item in GridDefaultValue.gridValues)
            {
                gvMain.Columns[item].Visible = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbCuentaEntidad.Checked) //Create class to get number based on Cuenta entidad
            {

            } else if(rbSQL.Checked){
                if (txtQuery.Text.Trim() != String.Empty)
                {
                    try
                    {
                        new SQLAnalycer(txtQuery.Text.Trim()).ExecuteQuery();
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

            } else if (rbVistas.Checked)
            {

            }
        }
    }
}
