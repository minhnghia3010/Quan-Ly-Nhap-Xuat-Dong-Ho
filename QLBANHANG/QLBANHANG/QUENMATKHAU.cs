using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBANHANG
{
    public partial class QUENMATKHAU : Form
    {
        public QUENMATKHAU()
        {
            InitializeComponent();
            label2.Text = "";
        }
        MODIFY modify = new MODIFY();
        private void button_LAYLAIMATKHAU_Click(object sender, EventArgs e)
        {
            string email = textBox_EMAILDANGKY.Text;
            if(email.Trim() == "") { MessageBox.Show("Vui lòng nhập Email đã đăng ký!"); }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if (modify.TAIKHOANs(query).Count != 0)
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật khẩu: " + modify.TAIKHOANs(query)[0].MatKhau;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa được đăng ký!";
                }
            }
        }
    }
}
