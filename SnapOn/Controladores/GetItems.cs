using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public class GetItems
    {
        string table;
        public GetItems(string table)
        {
            this.table = table;
        }

        public List<ComboboxItem> GetItemByTable()           
        {
            List<ComboboxItem> result = new List<ComboboxItem>();
            result.Add(ComboboxDefaultValue.defaultValues);

            if (this.table != ComboboxDefaultValue.defaultValues.Value)
            {
                this.table += "Items";
                string query = String.Format("Select * from {0}", table);
                DataTable aux = ControladorBD.opeBD.QueryATab(query);
                var aux2 = aux.AsEnumerable().Select(m => new ComboboxItem()
                {
                    Value = m.Field<string>("PKItem"),
                    Text = m.Field<string>("Item")
                }).ToList();

                foreach (ComboboxItem item in aux2)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
