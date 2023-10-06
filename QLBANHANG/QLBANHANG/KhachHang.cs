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
    public partial class KhachHang : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;

        void ketnoicsdl()
        {
            chuoikn = global::QLBANHANG.Properties.Settings.Default.QLBanHangConnectionString;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select MaKH, TenKH, SDT, DiaChi, GioiTinh from KhachHang ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridViewDSKH.DataSource = dt;

            ketnoi.Open();
            string ssql = "select IDdsbn, TenKH, SDT, TinhTrang from DanhSachKhachHang where TinhTrang = N'" + "Chưa Mua" + "' ";
            SqlCommand ccmd = new SqlCommand(ssql, ketnoi);
            ccmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(ccmd);
            DataTable dtb = new DataTable();
            ketnoi.Close();
            dataGridViewDSKHCho.DataSource = dtb;
        }
        public KhachHang()
        {
            InitializeComponent();
        }
        public void nvb()
        {
            string sql = "select * from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            bodocghi = new SqlDataAdapter();
            bodocghi.SelectCommand = cmd;
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);

            comboBoxNhanVien.DataSource = dt;
            comboBoxNhanVien.DisplayMember = "TenNV";
            comboBoxNhanVien.ValueMember = "MaNV";
        }
        private void buttonThemKH_Click(object sender, EventArgs e)
        {
            ThemKH tkh = new ThemKH();
            tkh.ShowDialog();
        }
        public void cbxloaitk()
        {
            List<string> loaitk = new List<string>() { "Tên Khách Hàng", "Số Điện Thoại", "Địa Chỉ" };
            comboBoxTimLoai.DataSource = loaitk;
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            nvb();
            cbxloaitk();
        }

        private void dataGridViewDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int luubn;
                luubn = e.RowIndex;
                textBoxMaKH.Text = dataGridViewDSKH.Rows[luubn].Cells[0].Value.ToString();
                textBoxTen.Text = dataGridViewDSKH.Rows[luubn].Cells[1].Value.ToString();
                textBoxSDT.Text = dataGridViewDSKH.Rows[luubn].Cells[2].Value.ToString();
                textBoxDiaChi.Text = dataGridViewDSKH.Rows[luubn].Cells[3].Value.ToString();
                textBoxGioiTinh.Text = dataGridViewDSKH.Rows[luubn].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql = ("update KhachHang set TenKH = N'" +textBoxTen.Text + "', SDT = '" + textBoxSDT.Text + "', DiaChi  = N'" + textBoxDiaChi.Text + "', GioiTinh = N'" + textBoxGioiTinh.Text + "'where MaKH = '" + int.Parse(textBoxMaKH.Text) + "'");
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("delete from KhachHang where MaKH = ('{0}')", textBoxMaKH.Text);
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                ketnoi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ketnoi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            string sqlrs = "select MaKH, TenKH, SDT, DiaChi, GioiTinh from KhachHang";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "KhachHang");
            dataGridViewDSKH.DataSource = ds.Tables[0];

            string sqlrs1 = "select MaDSKH, TenKH, SDT, TinhTrang from DanhSachKhachHang where TinhTrang = N'" + "Chưa Mua" + "' ";
            SqlDataAdapter dat1 = new SqlDataAdapter(sqlrs1, ketnoi);
            DataSet ds1 = new System.Data.DataSet();
            dat1.Fill(ds1, "DanhSachKhachHang");
            dataGridViewDSKHCho.DataSource = ds1.Tables[0];
            textBoxTim.Text = "";
        }

        private void buttonDangKyMua_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into DanhSachKhachHang(MaKH, TenKH, SDT, NhanVienBan, TinhTrang, MaNV) VALUES ('{0}', N'{1}', '{2}', N'{3}', N'{4}', '{5}')", textBoxMaKH.Text, textBoxTen.Text, textBoxSDT.Text, comboBoxNhanVien.Text, "Chưa Mua", int.Parse(comboBoxNhanVien.SelectedValue.ToString()));
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            ketnoi.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đăng Ký Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (comboBoxTimLoai.Text == "Tên Khách Hàng")
            {
                string sql = "select MaKH, TenKH, SDT, DiaChi, GioiTinh from KhachHang where TenKH like N'%" + textBoxTim.Text.Trim() + "%' ";
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.CommandType = CommandType.Text;
                bodocghi = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                bodocghi.Fill(dt);
                ketnoi.Close();
                dataGridViewDSKH.DataSource = dt;
            }
            if (comboBoxTimLoai.Text == "Số Điện Thoại")
            {
                string sql = "select MaKH, TenKH, SDT, DiaChi, GioiTinh from KhachHang where SDT like '%" + textBoxTim.Text.Trim() + "%' ";
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.CommandType = CommandType.Text;
                bodocghi = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                bodocghi.Fill(dt);
                ketnoi.Close();
                dataGridViewDSKH.DataSource = dt;
            }
            if (comboBoxTimLoai.Text == "Địa Chỉ")
            {
                string sql = "select MaKH, TenKH, SDT, DiaChi, GioiTinh from KhachHang where DiaChi like N'%" + textBoxTim.Text.Trim() + "%' ";
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.CommandType = CommandType.Text;
                bodocghi = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                bodocghi.Fill(dt);
                ketnoi.Close();
                dataGridViewDSKH.DataSource = dt;
            }
        }

        private void buttonDSKH_Click(object sender, EventArgs e)
        {
            DanhSachKhachHangDaMua dskhdm = new DanhSachKhachHangDaMua();
            dskhdm.ShowDialog();
        }
    }
}
