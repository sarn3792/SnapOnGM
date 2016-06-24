using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public class Item
    {
        private string id;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Item(string id, string descripcion)
        {
            this.ID = id;
            this.Descripcion = descripcion;
        }

    }
}
