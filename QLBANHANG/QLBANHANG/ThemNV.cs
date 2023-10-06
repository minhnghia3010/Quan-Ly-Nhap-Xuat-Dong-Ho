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
    public partial class ThemNV : Form
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
                MessageBox.Show("Vui lòng nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTen.Focus();
                return false;
            }
            if (textBoxDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDiaChi.Focus();
                return false;
            }
            if (textBoxSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập SĐT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSDT.Focus();
                return false;
            }
            if (textBoxLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxLuong.Focus();
                return false;
            }
            return true;
        }

        public ThemNV()
        {
            InitializeComponent();
        }

        private void ThemNV_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    string sql = string.Format("insert into NhanVien VALUES (N'{0}','{1}',N'{2}','{3}')",textBoxTen.Text, textBoxSDT.Text, textBoxDiaChi.Text, textBoxLuong.Text);
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
        public void clear()
        {
            textBoxTen.Text = "";
            textBoxDiaChi.Text = "";
            textBoxSDT.Text = "";
            textBoxLuong.Text = "";
        }

        private void textBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                this.Close();
        }
    }
}
