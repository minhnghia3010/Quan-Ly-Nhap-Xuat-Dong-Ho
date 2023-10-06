
namespace QLBANHANG
{
    partial class QUENMATKHAU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QUENMATKHAU));
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_EMAILDANGKY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_LAYLAIMATKHAU = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kết Quả";
            // 
            // textBox_EMAILDANGKY
            // 
            this.textBox_EMAILDANGKY.Location = new System.Drawing.Point(211, 185);
            this.textBox_EMAILDANGKY.Name = "textBox_EMAILDANGKY";
            this.textBox_EMAILDANGKY.Size = new System.Drawing.Size(274, 22);
            this.textBox_EMAILDANGKY.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email Đăng Ký";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button_LAYLAIMATKHAU
            // 
            this.button_LAYLAIMATKHAU.AutoSize = true;
            this.button_LAYLAIMATKHAU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LAYLAIMATKHAU.Location = new System.Drawing.Point(166, 290);
            this.button_LAYLAIMATKHAU.Name = "button_LAYLAIMATKHAU";
            this.button_LAYLAIMATKHAU.Size = new System.Drawing.Size(194, 51);
            this.button_LAYLAIMATKHAU.TabIndex = 10;
            this.button_LAYLAIMATKHAU.Text = "Lấy Lại Mật Khẩu";
            this.button_LAYLAIMATKHAU.UseVisualStyleBackColor = true;
            this.button_LAYLAIMATKHAU.Click += new System.EventHandler(this.button_LAYLAIMATKHAU_Click);
            // 
            // QUENMATKHAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.button_LAYLAIMATKHAU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_EMAILDANGKY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QUENMATKHAU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_EMAILDANGKY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_LAYLAIMATKHAU;
    }
}