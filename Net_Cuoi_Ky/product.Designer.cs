namespace Net_Cuoi_Ky
{
    partial class product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgiathue = new System.Windows.Forms.TextBox();
            this.txtkichco = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnlammoi);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(276, 6);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(81, 33);
            this.btnlammoi.TabIndex = 3;
            this.btnlammoi.Text = "Làm mới ";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(189, 6);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(81, 33);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(102, 6);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(81, 33);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(15, 6);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(81, 33);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtgiathue);
            this.panel2.Controls.Add(this.txtkichco);
            this.panel2.Controls.Add(this.txttensp);
            this.panel2.Controls.Add(this.txtmasp);
            this.panel2.Controls.Add(this.btntimkiem);
            this.panel2.Controls.Add(this.txttimkiem);
            this.panel2.Location = new System.Drawing.Point(391, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 426);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giá thuê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kích cỡ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên sản phẩm ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã sản phẩm ";
            // 
            // txtgiathue
            // 
            this.txtgiathue.Location = new System.Drawing.Point(155, 312);
            this.txtgiathue.Multiline = true;
            this.txtgiathue.Name = "txtgiathue";
            this.txtgiathue.Size = new System.Drawing.Size(225, 31);
            this.txtgiathue.TabIndex = 8;
            // 
            // txtkichco
            // 
            this.txtkichco.Location = new System.Drawing.Point(155, 259);
            this.txtkichco.Multiline = true;
            this.txtkichco.Name = "txtkichco";
            this.txtkichco.Size = new System.Drawing.Size(225, 31);
            this.txtkichco.TabIndex = 7;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(155, 193);
            this.txttensp.Multiline = true;
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(225, 31);
            this.txttensp.TabIndex = 6;
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(155, 137);
            this.txtmasp.Multiline = true;
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(225, 31);
            this.txtmasp.TabIndex = 5;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(299, 9);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(81, 33);
            this.btntimkiem.TabIndex = 4;
            this.btntimkiem.Text = "Tìm kiếm ";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(14, 11);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(279, 31);
            this.txttimkiem.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.dgvproduct);
            this.panel3.Location = new System.Drawing.Point(13, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 378);
            this.panel3.TabIndex = 2;
            // 
            // dgvproduct
            // 
            this.dgvproduct.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Location = new System.Drawing.Point(14, 20);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.RowHeadersWidth = 51;
            this.dgvproduct.RowTemplate.Height = 24;
            this.dgvproduct.Size = new System.Drawing.Size(342, 344);
            this.dgvproduct.TabIndex = 0;
            this.dgvproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduct_CellClick);
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "product";
            this.Text = "product";
            this.Load += new System.EventHandler(this.product_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvproduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgiathue;
        private System.Windows.Forms.TextBox txtkichco;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
    }
}