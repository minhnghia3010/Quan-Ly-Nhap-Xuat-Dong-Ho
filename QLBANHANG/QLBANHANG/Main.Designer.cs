
namespace QLBANHANG
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.iconButtonDangXuat = new FontAwesome.Sharp.IconButton();
            this.iconButtonThongKe = new FontAwesome.Sharp.IconButton();
            this.iconButtonHangHoa = new FontAwesome.Sharp.IconButton();
            this.iconButtonDonHang = new FontAwesome.Sharp.IconButton();
            this.iconButtonKhachHang = new FontAwesome.Sharp.IconButton();
            this.iconButtonNhanVien = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconCurrenChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbDateBig = new System.Windows.Forms.Label();
            this.lbNgayThangBig = new System.Windows.Forms.Label();
            this.labelGioBig = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrenChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.lbDateTime);
            this.panelMenu.Controls.Add(this.iconButtonDangXuat);
            this.panelMenu.Controls.Add(this.iconButtonThongKe);
            this.panelMenu.Controls.Add(this.iconButtonHangHoa);
            this.panelMenu.Controls.Add(this.iconButtonDonHang);
            this.panelMenu.Controls.Add(this.iconButtonKhachHang);
            this.panelMenu.Controls.Add(this.iconButtonNhanVien);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 687);
            this.panelMenu.TabIndex = 0;
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbDateTime.Location = new System.Drawing.Point(13, 653);
            this.lbDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(90, 25);
            this.lbDateTime.TabIndex = 7;
            this.lbDateTime.Text = "12:30:33";
            // 
            // iconButtonDangXuat
            // 
            this.iconButtonDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDangXuat.FlatAppearance.BorderSize = 0;
            this.iconButtonDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDangXuat.ForeColor = System.Drawing.Color.White;
            this.iconButtonDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.iconButtonDangXuat.IconColor = System.Drawing.Color.White;
            this.iconButtonDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDangXuat.Location = new System.Drawing.Point(0, 440);
            this.iconButtonDangXuat.Name = "iconButtonDangXuat";
            this.iconButtonDangXuat.Size = new System.Drawing.Size(220, 60);
            this.iconButtonDangXuat.TabIndex = 6;
            this.iconButtonDangXuat.Text = "Đăng Xuất";
            this.iconButtonDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDangXuat.UseVisualStyleBackColor = true;
            this.iconButtonDangXuat.Click += new System.EventHandler(this.iconButtonDangXuat_Click);
            // 
            // iconButtonThongKe
            // 
            this.iconButtonThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonThongKe.FlatAppearance.BorderSize = 0;
            this.iconButtonThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonThongKe.ForeColor = System.Drawing.Color.White;
            this.iconButtonThongKe.IconChar = FontAwesome.Sharp.IconChar.Poll;
            this.iconButtonThongKe.IconColor = System.Drawing.Color.White;
            this.iconButtonThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThongKe.Location = new System.Drawing.Point(0, 380);
            this.iconButtonThongKe.Name = "iconButtonThongKe";
            this.iconButtonThongKe.Size = new System.Drawing.Size(220, 60);
            this.iconButtonThongKe.TabIndex = 5;
            this.iconButtonThongKe.Text = "Thống Kê";
            this.iconButtonThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThongKe.UseVisualStyleBackColor = true;
            this.iconButtonThongKe.Click += new System.EventHandler(this.iconButtonThongKe_Click);
            // 
            // iconButtonHangHoa
            // 
            this.iconButtonHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonHangHoa.FlatAppearance.BorderSize = 0;
            this.iconButtonHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonHangHoa.ForeColor = System.Drawing.Color.White;
            this.iconButtonHangHoa.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButtonHangHoa.IconColor = System.Drawing.Color.White;
            this.iconButtonHangHoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHangHoa.Location = new System.Drawing.Point(0, 320);
            this.iconButtonHangHoa.Name = "iconButtonHangHoa";
            this.iconButtonHangHoa.Size = new System.Drawing.Size(220, 60);
            this.iconButtonHangHoa.TabIndex = 4;
            this.iconButtonHangHoa.Text = "Sản Phẩm";
            this.iconButtonHangHoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHangHoa.UseVisualStyleBackColor = true;
            this.iconButtonHangHoa.Click += new System.EventHandler(this.iconButtonHangHoa_Click);
            // 
            // iconButtonDonHang
            // 
            this.iconButtonDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDonHang.FlatAppearance.BorderSize = 0;
            this.iconButtonDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDonHang.ForeColor = System.Drawing.Color.White;
            this.iconButtonDonHang.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconButtonDonHang.IconColor = System.Drawing.Color.White;
            this.iconButtonDonHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDonHang.Location = new System.Drawing.Point(0, 260);
            this.iconButtonDonHang.Name = "iconButtonDonHang";
            this.iconButtonDonHang.Size = new System.Drawing.Size(220, 60);
            this.iconButtonDonHang.TabIndex = 3;
            this.iconButtonDonHang.Text = "Đơn Hàng";
            this.iconButtonDonHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDonHang.UseVisualStyleBackColor = true;
            this.iconButtonDonHang.Click += new System.EventHandler(this.iconButtonDonHang_Click);
            // 
            // iconButtonKhachHang
            // 
            this.iconButtonKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonKhachHang.FlatAppearance.BorderSize = 0;
            this.iconButtonKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonKhachHang.ForeColor = System.Drawing.Color.White;
            this.iconButtonKhachHang.IconChar = FontAwesome.Sharp.IconChar.Running;
            this.iconButtonKhachHang.IconColor = System.Drawing.Color.White;
            this.iconButtonKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonKhachHang.Location = new System.Drawing.Point(0, 200);
            this.iconButtonKhachHang.Name = "iconButtonKhachHang";
            this.iconButtonKhachHang.Size = new System.Drawing.Size(220, 60);
            this.iconButtonKhachHang.TabIndex = 2;
            this.iconButtonKhachHang.Text = "Khách Hàng";
            this.iconButtonKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonKhachHang.UseVisualStyleBackColor = true;
            this.iconButtonKhachHang.Click += new System.EventHandler(this.iconButtonKhachHang_Click);
            // 
            // iconButtonNhanVien
            // 
            this.iconButtonNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonNhanVien.FlatAppearance.BorderSize = 0;
            this.iconButtonNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonNhanVien.ForeColor = System.Drawing.Color.White;
            this.iconButtonNhanVien.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButtonNhanVien.IconColor = System.Drawing.Color.White;
            this.iconButtonNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNhanVien.Location = new System.Drawing.Point(0, 140);
            this.iconButtonNhanVien.Name = "iconButtonNhanVien";
            this.iconButtonNhanVien.Size = new System.Drawing.Size(220, 60);
            this.iconButtonNhanVien.TabIndex = 1;
            this.iconButtonNhanVien.Text = "Nhân Viên";
            this.iconButtonNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNhanVien.UseVisualStyleBackColor = true;
            this.iconButtonNhanVien.Click += new System.EventHandler(this.iconButtonNhanVien_Click);
            this.iconButtonNhanVien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iconButtonNhanVien_MouseClick);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(27, 17);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(165, 123);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.label2);
            this.panelTitleBar.Controls.Add(this.iconCurrenChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1137, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleChildForm.Location = new System.Drawing.Point(960, 29);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(135, 29);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Trang Chủ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID User:";
            // 
            // iconCurrenChildForm
            // 
            this.iconCurrenChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrenChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrenChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrenChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrenChildForm.IconSize = 52;
            this.iconCurrenChildForm.Location = new System.Drawing.Point(902, 17);
            this.iconCurrenChildForm.Name = "iconCurrenChildForm";
            this.iconCurrenChildForm.Size = new System.Drawing.Size(52, 52);
            this.iconCurrenChildForm.TabIndex = 0;
            this.iconCurrenChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1137, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Controls.Add(this.lbDateBig);
            this.panelDesktop.Controls.Add(this.lbNgayThangBig);
            this.panelDesktop.Controls.Add(this.labelGioBig);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1137, 603);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 431);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbDateBig
            // 
            this.lbDateBig.AutoSize = true;
            this.lbDateBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateBig.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbDateBig.Location = new System.Drawing.Point(7, 558);
            this.lbDateBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateBig.Name = "lbDateBig";
            this.lbDateBig.Size = new System.Drawing.Size(126, 36);
            this.lbDateBig.TabIndex = 12;
            this.lbDateBig.Text = "monday";
            // 
            // lbNgayThangBig
            // 
            this.lbNgayThangBig.AutoSize = true;
            this.lbNgayThangBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThangBig.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbNgayThangBig.Location = new System.Drawing.Point(956, 558);
            this.lbNgayThangBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayThangBig.Name = "lbNgayThangBig";
            this.lbNgayThangBig.Size = new System.Drawing.Size(177, 36);
            this.lbNgayThangBig.TabIndex = 11;
            this.lbNgayThangBig.Text = "07/11/2022";
            // 
            // labelGioBig
            // 
            this.labelGioBig.AutoSize = true;
            this.labelGioBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGioBig.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelGioBig.Location = new System.Drawing.Point(402, 431);
            this.labelGioBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGioBig.Name = "labelGioBig";
            this.labelGioBig.Size = new System.Drawing.Size(355, 91);
            this.labelGioBig.TabIndex = 10;
            this.labelGioBig.Text = "12:30:33";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1357, 687);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MN STORE";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrenChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonNhanVien;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonDangXuat;
        private FontAwesome.Sharp.IconButton iconButtonThongKe;
        private FontAwesome.Sharp.IconButton iconButtonHangHoa;
        private FontAwesome.Sharp.IconButton iconButtonDonHang;
        private FontAwesome.Sharp.IconButton iconButtonKhachHang;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrenChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label lbDateBig;
        private System.Windows.Forms.Label lbNgayThangBig;
        private System.Windows.Forms.Label labelGioBig;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}