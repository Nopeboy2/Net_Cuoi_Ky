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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        Connect kn = new Connect();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            getData();  
        }
        public void getData()
        {
            string q = " select * from khachhang";
            dgvcustomer.DataSource = kn.laydulieu(q);
        }
        public void cleartext()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtsodt.Text = "";
            txtsodt.Text = "";
            txttimkiem.Text = "";
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            cleartext();
            getData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "insert into khachhang  VALUES ('{0}', '{1}', '{2}', '{3}')",
                txtmakh.Text,
                txttenkh.Text,
                txtsodt.Text,
                txtemail.Text

            );
            if (kn.thucthi(query)==true)
            {
                MessageBox.Show("Thêm mới thành công!");
                btnlammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "update khachhang set  tenkh ='{1}', sdt= '{2}', email ='{3}' where makh ='{0}'",
                txtmakh.Text,
                txttenkh.Text,
                txtsodt.Text,
                txtemail.Text

            );
            if (kn.thucthi(query) == true)
            {
                MessageBox.Show("Sửa thành công!");
                btnlammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa  thất bại!");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "delete  khachhang where makh ='{0}'",
                txtmakh.Text
                

            );
            if (kn.thucthi(query) == true)
            {
                MessageBox.Show("Xóa thành công!");
                btnlammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa   thất bại!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string q = string.Format(
                "Select * from khachhang where makh = '{0}'",
                txtmakh.Text);
            dgvcustomer.DataSource = kn.laydulieu(q);
        }

        private void dgvcustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtmakh.Enabled = false;
                btnthem.Enabled = false;
                btnsua.Enabled = true;
                btnxoa .Enabled = true;

                txtmakh.Text = dgvcustomer.Rows[r].Cells["makh"].Value.ToString();
                txttenkh.Text = dgvcustomer.Rows[r].Cells["tenkh"].Value.ToString();
                txtsodt.Text = dgvcustomer.Rows[r].Cells["sdt"].Value.ToString();
                txtemail.Text = dgvcustomer.Rows[r].Cells["email"].Value.ToString();
                
            }
        }
    }
}
