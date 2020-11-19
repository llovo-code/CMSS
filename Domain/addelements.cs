using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Domain
{
    public class addelements
    {

        public BunifuDataGridView populate(BunifuDataGridView dgv)
        {
            dgv.ColumnCount = 3;
            DataGridViewCheckBoxColumn columchk = new DataGridViewCheckBoxColumn();
            columchk.HeaderText = "Check Data";
            columchk.Name = "Check";
            dgv.Columns.Insert(0,columchk);
            dgv.Columns[1].Name = "Descripcion";
            dgv.Columns[2].Name = "Tipo Mantenimiento";

            dgv.DataSource = table();
           //dgv.DataBind();
            return dgv;


        }


        public DataTable table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Check", typeof(bool)));
            dt.Columns.Add(new DataColumn("Descipcion", typeof(string)));
            dt.Columns.Add(new DataColumn("Tipo Mantenimiento", typeof(string)));
            

            DataRow dr1 = dt.NewRow();
            dr1["check"] = false;
            dr1["Descipcion"] = "Cambio de Pasta Terminica";
            dr1["Tipo Mantenimiento"] = "Correctivo";
            dt.Rows.Add(dr1);
            return dt;

        }
    }
}
