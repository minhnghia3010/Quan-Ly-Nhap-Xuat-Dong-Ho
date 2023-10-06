using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBANHANG
{

    public partial class DANGNHAP : Form
    {
        public static string username;
        public DANGNHAP()
        {
            InitializeComponent();
        }

        private void linkLabel_QUENMATKHAU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QUENMATKHAU qUENMATKHAU = new QUENMATKHAU();
            qUENMATKHAU.ShowDialog();
        }

        private void linkLabel_DANGKY_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DANGKY dANGKY = new DANGKY();
            dANGKY.ShowDialog();
        }
        MODIFY modify = new MODIFY();

        private void button_DANGNHAP_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TENDANGNHAP.Text;
            string matkhau = textBox_MATKHAU.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "'and MatKhau = '" + matkhau + "'";
                if (modify.TAIKHOANs(query).Count != 0)
                {
                    this.Hide();
                    username = textBox_TENDANGNHAP.Text;
                    Main main1 = new Main();
                    main1.Show();
                    Main main = new Main();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void textBox_TENDANGNHAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_MATKHAU_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TENDANGNHAP_Click(object sender, EventArgs e)
        {
            if (textBox_TENDANGNHAP.Text == "Nhập Tên Đăng Nhập")
            {
                textBox_TENDANGNHAP.Clear();
            }
        }

        private void textBox_MATKHAU_Click(object sender, EventArgs e)
        {
            if (textBox_MATKHAU.Text == "Nhập Mật Khẩu")
            {
                textBox_MATKHAU.Clear();
            }
        }

        private void DANGNHAP_Load(object sender, EventArgs e)
        {
      
        }
    }
}
