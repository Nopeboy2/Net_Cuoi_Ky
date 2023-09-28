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
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            product frm = new product();
            frm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer frm = new Customer();
            frm.Show();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassWord frm = new ChangePassWord();
            frm.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }
    }
}
