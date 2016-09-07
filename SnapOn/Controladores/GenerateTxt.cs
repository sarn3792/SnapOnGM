using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapOn
{
    public class GenerateTxt
    {
        private String fileName;
        private String periodo;

        public GenerateTxt(String fileName, String periodo)
        {
            this.fileName = fileName;
            this.periodo = periodo;
        }

        public void GenerateFile()
        {
            FileStream fsi = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fsi);
            //writer.Write();
            List<String> allTables = GetAllTables.GetTables();
            foreach (String table in allTables)
            {
                String information = new GetAllDataFromTables(table).GetData(periodo);
                writer.Write(information + Environment.NewLine + Environment.NewLine);
            }


            writer.Close();
        }
    }
}
