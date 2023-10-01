using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
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
            
            if (txtMatKhau.Text != txtConfirm.Text || txtTaiKhoan.Text == string.Empty || txtMatKhau.Text == string.Empty || txtConfirm.Text == string.Empty)
            {
                MessageBox.Show("Register Fail !");
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
                txtConfirm.Clear();
            }
            else
            {
                string query = string.Format(
                    "insert into TaiKhoan(TenTK, MatKhau) values (N'{0}',N'{1}')",
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
                    MessageBox.Show("Register F!");
                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                    txtConfirm.Clear();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.ShowDialog();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            

        }
    }
}
