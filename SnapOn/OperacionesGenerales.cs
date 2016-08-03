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
        }

        public static void HideDefaultColumnsInGrid(DataGridView grid)
        {
            foreach (string item in GridDefaultValue.gridValues)
            {
                //grid.Columns.Remove(item);
                grid.Columns[item].Visible = false;
            }
        }

        public static bool IsDefaultColumnName(String columnName)
        {
            foreach (string item in GridDefaultValue.gridValues)
            {
                if (item.Equals(columnName))
                    return true;
            }

            return false;
        }
    }
}
