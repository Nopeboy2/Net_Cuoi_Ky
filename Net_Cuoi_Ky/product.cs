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
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }
        Connect kn = new Connect();
        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "insert into sanpham  VALUES ('{0}', '{1}', '{2}', '{3}')",
               txtmasp.Text,
               txttensp.Text,
               txtkichco.Text,
               txtgiathue.Text

            );
            if (kn.thucthi(query) == true)
            {
                MessageBox.Show("Thêm mới thành công!");
                btnlammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }



        }

        private void product_Load(object sender, EventArgs e)
        {
            getdata();
        }
        public void getdata()
        {
            string q = "select * from sanpham";
            dgvproduct.DataSource = kn.laydulieu(q);
        }
        public void cleartext()
        {
            txtmasp.Text = "";
            txttensp.Text = "";
            txtkichco.Text = "";
            txtgiathue.Text = "";
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            cleartext();
            getdata();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string query = string.Format(
               "update sanpham set tensp ='{1}', kichco= '{2}', giathue='{3}' where masp ='{0}'",
               txtmasp.Text,
               txttensp.Text,
               txtkichco.Text,
               txtgiathue.Text
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
                "delete sanpham where masp ='{0}'",
                txtmasp.Text
            );
            if (kn.thucthi(query) == true)
            {
                MessageBox.Show("Xóa thành công!");
                btnlammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string q = string.Format(
                "select * from sanpham where masp like N'%{0}%'",
                txttimkiem.Text
                );
            dgvproduct.DataSource = kn.laydulieu(q);
        }

        private void dgvproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtmasp.Enabled = false;
                btnthem.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                txtmasp.Text = dgvproduct.Rows[r].Cells["masp"].Value.ToString();
                txttensp.Text = dgvproduct.Rows[r].Cells["tensp"].Value.ToString();
                txtkichco.Text = dgvproduct.Rows[r].Cells["kichco"].Value.ToString();
                txtgiathue.Text = dgvproduct.Rows[r].Cells["giathue"].Value.ToString();
            }
    }
}
}
