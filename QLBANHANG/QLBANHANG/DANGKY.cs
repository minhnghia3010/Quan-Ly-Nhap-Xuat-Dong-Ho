using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLBANHANG
{
    public partial class DANGKY : Form
    {
        public DANGKY()
        {
            InitializeComponent();
        }
        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac,"^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em,@"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn)$");
        }
        MODIFY modify = new MODIFY();
        private void button_DANGKY_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TENTAIKHOAN.Text;
            string matkhau = textBox_MATKHAU.Text;
            string xmatkhau = textBox_XACNHANMATKHAU.Text;
            string email = textBox_EMAIL.Text;
            if (!CheckAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ in hoa và chữ thường!"); return; }
            if (!CheckAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, với các ký tự chữ và số, chữ in hoa và chữ thường!"); return; }
            if (xmatkhau != matkhau) { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!"); return; }
            if (CheckEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng Email!"); return; }
            if (modify.TAIKHOANs("Select * from TaiKhoan where Email ='" + email + "'").Count != 0) {MessageBox.Show("Email này đã được đăng ký, vui lòng chọn Email khác!"); return; }
            try
            {
                string query = "Insert into TaiKhoan values ('" +tentk+ "','" +matkhau+ "','" +email+ "')";
                modify.Command(query);
                if(MessageBox.Show("Đăng Ký thành công! Bạn có muốn đăng nhập luôn không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng ký tên tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
