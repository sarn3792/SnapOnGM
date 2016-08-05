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
                    OperacionesGenerales.HideDefaultColumnsInMainGrid(gvMain);
                }catch (Exception ex)
                {

                }
                finally
                {

                }

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if (rbCuentaEntidad.Checked) //Create class to get number based on Cuenta entidad
            //{

            //} else if(rbSQL.Checked){
            //    //if (txtQuery.Text.Trim() != String.Empty)
            //    //{
            //    //    try
            //    //    {
            //    //        new SQLAnalycer(txtQuery.Text.Trim()).ExecuteQuery();
            //    //    }
            //    //    catch (Exception ex)
            //    //    {
            //    //        MessageBox.Show(String.Format("SQL Error: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //    }
            //    //}
            //    //else
            //    //{
            //    //    MessageBox.Show("Favor de ingresar el query a ejecutar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //}

            //} else if (rbVistas.Checked)
            //{

            //}
        }

        private void btnConfigQuerys_Click(object sender, EventArgs e)
        {
            new ConfiguracionQuerys().Show();
        }
    }
}
