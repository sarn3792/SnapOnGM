﻿using System;
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
