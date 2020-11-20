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
        public Principal()
        {
            InitializeComponent();
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
    }
}
