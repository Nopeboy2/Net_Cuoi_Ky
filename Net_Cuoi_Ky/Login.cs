using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Net_Cuoi_Ky
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Connect connect = new Connect();
        private void Form1_Load(object sender, EventArgs e)
        {
                string query = "select * from LoaiTaiKhoan";
                DataTable tb = connect.laydulieu(query);
                cbbLoaiTK.DataSource = tb;
                //cbbLoaiTK.DisplayMember = "LoaiTK";
                cbbLoaiTK.ValueMember = "LoaiTK";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtUser.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                string query = string.Format("select * from TaiKhoan where TenTK ='{0}' and MatKhau ='{1}' and LoaiTK='{2}'",
                txtUser.Text,
                txtPassword.Text,
                cbbLoaiTK.SelectedValue
                );
                DataTable dt = connect.laydulieu(query);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Success !");
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Fail !");
                }
            }
            else
            {
                MessageBox.Show("Fill your username and password !");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register frm = new Register();
            frm.ShowDialog();
        }
    }
}
