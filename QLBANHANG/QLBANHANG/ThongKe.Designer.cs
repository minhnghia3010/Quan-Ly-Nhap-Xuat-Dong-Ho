
namespace QLBANHANG
{
    partial class ThongKe
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
            this.buttonTKHoaDon = new System.Windows.Forms.Button();
            this.buttonThongKeNgay = new System.Windows.Forms.Button();
            this.buttonThongKeDTNam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTKHoaDon
            // 
            this.buttonTKHoaDon.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTKHoaDon.Location = new System.Drawing.Point(70, 67);
            this.buttonTKHoaDon.Name = "buttonTKHoaDon";
            this.buttonTKHoaDon.Size = new System.Drawing.Size(372, 139);
            this.buttonTKHoaDon.TabIndex = 0;
            this.buttonTKHoaDon.Text = "Thống Kê Hóa Đơn";
            this.buttonTKHoaDon.UseVisualStyleBackColor = true;
            this.buttonTKHoaDon.Click += new System.EventHandler(this.buttonTKHoaDon_Click);
            // 
            // buttonThongKeNgay
            // 
            this.buttonThongKeNgay.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKeNgay.Location = new System.Drawing.Point(712, 67);
            this.buttonThongKeNgay.Name = "buttonThongKeNgay";
            this.buttonThongKeNgay.Size = new System.Drawing.Size(372, 139);
            this.buttonThongKeNgay.TabIndex = 2;
            this.buttonThongKeNgay.Text = "Thống Kê Ngày";
            this.buttonThongKeNgay.UseVisualStyleBackColor = true;
            this.buttonThongKeNgay.Click += new System.EventHandler(this.buttonThongKeNgay_Click);
            // 
            // buttonThongKeDTNam
            // 
            this.buttonThongKeDTNam.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKeDTNam.Location = new System.Drawing.Point(397, 398);
            this.buttonThongKeDTNam.Name = "buttonThongKeDTNam";
            this.buttonThongKeDTNam.Size = new System.Drawing.Size(372, 139);
            this.buttonThongKeDTNam.TabIndex = 3;
            this.buttonThongKeDTNam.Text = "Biểu Đồ Doanh Thu Theo Tháng";
            this.buttonThongKeDTNam.UseVisualStyleBackColor = true;
            this.buttonThongKeDTNam.Click += new System.EventHandler(this.buttonThongKeDTNam_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1151, 549);
            this.Controls.Add(this.buttonThongKeDTNam);
            this.Controls.Add(this.buttonThongKeNgay);
            this.Controls.Add(this.buttonTKHoaDon);
            this.Name = "ThongKe";
            this.Text = "Thống Kê";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTKHoaDon;
        private System.Windows.Forms.Button buttonThongKeNgay;
        private System.Windows.Forms.Button buttonThongKeDTNam;
    }
}