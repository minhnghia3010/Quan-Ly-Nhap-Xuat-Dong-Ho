
namespace QLBANHANG
{
    partial class DANGKY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DANGKY));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TENTAIKHOAN = new System.Windows.Forms.TextBox();
            this.textBox_MATKHAU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_XACNHANMATKHAU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_EMAIL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_DANGKY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // textBox_TENTAIKHOAN
            // 
            this.textBox_TENTAIKHOAN.Location = new System.Drawing.Point(240, 180);
            this.textBox_TENTAIKHOAN.Name = "textBox_TENTAIKHOAN";
            this.textBox_TENTAIKHOAN.Size = new System.Drawing.Size(274, 22);
            this.textBox_TENTAIKHOAN.TabIndex = 4;
            // 
            // textBox_MATKHAU
            // 
            this.textBox_MATKHAU.Location = new System.Drawing.Point(240, 232);
            this.textBox_MATKHAU.Name = "textBox_MATKHAU";
            this.textBox_MATKHAU.Size = new System.Drawing.Size(274, 22);
            this.textBox_MATKHAU.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu";
            // 
            // textBox_XACNHANMATKHAU
            // 
            this.textBox_XACNHANMATKHAU.Location = new System.Drawing.Point(240, 282);
            this.textBox_XACNHANMATKHAU.Name = "textBox_XACNHANMATKHAU";
            this.textBox_XACNHANMATKHAU.Size = new System.Drawing.Size(274, 22);
            this.textBox_XACNHANMATKHAU.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Xác Nhận Mật Khẩu";
            // 
            // textBox_EMAIL
            // 
            this.textBox_EMAIL.Location = new System.Drawing.Point(240, 332);
            this.textBox_EMAIL.Name = "textBox_EMAIL";
            this.textBox_EMAIL.Size = new System.Drawing.Size(274, 22);
            this.textBox_EMAIL.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // button_DANGKY
            // 
            this.button_DANGKY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DANGKY.Location = new System.Drawing.Point(205, 398);
            this.button_DANGKY.Name = "button_DANGKY";
            this.button_DANGKY.Size = new System.Drawing.Size(125, 40);
            this.button_DANGKY.TabIndex = 11;
            this.button_DANGKY.Text = "Đăng Ký";
            this.button_DANGKY.UseVisualStyleBackColor = true;
            this.button_DANGKY.Click += new System.EventHandler(this.button_DANGKY_Click);
            // 
            // DANGKY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 499);
            this.Controls.Add(this.button_DANGKY);
            this.Controls.Add(this.textBox_EMAIL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_XACNHANMATKHAU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_MATKHAU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_TENTAIKHOAN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DANGKY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TENTAIKHOAN;
        private System.Windows.Forms.TextBox textBox_MATKHAU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_XACNHANMATKHAU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_EMAIL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_DANGKY;
    }
}