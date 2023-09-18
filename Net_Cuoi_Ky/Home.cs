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
            Products frm = new Products();
            frm.MdiParent = this;
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
    }
}
