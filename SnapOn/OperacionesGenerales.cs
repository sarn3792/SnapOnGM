using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapOn
{
    public static class OperacionesGenerales
    {
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        public static void HideDefaultColumnsInMainGrid(DataGridView grid)
        {
            foreach (string item in GridDefaultValue.gridValues)
            {
                //grid.Columns.Remove(item);
                grid.Columns[item].Visible = false;
            }

            for (int i = 0, j = 0; i < grid.Columns.Count; i++) //Hide all Query columns
            {
                if (grid.Columns[i].Name.ToString().Contains("Query"))
                {
                    grid.Columns[i].Visible = false;
                    //grid.Columns.Remove(grid.Columns[j].Name.ToString());
                }
                else
                {
                    j++;
                }
            }
        }

        public static void HideDefaultColumnsInGrid(DataGridView grid)
        {
            foreach (string item in GridDefaultValue.gridValues)
            {
                grid.Columns.Remove(item);
                //grid.Columns[item].Visible = false;
            }

            for (int i = 0, j=0; i < grid.Columns.Count; i++) //Hide all no Query columns
            {
                if (!grid.Columns[j].Name.ToString().Contains("Query") && grid.Columns[j].Name.ToString() != "Item")
                {
                    grid.Columns.Remove(grid.Columns[j].Name.ToString());
                    //grid.Columns[i].Visible = false;
                }
                else
                {
                    j++;
                }
            }
        }
    }
}
