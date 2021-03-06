﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public class InsertNewColumn
    {
        private string table;
        private bool isMoney;
        private string tableLayout;

        public InsertNewColumn(string table, bool isMoney)
        {
            this.table = table;
            this.tableLayout = table + "Layout";
            this.isMoney = isMoney;
        }

        public bool Insert(string descriptionColumn)
        {
            try
            {

                String query = String.Empty;
                String queryLayout = String.Empty;

                if (isMoney)
                {
                    query = String.Format(@"IF NOT EXISTS 
                                               (SELECT 1 FROM syscolumns sc JOIN sysobjects so ON sc.id = so.id WHERE so.Name = '{0}' AND sc.Name = '{1}') 
                                                BEGIN ALTER TABLE {2} ADD {3} MONEY NULL 
                                                END", this.table, descriptionColumn, this.table, descriptionColumn);
                    queryLayout = String.Format(@"IF NOT EXISTS 
                                               (SELECT 1 FROM syscolumns sc JOIN sysobjects so ON sc.id = so.id WHERE so.Name = '{0}' AND sc.Name = '{1}') 
                                                BEGIN ALTER TABLE {2} ADD {3} MONEY NULL 
                                                END", this.tableLayout, descriptionColumn, this.tableLayout, descriptionColumn);
                } else
                {
                    query = String.Format(@"IF NOT EXISTS 
                                               (SELECT 1 FROM syscolumns sc JOIN sysobjects so ON sc.id = so.id WHERE so.Name = '{0}' AND sc.Name = '{1}') 
                                                BEGIN ALTER TABLE {2} ADD {3} VARCHAR(500) NULL 
                                                END", this.table, descriptionColumn, this.table, descriptionColumn);
                }

                ControladorBD.opeBD.IniciarTransaccion(); //begin tran
                if(isMoney)
                    ControladorBD.opeBD.EjeQuery(queryLayout);

                ControladorBD.opeBD.EjeQuery(query);

                ControladorBD.opeBD.FinalizarTransaccion(); //commit
            }
            catch (Exception ex)
            {
                ControladorBD.opeBD.CancelarTransaccion(); //rollback
                throw new Exception(String.Format("Ha ocurrido la siguiente excepción : {0}", ex.Message));
            }
            return true;
        }
    }
}
