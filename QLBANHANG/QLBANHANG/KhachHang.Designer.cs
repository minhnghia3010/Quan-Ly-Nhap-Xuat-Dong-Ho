
namespace QLBANHANG
{
    partial class KhachHang
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
            this.buttonThemKH = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.comboBoxTimLoai = new System.Windows.Forms.ComboBox();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.buttonDSKH = new System.Windows.Forms.Button();
            this.buttonDangKyMua = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.dataGridViewDSKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxNhanVien = new System.Windows.Forms.ComboBox();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.textBoxGioiTinh = new System.Windows.Forms.TextBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewDSKHCho = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSKHCho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(427, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông Tin Khách Hàng";
            // 
            // buttonThemKH
            // 
            this.buttonThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemKH.Location = new System.Drawing.Point(459, 66);
            this.buttonThemKH.Name = "buttonThemKH";
            this.buttonThemKH.Size = new System.Drawing.Size(139, 48);
            this.buttonThemKH.TabIndex = 2;
            this.buttonThemKH.Text = "Thêm Khách Hàng";
            this.buttonThemKH.UseVisualStyleBackColor = true;
            this.buttonThemKH.Click += new System.EventHandler(this.buttonThemKH_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1114, 580);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.buttonXoa);
            this.tabPage1.Controls.Add(this.buttonLamMoi);
            this.tabPage1.Controls.Add(this.buttonDSKH);
            this.tabPage1.Controls.Add(this.buttonDangKyMua);
            this.tabPage1.Controls.Add(this.buttonCapNhat);
            this.tabPage1.Controls.Add(this.dataGridViewDSKH);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonThemKH);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1106, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông Tin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonTim);
            this.groupBox2.Controls.Add(this.textBoxTim);
            this.groupBox2.Controls.Add(this.comboBoxTimLoai);
            this.groupBox2.Location = new System.Drawing.Point(459, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 87);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm Khách Hàng";
            // 
            // buttonTim
            // 
            this.buttonTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTim.Location = new System.Drawing.Point(535, 22);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(91, 48);
            this.buttonTim.TabIndex = 19;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // textBoxTim
            // 
            this.textBoxTim.Location = new System.Drawing.Point(212, 35);
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(307, 22);
            this.textBoxTim.TabIndex = 13;
            // 
            // comboBoxTimLoai
            // 
            this.comboBoxTimLoai.FormattingEnabled = true;
            this.comboBoxTimLoai.Location = new System.Drawing.Point(18, 35);
            this.comboBoxTimLoai.Name = "comboBoxTimLoai";
            this.comboBoxTimLoai.Size = new System.Drawing.Size(178, 24);
            this.comboBoxTimLoai.TabIndex = 0;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(792, 66);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(139, 48);
            this.buttonXoa.TabIndex = 17;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamMoi.Location = new System.Drawing.Point(525, 125);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(182, 48);
            this.buttonLamMoi.TabIndex = 16;
            this.buttonLamMoi.Text = "Làm Mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // buttonDSKH
            // 
            this.buttonDSKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDSKH.Location = new System.Drawing.Point(855, 125);
            this.buttonDSKH.Name = "buttonDSKH";
            this.buttonDSKH.Size = new System.Drawing.Size(182, 48);
            this.buttonDSKH.TabIndex = 15;
            this.buttonDSKH.Text = "Danh Sách Khách Hàng Đã Mua";
            this.buttonDSKH.UseVisualStyleBackColor = true;
            this.buttonDSKH.Click += new System.EventHandler(this.buttonDSKH_Click);
            // 
            // buttonDangKyMua
            // 
            this.buttonDangKyMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangKyMua.Location = new System.Drawing.Point(961, 66);
            this.buttonDangKyMua.Name = "buttonDangKyMua";
            this.buttonDangKyMua.Size = new System.Drawing.Size(139, 48);
            this.buttonDangKyMua.TabIndex = 14;
            this.buttonDangKyMua.Text = "Đăng Ký Mua";
            this.buttonDangKyMua.UseVisualStyleBackColor = true;
            this.buttonDangKyMua.Click += new System.EventHandler(this.buttonDangKyMua_Click);
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapNhat.Location = new System.Drawing.Point(625, 66);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(139, 48);
            this.buttonCapNhat.TabIndex = 13;
            this.buttonCapNhat.Text = "Cập Nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // dataGridViewDSKH
            // 
            this.dataGridViewDSKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.SDT,
            this.DiaChi,
            this.GioiTinh});
            this.dataGridViewDSKH.Location = new System.Drawing.Point(6, 282);
            this.dataGridViewDSKH.Name = "dataGridViewDSKH";
            this.dataGridViewDSKH.RowHeadersWidth = 51;
            this.dataGridViewDSKH.RowTemplate.Height = 24;
            this.dataGridViewDSKH.Size = new System.Drawing.Size(1094, 263);
            this.dataGridViewDSKH.TabIndex = 12;
            this.dataGridViewDSKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSKH_CellClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.FillWeight = 30F;
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.FillWeight = 80F;
            this.TenKH.HeaderText = "Họ Tên";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.FillWeight = 60F;
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.FillWeight = 40F;
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxNhanVien);
            this.groupBox1.Controls.Add(this.textBoxSDT);
            this.groupBox1.Controls.Add(this.textBoxGioiTinh);
            this.groupBox1.Controls.Add(this.textBoxDiaChi);
            this.groupBox1.Controls.Add(this.textBoxTen);
            this.groupBox1.Controls.Add(this.textBoxMaKH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng Đăng Ký Mua";
            // 
            // comboBoxNhanVien
            // 
            this.comboBoxNhanVien.FormattingEnabled = true;
            this.comboBoxNhanVien.Location = new System.Drawing.Point(134, 179);
            this.comboBoxNhanVien.Name = "comboBoxNhanVien";
            this.comboBoxNhanVien.Size = new System.Drawing.Size(307, 24);
            this.comboBoxNhanVien.TabIndex = 12;
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(134, 87);
            this.textBoxSDT.MaxLength = 10;
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(307, 22);
            this.textBoxSDT.TabIndex = 10;
            // 
            // textBoxGioiTinh
            // 
            this.textBoxGioiTinh.Location = new System.Drawing.Point(134, 148);
            this.textBoxGioiTinh.Name = "textBoxGioiTinh";
            this.textBoxGioiTinh.Size = new System.Drawing.Size(307, 22);
            this.textBoxGioiTinh.TabIndex = 9;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(134, 116);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(307, 22);
            this.textBoxDiaChi.TabIndex = 8;
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(134, 58);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(307, 22);
            this.textBoxTen.TabIndex = 7;
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(134, 28);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.ReadOnly = true;
            this.textBoxMaKH.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaKH.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nhân Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewDSKHCho);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1106, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh Sách Khách Hàng Chờ Mua";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDSKHCho
            // 
            this.dataGridViewDSKHCho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSKHCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSKHCho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.TenKHang,
            this.SDThoai,
            this.TinhTrang});
            this.dataGridViewDSKHCho.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewDSKHCho.Name = "dataGridViewDSKHCho";
            this.dataGridViewDSKHCho.RowHeadersWidth = 51;
            this.dataGridViewDSKHCho.RowTemplate.Height = 24;
            this.dataGridViewDSKHCho.Size = new System.Drawing.Size(1094, 539);
            this.dataGridViewDSKHCho.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDSKH";
            this.Column1.HeaderText = "Mã Danh Sách Khách Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // TenKHang
            // 
            this.TenKHang.DataPropertyName = "TenKH";
            this.TenKHang.HeaderText = "Tên Khách Hàng";
            this.TenKHang.MinimumWidth = 6;
            this.TenKHang.Name = "TenKHang";
            // 
            // SDThoai
            // 
            this.SDThoai.DataPropertyName = "SDT";
            this.SDThoai.HeaderText = "Số Điện Thoại";
            this.SDThoai.MinimumWidth = 6;
            this.SDThoai.Name = "SDThoai";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            // 
            // KhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1161, 635);
            this.Controls.Add(this.tabControl1);
            this.Name = "KhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSKHCho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonThemKH;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewDSKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxNhanVien;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.TextBox textBoxGioiTinh;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDSKH;
        private System.Windows.Forms.Button buttonDangKyMua;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.DataGridView dataGridViewDSKHCho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.TextBox textBoxTim;
        private System.Windows.Forms.ComboBox comboBoxTimLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
    }
}