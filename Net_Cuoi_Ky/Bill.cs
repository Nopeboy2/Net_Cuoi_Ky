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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }
        Connect kn = new Connect(); 


        private void Menu_Load(object sender, EventArgs e)
        {
            getcombobox();
            getdata();
        }
        public void getdata()
        {
            string q = "select * from hoadon";
            dgvmenu.DataSource = kn.laydulieu(q);
        }
        public void getcombobox()
        {
            string q = " Select * from khachhang";
            cmbmakh.DataSource = kn.laydulieu(q);
            cmbmakh.DisplayMember = "makh";
            cmbmakh.ValueMember = "makh";

            string query = " Select * from sanpham";
            cmbmasp.DataSource = kn.laydulieu(query);
            cmbmasp.DisplayMember = "masp";
            cmbmasp.ValueMember = "masp";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            
        }
        public void cleardata()
        {
            txtmahd.Text = "";
            txttenkh.Text = "";
            txttensp.Text = "";
            txtthanhtoan.Text = "";
            txttimkiem.Text = "";
        }
        private void btnkammoi_Click(object sender, EventArgs e)
        {
            cleardata();
            getdata();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
