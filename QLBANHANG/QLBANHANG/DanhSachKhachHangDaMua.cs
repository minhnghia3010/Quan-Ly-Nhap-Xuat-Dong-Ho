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
    public partial class DanhSachKhachHangDaMua : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;
        void ketnoicsdl()
        {
            chuoikn = global::QLBANHANG.Properties.Settings.Default.QLBanHangConnectionString;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select * from ThongTinKHDaMua ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridViewTTCT.DataSource = dt;
        }
        void sp()
        {
            ketnoi.Open();
            string sql = "select TenSP, SoLuong from SanPhamKH where MaDonHang = '" + textBoxMaDH.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridViewTTSP.DataSource = dt;
        }
        public DanhSachKhachHangDaMua()
        {
            InitializeComponent();
        }
        public void cbxloaitk()
        {
            List<string> loaitk = new List<string>() { "Tên Khách Hàng", "SĐT" };
            comboBoxTim.DataSource = loaitk;
        }

        private void DanhSachKhachHangDaMua_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            cbxloaitk();
        }

        private void dataGridViewTTCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int luuban;
            luuban = e.RowIndex;
            textBoxMKHDM.Text = dataGridViewTTCT.Rows[luuban].Cells[0].Value.ToString();
            textBoxMaDH.Text = dataGridViewTTCT.Rows[luuban].Cells[1].Value.ToString();
            textBoxHoTen.Text = dataGridViewTTCT.Rows[luuban].Cells[2].Value.ToString();
            textBoxSDT.Text = dataGridViewTTCT.Rows[luuban].Cells[3].Value.ToString();
            sp();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from ThongTinKHDaMua where MaTTKHDM = ('{0}')", textBoxMKHDM.Text);
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            ketnoi.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            string sqlrs = "select * from ThongTinKHDaMua";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "ThongTinKHDaMua");
            dataGridViewTTCT.DataSource = ds.Tables[0];
            textBoxTim.Text = "";
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (comboBoxTim.Text == "Tên Khách Hàng")
            {
                string sql = "select * from ThongTinKHDaMua where TenKH like N'%" + textBoxTim.Text.Trim() + "%' ";
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.CommandType = CommandType.Text;
                bodocghi = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                bodocghi.Fill(dt);
                ketnoi.Close();
                dataGridViewTTCT.DataSource = dt;
            }
            if (comboBoxTim.Text == "SĐT")
            {
                string sql = "select * from ThongTinKHDaMua where SDT like '%" + textBoxTim.Text.Trim() + "%' ";
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.CommandType = CommandType.Text;
                bodocghi = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                bodocghi.Fill(dt);
                ketnoi.Close();
                dataGridViewTTCT.DataSource = dt;
            }
        }
    }
}
