using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net_Cuoi_Ky
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            product frm = new product();
            frm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void đổiMaathKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassWord frm = new ChangePassWord();              
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer frm = new Customer();
            frm.Show();

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu frm = new Menu();
            frm.Show();
        }
    }
}
