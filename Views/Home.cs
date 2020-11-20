//using Domain;
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
    public partial class Home : Form
    {
// HEAD
      //  addelements elements = new addelements();
//=======
     //    ManteniminetoDao Mdao = new ManteniminetoDao();
// Dao1
        public Home()
        {

            

            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

//<<<<<<< HEAD
          //   dgv.DataSource = elements.populate(dgv);
//=======
        //    dgv.DataSource = Mdao.MostarMantenimientos();
//>>>>>>> Dao1
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Maximeze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Btn_Restore_Windows.Visible = true;
            Btn_Maximeze.Visible = false;
        }

        private void Btn_Restore_Windows_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Btn_Restore_Windows.Visible = false;
            Btn_Maximeze.Visible = true;
        }

        private void Left_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
