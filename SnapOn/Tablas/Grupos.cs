using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapOn
{
    public static class Grupos
    {
        public enum GruposBD
        {
            [Description("Vehiculos nuevos")]
            Vehiculos_nuevos,
            [Description("Vehiculos seminuevos")]
            Vehiculos_seminuevos,
            [Description("Taller mecánica")]
            Taller_mecanica,
            [Description("Hojalatería y pintura")]
            Hojalateria_pintura,
            [Description("Partes y accesorios")]
            Partes_accesorios,
            [Description("Otras actividades")]
            Otras_actividades,
            [Description("Gastos generales")]
            Gastos_generales,
            [Description("Resumen de operaciones")]
            Resumen_operaciones,
            [Description("Estadísticas de personal")]
            Estadisticas_personal,
            [Description("Balance")]
            Balance
        }
    }
}
