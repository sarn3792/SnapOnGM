using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public class InsertNewItemQuery : InsertNewItem
    {
        public InsertNewItemQuery(string table, bool isMain) : base(table, isMain)
        {

        }
    }
}
