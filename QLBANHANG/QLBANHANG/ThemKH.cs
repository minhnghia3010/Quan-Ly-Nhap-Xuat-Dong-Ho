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
    public partial class ThemKH : Form
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
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            return true;
        }
        public ThemKH()
        {
            InitializeComponent();
        }

        private void ThemKH_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    string Gioitinh = "";
                    if (radioButtonNam.Checked == true)
                    {
                        Gioitinh = radioButtonNam.Text;
                    }
                    if (radioButtonNu.Checked == true)
                    {
                        Gioitinh = radioButtonNu.Text;
                    }
                    string sql = string.Format("insert into KhachHang(TenKH, SDT, DiaChi, GioiTinh) VALUES (N'{0}', '{1}', N'{2}', N'{3}')", textBoxTen.Text, textBoxSDT.Text,textBoxDiaChi.Text, Gioitinh);
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
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                this.Close();
        }

        private void textBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }  
}
