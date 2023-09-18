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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtUser.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                string query = string.Format("select * from NguoiDung where Users ='{0}' and Password ='{1}'",
                txtUser.Text,
                txtPassword.Text
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register frm = new Register();
            frm.ShowDialog();
        }
    }
}
