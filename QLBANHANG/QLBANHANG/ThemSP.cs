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
    public partial class ThemSP : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;

        void ketnoicsdl()
        {
            chuoikn = global::QLBANHANG.Properties.Settings.Default.QLBanHangConnectionString;
            ketnoi = new SqlConnection(chuoikn);
        }
        public bool KTThongTin()
        {
            if (textBoxTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTen.Focus();
                return false;
            }
            if (textBoxSL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSL.Focus();
                return false;
            }
            if (textBoxMT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxMT.Focus();
                return false;
            }
            if (textBoxGiaNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxGiaNhap.Focus();
                return false;
            }
            if (textBoxGiaBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxGiaBan.Focus();
                return false;
            }
            return true;
        }
        public ThemSP()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                this.Close();
        }

        private void ThemSP_Load(object sender, EventArgs e)
        {           
            ketnoicsdl();
        }
            public void clear()
            {
                textBoxTen.Text = "";
                textBoxSL.Text = "";
                textBoxMT.Text = "";
                textBoxGiaNhap.Text = "";
                textBoxGiaBan.Text = "";
            }

            private void buttonThem_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    string sql = string.Format("insert into SanPham VALUES (N'{0}','{1}','{2}',N'{3}',N'{4}')", textBoxTen.Text, Convert.ToInt32(textBoxSL.Text), textBoxMT.Text, textBoxGiaNhap.Text, textBoxGiaBan.Text);
                    SqlCommand cmd = new SqlCommand(sql, ketnoi);
                    ketnoi.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ketnoi.Close();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }    
}
