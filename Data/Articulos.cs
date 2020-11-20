using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Articulos
    {
        private static string articulo;
        private static Tipo_Mantenimiento tM;
        private static string descripcion_Mantenimiento;
        private static double precio_Mantenimineto;

        public static string Articulo { get => articulo; set => articulo = value; }
        public static Tipo_Mantenimiento TM { get => tM; set => tM = value; }
        public static string Descripcion_Mantenimiento { get => descripcion_Mantenimiento; set => descripcion_Mantenimiento = value; }
        public static double Precio_Mantenimineto { get => precio_Mantenimineto; set => precio_Mantenimineto = value; }

        public Articulos()
        {

        }


    }

    public enum Tipo_Mantenimiento
    {
        Mantenimiento_Preventivo,
        Mantenimiento_Correctivo,
        Mantenimineto_Predictivo
    }
}
