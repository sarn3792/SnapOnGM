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
    public partial class ConfiguracionQuerys : Form
    {
        public ConfiguracionQuerys()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }

        private void ConfiguracionInicial()
        {
            cmbGrupos.DataSource = ComboboxController.ObtenerDatosGrupos();
            cmbCategoria.Enabled = false;

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

            if (value != ComboboxDefaultValue.defaultValues.Value)
            {
                gvMain2.DataSource = (new GetTableForQueryes(value, true)).GetDataSource();
                OperacionesGenerales.HideDefaultColumnsInGrid(gvMain2);

                gbTipo.Enabled = true;
                pnlTipo.Visible = true;
                pnlTipo.Enabled = true;
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
                //lblSQL.Visible = true;
                //txtQuery.Visible = true;
                //txtQuery.Focus();
                //new SQL().Show();
            }
            else
            {
                lblSQL.Visible = false;
                txtQuery.Visible = false;
            }
        }

        private void btnSQLCompiller_Click(object sender, EventArgs e)
        {
            new SQL().Show();
        }

        private void btnSaveQuerys_Click(object sender, EventArgs e)
        {
            try
            {
                new ReadGrid(gvMain2, (cmbCategoria.SelectedItem as ComboboxItem).Value.ToString() + "Querys").Read();
                MessageBox.Show("Querys guardados correctamente", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(String.Format("Ha ocurrido la siguiente excepción: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
