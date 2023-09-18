using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Net_Cuoi_Ky
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        Connect connect = new Connect();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text == txtConfirm.Text)
            {
                string query = string.Format(
                "insert into NguoiDung values (N'{0}',N'{1}')",
                txtTaiKhoan.Text,
                txtMatKhau.Text
                );
                bool kt = connect.thucthi(query);
                if (kt)
                {
                    MessageBox.Show("Register Success !");
                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                    txtConfirm.Clear();
                }
                else
                {
                    MessageBox.Show("Register Fail !");
                }
            }
            else
            {
                MessageBox.Show("Account or Password is incorrect !");
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
                txtConfirm.Clear();
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.ShowDialog();
        }
    }
}
