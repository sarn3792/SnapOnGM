using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            pnlGrid.Visible = false;
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
                //if(Configuracion == "Querys")
                //{

                //}
                try
                {
                    gvMain.DataSource = (new GetTable(value)).GetDataSource();
                    (new SetValueFromGrid(gvMain, (new GetTableForQueryes(value, true)).GetDataSource())).Set();
                    OperacionesGenerales.HideDefaultColumnsInMainGrid(gvMain);
                    pnlGrid.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Ha ocurrido la siguiente excepción: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                new SaveReflection(gvMain.DataSource as DataTable, (cmbCategoria.SelectedItem as ComboboxItem).Value.ToString()).Insert();
                MessageBox.Show("Información guardada correctamente", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(String.Format("Ha ocurrido la siguiente excepción: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfigQuerys_Click(object sender, EventArgs e)
        {
            new ConfiguracionQuerys().Show();
        }
    }
}
