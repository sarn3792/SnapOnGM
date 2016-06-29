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

            }
        }

        private void rbVistas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVistas.Checked)
            {

            }
        }

        private void rbSQL_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSQL.Checked)
            {

            }
        }
    }
}
