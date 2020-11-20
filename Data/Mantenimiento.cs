using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    class Mantenimiento
    {
        public int Id_Mantenimiento { get;set; }
        public TM Tipo_Mantenimiento { get; set; }
    }

    public enum TM
    {
        Preventivo,Correctivo,Predictivo
    }
}
