using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public class InsertNewColumnQuerys : InsertNewColumn
    {
        public InsertNewColumnQuerys (String table, bool isMoney) : base(table + "Querys", isMoney)
        {

        }
    }
}
