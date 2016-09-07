using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public class ComboboxController
    {
        public static List<ComboboxItem> ObtenerDatosCategorias(ComboboxItem item)
        {
            List<ComboboxItem> dataSourceCmb = new List<ComboboxItem>();
            dataSourceCmb.Add(ComboboxDefaultValue.defaultValues);

            if (item.Value == Grupos.GruposBD.Balance.ToString())
            {
                foreach (TablasBD.Balance items in Enum.GetValues(typeof(TablasBD.Balance)))
                {
                    dataSourceCmb.Add(new ComboboxItem(OperacionesGenerales.GetEnumDescription(items), items.ToString()));
                }

            }
            else if (item.Value == Grupos.GruposBD.Estadisticas_personal.ToString())
            {
                foreach (TablasBD.EstadisticasPersonal items in Enum.GetValues(typeof(TablasBD.EstadisticasPersonal)))
                {
                    dataSourceCmb.Add(new ComboboxItem(OperacionesGenerales.GetEnumDescription(items), items.ToString()));
                }

            }
            else if (item.Value == Grupos.GruposBD.Gastos_generales.ToString())
            {
                foreach (TablasBD.GastosGenerales items in Enum.GetValues(typeof(TablasBD.GastosGenerales)))
                {
                    dataSourceCmb.Add(new ComboboxItem(OperacionesGenerales.GetEnumDescription(items), items.ToString()));
                }

            }
            else if (item.Value == Grupos.GruposBD.Hojalateria_pintura.ToString())
            {
                foreach (TablasBD.HojalateriaPintura items in Enum.GetValues(typeof(TablasBD.HojalateriaPintura)))
                {
                    dataSourceCmb.Add(new ComboboxItem(OperacionesGenerales.GetEnumDescription(items), items.ToString()));
                }

            }
            else if (item.Value == Grupos.GruposBD.Otras_actividades.ToString())
            {
                foreach (TablasBD.OtrasActividades items in Enum.GetValues(typeof(TablasBD.OtrasActividades)))
                {
                    dataSourceCmb.Add(new ComboboxItem(OperacionesGenerales.GetEnumDescription(items), items.ToString()));
                }

            }
            else if (item.Value == Grupos.GruposBD.Partes_accesorios.ToString())
            {
                foreach (TablasBD.PartesAccesorios items in Enum.GetValues(typeof(TablasBD.PartesAccesorios)))
                {
                    dataSourceCmb.Add(new ComboboxItem(OperacionesGenerales.GetEnumDescription(items), items.ToString()));
                }

            }
            else if (item.Value == Grupos.GruposBD.Resumen_operaciones.ToString())
            {
                foreach (TablasBD.ResumenOperaciones items in Enum.GetValues(typeof(TablasBD.ResumenOperaciones)))
                {
                    dataSourceCmb.Add(new ComboboxItem(OperacionesGenerales.GetEnumDescription(items), items.ToString()));
                }
            }
            else if (item.Value == Grupos.GruposBD.Taller_mecanica.ToString())
            {
                foreach (TablasBD.TallerMecanica items in Enum.GetValues(typeof(TablasBD.TallerMecanica)))
                {
                    dataSourceCmb.Add(new ComboboxItem(OperacionesGenerales.GetEnumDescription(items), items.ToString()));
                }
            }
            else if (item.Value == Grupos.GruposBD.Vehiculos_nuevos.ToString())
            {
                foreach (TablasBD.VehiculosNuevos items in Enum.GetValues(typeof(TablasBD.VehiculosNuevos)))
                {
                    dataSourceCmb.Add(new ComboboxItem(OperacionesGenerales.GetEnumDescription(items), items.ToString()));
                }
            }
            else if (item.Value == Grupos.GruposBD.Vehiculos_seminuevos.ToString())
            {
                foreach (TablasBD.VehiculosSeminuevos items in Enum.GetValues(typeof(TablasBD.VehiculosSeminuevos)))
                {
                    dataSourceCmb.Add(new ComboboxItem(OperacionesGenerales.GetEnumDescription(items), items.ToString()));
                }
            }

            return dataSourceCmb;
        }

        public static List<ComboboxItem> ObtenerDatosGrupos()
        {
            List<ComboboxItem> dataSourceCmb = new List<ComboboxItem>();
            dataSourceCmb.Add(ComboboxDefaultValue.defaultValues);

            foreach (Grupos.GruposBD grupos in Enum.GetValues(typeof(Grupos.GruposBD)))
            {
                dataSourceCmb.Add(new ComboboxItem(OperacionesGenerales.GetEnumDescription(grupos), grupos.ToString()));
            }

            return dataSourceCmb;
        }

    }
}
