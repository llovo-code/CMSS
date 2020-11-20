using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class Principal : Form
    {

        private int idequipo;
        private int idmante;
        MantenimientoModel Mmodel = new MantenimientoModel();

        public Principal()
        {
            InitializeComponent();
            idequipo = 0;
            idmante = 0;
            DataGridViewCheckBoxColumn chckc = new DataGridViewCheckBoxColumn();
            chckc.HeaderText = "Select";
            chckc.Name = "Selection";
            DataGridView_Producto.Columns.Add(chckc);
        }

        private void Btn_Cerrar_Prin_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Restaurar_Prin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Btn_Restaurar_Prin.Visible = false;
            Btn_Maximizar_Prin.Visible = true;
        }

        private void Btn_Minimizar_Prin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Maximizar_Prin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Btn_Maximizar_Prin.Visible = false;  
            Btn_Restaurar_Prin.Visible = true;
        }

        private void Lb_Modelo_Click(object sender, EventArgs e)
        {

        }

        private void PCentral_Prin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Consola_Menu_Click(object sender, EventArgs e)
        {
            idequipo = 1;
            if (DataGridView_Producto.Rows.Count > 1)
            {
                DataGridView_Producto.DataSource = null;
                DataGridView_Producto.Rows.Clear();
            }
        }

        private void Btn_ManPreventivo_Click(object sender, EventArgs e)
        {
            if (idequipo > 0)
            {
                idmante = 1;
                //DataGridViewCheckBoxColumn chckc = new DataGridViewCheckBoxColumn();
                //chckc.HeaderText = "Select";
                //chckc.Name = "Selection";
                //DataGridView_Producto.Columns.Add(chckc);
                DataGridView_Producto.DataSource = Mmodel.GetMantenimientos(idequipo, idmante);
                DataGridView_Producto.AutoGenerateColumns = true;
                DataGridView_Producto.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Seleccione un Equipo Primero");
            }
        }

        private void Btn_ManCorrectivo_Click(object sender, EventArgs e)
        {
           if(idequipo > 0)
            {
                idmante = 2;
                //DataGridViewCheckBoxColumn chckc = new DataGridViewCheckBoxColumn();
                //chckc.HeaderText = "Select";
                //chckc.Name = "Selection";
                //DataGridView_Producto.Columns.Add(chckc);
                DataGridView_Producto.DataSource = Mmodel.GetMantenimientos(idequipo, idmante);
                DataGridView_Producto.AutoGenerateColumns = true;
                DataGridView_Producto.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Seleccione un Equipo Primero");
            }
        }

        private void Btn_ManPredictivo_Click(object sender, EventArgs e)
        {
            if (idequipo > 0)
            {
                idmante = 3;
             
                DataGridView_Producto.DataSource = Mmodel.GetMantenimientos(idequipo, idmante);
                DataGridView_Producto.AutoGenerateColumns = true;
                DataGridView_Producto.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Seleccione un Equipo Primero");
            }
        }

        private void Btn_Mando_Menu_Click(object sender, EventArgs e)
        {
            idequipo = 2;
            if (DataGridView_Producto.Rows.Count > 1)
            {
                DataGridView_Producto.DataSource = null;
                DataGridView_Producto.Rows.Clear();
            }
        }

        private void Btn_PC_Menu_Click(object sender, EventArgs e)
        {
            idequipo = 3;
            if (DataGridView_Producto.Rows.Count > 1)
            {
                DataGridView_Producto.DataSource = null;
                DataGridView_Producto.Rows.Clear();
            }
        }

        private void Btn_Presupuesto_Click(object sender, EventArgs e)
        {

            double total = 0;

            foreach (DataGridViewRow dgvr in DataGridView_Producto.Rows)
            {
                if (Convert.ToBoolean(dgvr.Cells[0].Value))
                {
                    total += Double.Parse(dgvr.Cells[2].Value.ToString());
                 //   MessageBox.Show(""+dgvr.Cells[1].Value.ToString()+"    :v    "+ dgvr.Cells[2].Value.ToString());
                }
            }

            MessageBox.Show("El presupuesto por mantenimiento es de " + total.ToString());
        }
    }
}
