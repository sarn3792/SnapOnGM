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
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {

        }

        private void cmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string text = cmbGrupos.SelectedItem.ToString();
            string value = (cmbGrupos.SelectedItem as ComboboxItem).Value.ToString();
            cmbItems.DataSource = (ComboboxController.ObtenerDatosCategorias(new ComboboxItem(cmbGrupos.SelectedItem.ToString(), (cmbGrupos.SelectedItem as ComboboxItem).Value.ToString())));
            if (value != ComboboxDefaultValue.defaultValues.Value) //If <Seleccionar> text is not selected
            {
                cmbItems.Enabled = true;
                cmbItems.Focus();
            }
            else
            {
                cmbItems.Enabled = false;
            }
        }

        private void cmbGrupoFila_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = (cmbGrupoFila.SelectedItem as ComboboxItem).Value.ToString();
            cmbCategoriaFila.DataSource = (ComboboxController.ObtenerDatosCategorias(new ComboboxItem(cmbGrupoFila.SelectedItem.ToString(), (cmbGrupoFila.SelectedItem as ComboboxItem).Value.ToString())));
            if (value != ComboboxDefaultValue.defaultValues.Value) //If <Seleccionar> text is not selected
            {
                cmbCategoriaFila.Enabled = true;
                cmbCategoriaFila.Focus();
            }
            else
            {
                cmbCategoriaFila.Enabled = false;
            }
        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = (cmbItems.SelectedItem as ComboboxItem).Value.ToString();
            if (value != ComboboxDefaultValue.defaultValues.Value)
            {
                txtDescripcionColumna.Enabled = true;
                txtDescripcionColumna.Focus();
            }
            else
            {
                txtDescripcionColumna.Enabled = false;
            }
        }

        private void cmbCategoriaFila_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = (cmbCategoriaFila.SelectedItem as ComboboxItem).Value.ToString();
            if (value != ComboboxDefaultValue.defaultValues.Value)
            {
                txtIDFila.Enabled = true;
                txtDescripcionFila.Enabled = true;
                txtIDFila.Focus();
            }
            else
            {
                txtIDFila.Enabled = false;
                txtDescripcionFila.Enabled = false;
            }
        }

        private void ConfiguracionInicial()
        {
            cmbGrupos.DataSource = ComboboxController.ObtenerDatosGrupos();
            cmbGrupoFila.DataSource = ComboboxController.ObtenerDatosGrupos();

            cmbItems.Enabled = false;
            cmbCategoriaFila.Enabled = false;

            txtIDFila.Enabled = false;
            txtIDFila.Text = String.Empty;
            txtDescripcionFila.Enabled = false;
            txtDescripcionFila.Text = String.Empty;
            txtDescripcionColumna.Enabled = false;
            txtDescripcionColumna.Text = String.Empty;
            
        }


        private void btnAgregarColumnas_Click(object sender, EventArgs e)
        {
            string gruposValue = (cmbGrupos.SelectedItem as ComboboxItem).Value.ToString();
            string itemsValue = (cmbItems.SelectedItem as ComboboxItem).Value.ToString();
            if(txtDescripcionColumna.Text.Trim() != String.Empty && gruposValue != ComboboxDefaultValue.defaultValues.Value && itemsValue != ComboboxDefaultValue.defaultValues.Value)
            {
                if(new InsertNewColumn(itemsValue, true).Insert(txtDescripcionColumna.Text.Trim()) && new InsertNewColumnQuerys(itemsValue, false).Insert(txtDescripcionColumna.Text.Trim()))
                {
                    MessageBox.Show("Columna insertada correctamente", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConfiguracionInicial();
                }

            } else
            {
                MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarFila_Click(object sender, EventArgs e)
        {
            string gruposValue = (cmbGrupoFila.SelectedItem as ComboboxItem).Value.ToString();
            string itemsValue = (cmbCategoriaFila.SelectedItem as ComboboxItem).Value.ToString();
            if (txtIDFila.Text.Trim() != String.Empty && txtDescripcionFila.Text.Trim() != String.Empty && gruposValue != ComboboxDefaultValue.defaultValues.Value && itemsValue != ComboboxDefaultValue.defaultValues.Value)
            {
                if(new InsertNewItem(itemsValue, true).Insert(new Item(txtIDFila.Text.Trim().ToUpper(), txtDescripcionFila.Text.Trim())) && new InsertNewItemQuery(itemsValue, false).Insert(new Item(txtIDFila.Text.Trim().ToUpper(), txtDescripcionFila.Text.Trim())))
                {
                    MessageBox.Show("Campo insertado correctamente", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConfiguracionInicial();
                }
                else
                {
                    MessageBox.Show("El ID ingresado ya existe, favor de ingresar otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIDFila.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        
    } // end class
} //end namespace
