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
        }

        private void Btn_ManPreventivo_Click(object sender, EventArgs e)
        {
            idmante = 1;

            DataGridView_Producto.DataSource = Mmodel.GetMantenimientos(idequipo, idmante);
            DataGridView_Producto.AutoGenerateColumns = true;
            DataGridView_Producto.AutoResizeColumns();
        }

        private void Btn_ManCorrectivo_Click(object sender, EventArgs e)
        {
            idmante = 2;

            DataGridView_Producto.DataSource = Mmodel.GetMantenimientos(idequipo, idmante);
            DataGridView_Producto.AutoGenerateColumns = true;
            DataGridView_Producto.AutoResizeColumns();
        }

        private void Btn_ManPredictivo_Click(object sender, EventArgs e)
        {
            idmante = 3;

            DataGridView_Producto.DataSource = Mmodel.GetMantenimientos(idequipo, idmante);
            DataGridView_Producto.AutoGenerateColumns = true;
            DataGridView_Producto.AutoResizeColumns();
        }
    }
}
