using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapOn
{
    public static class TablasBD
    {
        public enum Balance
        {
            [Description("Activos fijos")]
            BLActivosFijos,
            [Description("Cuentas por cobrar")]
            BLCuentasPorCobrar,
            [Description("Disponible")]
            BLDisponible,
            [Description("Inventario")]
            BLInventario,
            [Description("Pasivo de largo plazo")]
            BLPasivoLP,
            [Description("Pasivo corrientes")]
            BLPasivosCorrientes,
            [Description("Patrimonio")]
            BLPatrimonio,
        }

        public enum EstadisticasPersonal
        {
            [Description("Administacion")]
            EPAdministracion,
            [Description("Hojalatería y pintura")]
            EPHojalateriaPintura,
            [Description("Otras actividades")]
            EPOtrasActividades,
            [Description("Partes y accesorios")]
            EPPartesAccesorios,
            [Description("Taller mecánica")]
            EPTallerMecanica,
            [Description("Vehículos nuevos")]
            EPVehiculosNuevos,
            [Description("Vehículos usados")]
            EPVehiculosUsados
        }

        public enum GastosGenerales
        {
            [Description("Gastos bienes inmuebles")]
            GGBienesInmuebles,
            [Description("Ingresos y gastos financieros")]
            GGIngresosYGastos,
            [Description("Gastos de operación")]
            GGOperacion,
            [Description("Resultados extraordinarios")]
            GGResultadosExtraordinarios
        }

        public enum HojalateriaPintura
        {
            [Description("Estadística")]
            HPEstadisticas,
            [Description("Administacion")]
            HPGastosDepartamento,
            [Description("Mano de obra")]
            HPManoObra,
            [Description("Otros ingresos")]
            HPOtrosIngresos,
            [Description("Refacciones")]
            HPRefacciones
        }

        public enum OtrasActividades
        {
            [Description("Departamento alquiler vehículos")]
            OAAlquilerVehiculos,
            [Description("Estadísticas alquiler vehículos")]
            OAEstadisticasAlquilerVehiculos,
            [Description("Gastos alquiler vehículos")]
            OAGastosAlquilerVehiculos,
            [Description("Otras marcas")]
            OAOtrasMarcas,
            [Description("Otros departamentos")]
            OAOtrosDepartamentos
        }

        public enum PartesAccesorios
        {
            [Description("Ventas de partes y accesorios")]
            PAVentas,
            [Description("Internas - Partes y accesorios taller mecánica")]
            PAInternasTM,
            [Description("Internas - Partes y accesorios hojalatería y pintura")]
            PAInternasHP,
            [Description("Internas - Repuestos otros departamentos")]
            PAInternasOD,
            [Description("Gastos variables")]
            PAGastosVariables,
            [Description("Gastos fijos")]
            PAGastosFijos   
        }

        public enum ResumenOperaciones
        {
            [Description("Resumen de operaciones")]
            ROResumenOperaciones
        }

        public enum VehiculosSeminuevos
        {
            [Description("Vehículos seminuevos")]
            SNSeminuevos,
            [Description("Seminuevos - Otros ingresos y gastos")]
            SNOtrosIngresosGastos,
            [Description("Gastos variables")]
            SNGastosVariables,
            [Description("Gastos fijos")]
            SNGastosFijos,
            [Description("Antigüedad inventario")]
            SNAntiguedadInventario,            
        }

        public enum TallerMecanica
        {
            [Description("Mano de obra")]
            TMManoObra,
            [Description("Refacciones")]
            TMRefacciones,
            [Description("Otros ingresos")]
            TMOtrosIngresos,
            [Description("Gastos fijos")]
            TMGastosFijos,
            [Description("Estadísticas")]
            TMEstadisticas,
        }

        public enum VehiculosNuevos
        {
            [Description("Ventas menudeo")]
            VNVentasMenudeo,
            [Description("Flotillas")]
            VNFlotillas,
            [Description("Vehículos comerciales")]
            VNVehiculosComerciales,
            [Description("Otros ingresos y gastos")]
            VNOtrosIngresosGastos,
            [Description("Gastos variables")]
            VNGastosVariables,
            [Description("Gastos fijos")]
            VNGastosFijos,
            [Description("Antigüedad inventario")]
            VNAntiguedadInventario,
        }
    }
}