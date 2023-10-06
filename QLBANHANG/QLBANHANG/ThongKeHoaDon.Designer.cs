
namespace QLBANHANG
{
    partial class ThongKeHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTim = new System.Windows.Forms.ComboBox();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonIN = new System.Windows.Forms.Button();
            this.buttonCTHD = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.textBoxTT = new System.Windows.Forms.TextBox();
            this.textBoxNVB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNM = new System.Windows.Forms.TextBox();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.textBoxMaDH = new System.Windows.Forms.TextBox();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCTSP = new System.Windows.Forms.DataGridView();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(452, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ HÓA ĐƠN";
            // 
            // comboBoxTim
            // 
            this.comboBoxTim.FormattingEnabled = true;
            this.comboBoxTim.Location = new System.Drawing.Point(184, 51);
            this.comboBoxTim.Name = "comboBoxTim";
            this.comboBoxTim.Size = new System.Drawing.Size(137, 24);
            this.comboBoxTim.TabIndex = 1;
            this.comboBoxTim.SelectedIndexChanged += new System.EventHandler(this.comboBoxTim_SelectedIndexChanged);
            // 
            // textBoxTim
            // 
            this.textBoxTim.Location = new System.Drawing.Point(345, 51);
            this.textBoxTim.Multiline = true;
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(270, 52);
            this.textBoxTim.TabIndex = 3;
            // 
            // buttonTim
            // 
            this.buttonTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTim.Location = new System.Drawing.Point(637, 51);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(156, 52);
            this.buttonTim.TabIndex = 4;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(817, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "Làm Mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDSHD);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1137, 212);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // dataGridViewDSHD
            // 
            this.dataGridViewDSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaDonHang,
            this.TenKH,
            this.SDT,
            this.NhanVienBan,
            this.TongTien,
            this.NgayBan});
            this.dataGridViewDSHD.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewDSHD.Name = "dataGridViewDSHD";
            this.dataGridViewDSHD.RowHeadersWidth = 51;
            this.dataGridViewDSHD.RowTemplate.Height = 24;
            this.dataGridViewDSHD.Size = new System.Drawing.Size(1125, 185);
            this.dataGridViewDSHD.TabIndex = 0;
            this.dataGridViewDSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSHD_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.FillWeight = 40.03731F;
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            // 
            // MaDonHang
            // 
            this.MaDonHang.DataPropertyName = "MaDonHang";
            this.MaDonHang.FillWeight = 40.0349F;
            this.MaDonHang.HeaderText = "Mã Đơn Hàng";
            this.MaDonHang.MinimumWidth = 6;
            this.MaDonHang.Name = "MaDonHang";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.FillWeight = 100.0816F;
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.FillWeight = 100.0686F;
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // NhanVienBan
            // 
            this.NhanVienBan.DataPropertyName = "NhanVienBan";
            this.NhanVienBan.FillWeight = 99.51688F;
            this.NhanVienBan.HeaderText = "Nhân Viên Bán";
            this.NhanVienBan.MinimumWidth = 6;
            this.NhanVienBan.Name = "NhanVienBan";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.FillWeight = 100.1421F;
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.FillWeight = 100.1186F;
            this.NgayBan.HeaderText = "Ngày Bán";
            this.NgayBan.MinimumWidth = 6;
            this.NgayBan.Name = "NgayBan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonIN);
            this.groupBox2.Controls.Add(this.buttonCTHD);
            this.groupBox2.Controls.Add(this.buttonXoa);
            this.groupBox2.Controls.Add(this.textBoxTT);
            this.groupBox2.Controls.Add(this.textBoxNVB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxNM);
            this.groupBox2.Controls.Add(this.textBoxSDT);
            this.groupBox2.Controls.Add(this.textBoxHoTen);
            this.groupBox2.Controls.Add(this.textBoxMaDH);
            this.groupBox2.Controls.Add(this.textBoxMaHD);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 334);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Hóa Đơn";
            // 
            // buttonIN
            // 
            this.buttonIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIN.Location = new System.Drawing.Point(188, 269);
            this.buttonIN.Name = "buttonIN";
            this.buttonIN.Size = new System.Drawing.Size(144, 44);
            this.buttonIN.TabIndex = 16;
            this.buttonIN.Text = "In Danh Sách";
            this.buttonIN.UseVisualStyleBackColor = true;
            this.buttonIN.Click += new System.EventHandler(this.buttonIN_Click);
            // 
            // buttonCTHD
            // 
            this.buttonCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCTHD.Location = new System.Drawing.Point(362, 269);
            this.buttonCTHD.Name = "buttonCTHD";
            this.buttonCTHD.Size = new System.Drawing.Size(144, 44);
            this.buttonCTHD.TabIndex = 15;
            this.buttonCTHD.Text = "Chi Tiết Hóa Đơn";
            this.buttonCTHD.UseVisualStyleBackColor = true;
            this.buttonCTHD.Click += new System.EventHandler(this.buttonCTHD_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(10, 269);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(144, 44);
            this.buttonXoa.TabIndex = 14;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // textBoxTT
            // 
            this.textBoxTT.Location = new System.Drawing.Point(134, 179);
            this.textBoxTT.Name = "textBoxTT";
            this.textBoxTT.ReadOnly = true;
            this.textBoxTT.Size = new System.Drawing.Size(242, 22);
            this.textBoxTT.TabIndex = 13;
            // 
            // textBoxNVB
            // 
            this.textBoxNVB.Location = new System.Drawing.Point(134, 140);
            this.textBoxNVB.Name = "textBoxNVB";
            this.textBoxNVB.ReadOnly = true;
            this.textBoxNVB.Size = new System.Drawing.Size(242, 22);
            this.textBoxNVB.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ngày Mua";
            // 
            // textBoxNM
            // 
            this.textBoxNM.Location = new System.Drawing.Point(134, 217);
            this.textBoxNM.Name = "textBoxNM";
            this.textBoxNM.ReadOnly = true;
            this.textBoxNM.Size = new System.Drawing.Size(242, 22);
            this.textBoxNM.TabIndex = 10;
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(134, 101);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.ReadOnly = true;
            this.textBoxSDT.Size = new System.Drawing.Size(242, 22);
            this.textBoxSDT.TabIndex = 9;
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Location = new System.Drawing.Point(134, 62);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.ReadOnly = true;
            this.textBoxHoTen.Size = new System.Drawing.Size(242, 22);
            this.textBoxHoTen.TabIndex = 8;
            // 
            // textBoxMaDH
            // 
            this.textBoxMaDH.Location = new System.Drawing.Point(397, 20);
            this.textBoxMaDH.Name = "textBoxMaDH";
            this.textBoxMaDH.ReadOnly = true;
            this.textBoxMaDH.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaDH.TabIndex = 7;
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Location = new System.Drawing.Point(109, 20);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.ReadOnly = true;
            this.textBoxMaHD.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaHD.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Họ Tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tổng Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "SDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhân Viên Bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Đơn Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewCTSP);
            this.groupBox3.Location = new System.Drawing.Point(530, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(619, 84);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Sản Phẩm";
            // 
            // dataGridViewCTSP
            // 
            this.dataGridViewCTSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCTSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSP,
            this.SoLuong});
            this.dataGridViewCTSP.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewCTSP.Name = "dataGridViewCTSP";
            this.dataGridViewCTSP.RowHeadersWidth = 51;
            this.dataGridViewCTSP.RowTemplate.Height = 24;
            this.dataGridViewCTSP.Size = new System.Drawing.Size(607, 58);
            this.dataGridViewCTSP.TabIndex = 0;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 60F;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // ThongKeHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1161, 664);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.textBoxTim);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxTim);
            this.Controls.Add(this.label1);
            this.Name = "ThongKeHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Hóa Đơn";
            this.Load += new System.EventHandler(this.ThongKeHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTim;
        private System.Windows.Forms.TextBox textBoxTim;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewDSHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxMaHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewCTSP;
        private System.Windows.Forms.Button buttonCTHD;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.TextBox textBoxTT;
        private System.Windows.Forms.TextBox textBoxNVB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNM;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.TextBox textBoxMaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Button buttonIN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}