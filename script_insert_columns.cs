            //foreach (TablasBD.Balance items in Enum.GetValues(typeof(TablasBD.Balance)))
            //{
            //    string table = items.ToString();
            //    DataTable allColumns = ControladorBD.opeBD.QueryATab(String.Format(@"SELECT COLUMN_NAME 
            //                                                                        FROM INFORMATION_SCHEMA.COLUMNS
            //                                                                        WHERE TABLE_NAME = '{0}'", table));
            //    InsertNewColumn(table, allColumns);
            //}

            //foreach (TablasBD.EstadisticasPersonal items in Enum.GetValues(typeof(TablasBD.EstadisticasPersonal)))
            //{
            //    string table = items.ToString();
            //    DataTable allColumns = ControladorBD.opeBD.QueryATab(String.Format(@"SELECT COLUMN_NAME 
            //                                                                        FROM INFORMATION_SCHEMA.COLUMNS
            //                                                                        WHERE TABLE_NAME = '{0}'", table));
            //    InsertNewColumn(table, allColumns);
            //}

            //foreach (TablasBD.GastosGenerales items in Enum.GetValues(typeof(TablasBD.GastosGenerales)))
            //{
            //    string table = items.ToString();
            //    DataTable allColumns = ControladorBD.opeBD.QueryATab(String.Format(@"SELECT COLUMN_NAME 
            //                                                                        FROM INFORMATION_SCHEMA.COLUMNS
            //                                                                        WHERE TABLE_NAME = '{0}'", table));
            //    InsertNewColumn(table, allColumns);
            //}

            //foreach (TablasBD.HojalateriaPintura items in Enum.GetValues(typeof(TablasBD.HojalateriaPintura)))
            //{
            //    string table = items.ToString();
            //    DataTable allColumns = ControladorBD.opeBD.QueryATab(String.Format(@"SELECT COLUMN_NAME 
            //                                                                        FROM INFORMATION_SCHEMA.COLUMNS
            //                                                                        WHERE TABLE_NAME = '{0}'", table));
            //    InsertNewColumn(table, allColumns);
            //}

            //foreach (TablasBD.OtrasActividades items in Enum.GetValues(typeof(TablasBD.OtrasActividades)))
            //{
            //    string table = items.ToString();
            //    DataTable allColumns = ControladorBD.opeBD.QueryATab(String.Format(@"SELECT COLUMN_NAME 
            //                                                                        FROM INFORMATION_SCHEMA.COLUMNS
            //                                                                        WHERE TABLE_NAME = '{0}'", table));
            //    InsertNewColumn(table, allColumns);
            //}

            //foreach (TablasBD.PartesAccesorios items in Enum.GetValues(typeof(TablasBD.PartesAccesorios)))
            //{
            //    string table = items.ToString();
            //    DataTable allColumns = ControladorBD.opeBD.QueryATab(String.Format(@"SELECT COLUMN_NAME 
            //                                                                        FROM INFORMATION_SCHEMA.COLUMNS
            //                                                                        WHERE TABLE_NAME = '{0}'", table));
            //    InsertNewColumn(table, allColumns);
            //}

            //foreach (TablasBD.ResumenOperaciones items in Enum.GetValues(typeof(TablasBD.ResumenOperaciones)))
            //{
            //    string table = items.ToString();
            //    DataTable allColumns = ControladorBD.opeBD.QueryATab(String.Format(@"SELECT COLUMN_NAME 
            //                                                                        FROM INFORMATION_SCHEMA.COLUMNS
            //                                                                        WHERE TABLE_NAME = '{0}'", table));
            //    InsertNewColumn(table, allColumns);
            //}

            //foreach (TablasBD.TallerMecanica items in Enum.GetValues(typeof(TablasBD.TallerMecanica)))
            //{
            //    string table = items.ToString();
            //    DataTable allColumns = ControladorBD.opeBD.QueryATab(String.Format(@"SELECT COLUMN_NAME 
            //                                                                        FROM INFORMATION_SCHEMA.COLUMNS
            //                                                                        WHERE TABLE_NAME = '{0}'", table));
            //    InsertNewColumn(table, allColumns);
            //}

            //foreach (TablasBD.VehiculosNuevos items in Enum.GetValues(typeof(TablasBD.VehiculosNuevos)))
            //{
            //    string table = items.ToString();
            //    DataTable allColumns = ControladorBD.opeBD.QueryATab(String.Format(@"SELECT COLUMN_NAME 
            //                                                                        FROM INFORMATION_SCHEMA.COLUMNS
            //                                                                        WHERE TABLE_NAME = '{0}'", table));
            //    InsertNewColumn(table, allColumns);
            //}

            foreach (TablasBD.VehiculosSeminuevos items in Enum.GetValues(typeof(TablasBD.VehiculosSeminuevos)))
            {
                string table = items.ToString();
                DataTable allColumns = ControladorBD.opeBD.QueryATab(String.Format(@"SELECT COLUMN_NAME 
                                                                                    FROM INFORMATION_SCHEMA.COLUMNS
                                                                                    WHERE TABLE_NAME = '{0}'", table));
                InsertNewColumn(table, allColumns);
            }
            MessageBox.Show("Tablas creadas correctamente");

private void InsertNewColumn(string table, DataTable allColumns)
        {
            table += "Querys";
            String query = String.Format(@"CREATE TABLE {0} (FKItem VARCHAR(50) not null," , table);
            String queryFinal = query;
            int i = 0;
            foreach (DataRow row in allColumns.Rows)
            {
                if (row[0].ToString() != "FKItem" && row[0].ToString() != "Fecha")
                {
                    string columnName = row[0].ToString();
                    if (!columnName.Contains("Query"))
                    {
                        columnName = row[0].ToString() + "Query";
                        if (i < ((allColumns.Rows.Count/2) - 1))
                        {
                            queryFinal += String.Format("{1} VARCHAR(500) NULL,", table, columnName);
                        }
                        else
                        {
                            queryFinal += String.Format("{1} VARCHAR(500) NULL );", table, columnName);
                        }
                    }
                }
                i++;
            }

            try
            {
                ControladorBD.opeBD.IniciarTransaccion(); //begin tran
                ControladorBD.opeBD.EjeQuery(queryFinal);
                ControladorBD.opeBD.FinalizarTransaccion(); //commit
            }
            catch (Exception ex)
            {
                ControladorBD.opeBD.CancelarTransaccion(); //rollback
                throw new Exception(String.Format("Ha ocurrido la siguiente excepción : {0}", ex.Message));
            }
        }