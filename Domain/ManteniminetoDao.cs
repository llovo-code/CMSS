using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Domain
{
    public class ManteniminetoDao
    {
        DataTable dt = new DataTable();

        public DataTable MostarMantenimientos( )
        {
            populate();
            return dt;
        }
        

        public void  populate()
        {

            dt.Columns.Add("Equipo");
            dt.Columns.Add("Mantenimineto");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Stado");

            DataRow dr1 = dt.NewRow();
            dr1[0] = "Computadora";
            dr1[1] = "Mantenimineto Correctivo";
            dr1[2] = "Cambio de Memoria Ram";
            dr1[3] = 15;
            dr1[4] = false;
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2[0] = "Computadora";
            dr2[1] = "Mantenimineto Correctivo";
            dr2[2] = "Cambio de Pasta Termica";
            dr2[3] = 25;
            dr2[4] = false;
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3[0] = "Computadora";
            dr3[1] = "Mantenimineto Correctivo";
            dr3[2] = "Cambio de Disco Duro";
            dr3[3] = 30;
            dr3[4] = false;
            dt.Rows.Add(dr3);

            DataRow dr4 = dt.NewRow();
            dr4[0] = "Computadora";
            dr4[1] = "Mantenimineto Correctivo";
            dr4[2] = "Activacion de Windows";
            dr4[3] = 50;
            dr4[4] = false;
            dt.Rows.Add(dr4);
        }

    }
}
