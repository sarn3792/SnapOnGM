private void CopyFK(String table)
        {
            string query = String.Format(@"INSERT INTO {0} (FKItem)
                                           SELECT ITM.PKItem FROM {1} ITM", table + "Querys", table + "Items");

            try
            {
                ControladorBD.opeBD.IniciarTransaccion();
                ControladorBD.opeBD.EjeQuery(query);
                ControladorBD.opeBD.FinalizarTransaccion();
            }
            catch (Exception ex)
            {
                ControladorBD.opeBD.CancelarTransaccion(); //rollback
                throw new Exception(String.Format("Ha ocurrido la siguiente excepción : {0}", ex.Message));
            }
        }

        
//foreach (TablasBD.Balance items in Enum.GetValues(typeof(TablasBD.Balance)))
            //{
            //    string table = items.ToString();
            //    CopyFK(table);
            //}


            //foreach (TablasBD.EstadisticasPersonal items in Enum.GetValues(typeof(TablasBD.EstadisticasPersonal)))
            //{
            //    string table = items.ToString();
            //    CopyFK(table);
            //}

            foreach (TablasBD.GastosGenerales items in Enum.GetValues(typeof(TablasBD.GastosGenerales)))
            {
                string table = items.ToString();
                CopyFK(table);
            }

            foreach (TablasBD.HojalateriaPintura items in Enum.GetValues(typeof(TablasBD.HojalateriaPintura)))
            {
                string table = items.ToString();
                CopyFK(table);
            }

            foreach (TablasBD.OtrasActividades items in Enum.GetValues(typeof(TablasBD.OtrasActividades)))
            {
                string table = items.ToString();
                CopyFK(table);
            }

            foreach (TablasBD.PartesAccesorios items in Enum.GetValues(typeof(TablasBD.PartesAccesorios)))
            {
                string table = items.ToString();
                CopyFK(table);
            }

            foreach (TablasBD.ResumenOperaciones items in Enum.GetValues(typeof(TablasBD.ResumenOperaciones)))
            {
                string table = items.ToString();
                CopyFK(table);
            }

            foreach (TablasBD.TallerMecanica items in Enum.GetValues(typeof(TablasBD.TallerMecanica)))
            {
                string table = items.ToString();
                CopyFK(table);
            }

            foreach (TablasBD.VehiculosNuevos items in Enum.GetValues(typeof(TablasBD.VehiculosNuevos)))
            {
                string table = items.ToString();
                CopyFK(table);
            }

            foreach (TablasBD.VehiculosSeminuevos items in Enum.GetValues(typeof(TablasBD.VehiculosSeminuevos)))
            {
                string table = items.ToString();
                CopyFK(table);
            }
            MessageBox.Show("FK copiadas correctamente");        

