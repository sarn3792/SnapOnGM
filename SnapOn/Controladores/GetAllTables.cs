using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public class GetAllTables
    {
        public static List<String> GetTables()
        {
            List<String> dataSourceCmb = new List<String>();

            foreach (TablasBD.Balance items in Enum.GetValues(typeof(TablasBD.Balance)))
            {
                dataSourceCmb.Add(items.ToString());
            }

            foreach (TablasBD.EstadisticasPersonal items in Enum.GetValues(typeof(TablasBD.EstadisticasPersonal)))
            {
                dataSourceCmb.Add(items.ToString());
            }

            foreach (TablasBD.GastosGenerales items in Enum.GetValues(typeof(TablasBD.GastosGenerales)))
            {
                dataSourceCmb.Add(items.ToString());
            }

            foreach (TablasBD.HojalateriaPintura items in Enum.GetValues(typeof(TablasBD.HojalateriaPintura)))
            {
                dataSourceCmb.Add(items.ToString());
            }

            foreach (TablasBD.OtrasActividades items in Enum.GetValues(typeof(TablasBD.OtrasActividades)))
            {
                dataSourceCmb.Add(items.ToString());
            }

            foreach (TablasBD.PartesAccesorios items in Enum.GetValues(typeof(TablasBD.PartesAccesorios)))
            {
                dataSourceCmb.Add(items.ToString());
            }

            foreach (TablasBD.ResumenOperaciones items in Enum.GetValues(typeof(TablasBD.ResumenOperaciones)))
            {
                dataSourceCmb.Add(items.ToString());
            }

            foreach (TablasBD.TallerMecanica items in Enum.GetValues(typeof(TablasBD.TallerMecanica)))
            {
                dataSourceCmb.Add(items.ToString());
            }

            foreach (TablasBD.VehiculosNuevos items in Enum.GetValues(typeof(TablasBD.VehiculosNuevos)))
            {
                dataSourceCmb.Add(items.ToString());
            }

            foreach (TablasBD.VehiculosSeminuevos items in Enum.GetValues(typeof(TablasBD.VehiculosSeminuevos)))
            {
                dataSourceCmb.Add(items.ToString());
            }

            return dataSourceCmb;

        }
    }
}
