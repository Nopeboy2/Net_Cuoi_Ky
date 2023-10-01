using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net_Cuoi_Ky
{
    public partial class ChangePassWord : Form
    {
        public ChangePassWord()
        {
            InitializeComponent();
        }
        Connect connect = new Connect();
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == txtConfirm.Text)
            {
                string query = string.Format("update NguoiDung set Password = N'{1}' where Users= N'{0}' and Password = N'{2}'",
                txtTaiKhoan.Text,
                txtMatKhauMoi.Text,
                txtMatKhau.Text
                );
                bool kt = connect.thucthi(query);
                if (kt)
                {
                    MessageBox.Show(" Update Success !");
                    txtTaiKhoan.Clear();
                    txtMatKhauMoi.Clear();
                    txtConfirm.Clear();
                    txtMatKhau.Clear();
                }
                else
                {
                    MessageBox.Show(" Update Fail !");
                }
            }
            else
            {
                MessageBox.Show("Account or Password is incorrect !");
                txtTaiKhoan.Clear();
                txtMatKhauMoi.Clear();
                txtConfirm.Clear();
            }    
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home frm = new Home();  
            frm.ShowDialog();
        }

        private void ChangePassWord_Load(object sender, EventArgs e)
        {

        }
    }
}
