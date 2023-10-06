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
    public partial class DonHang : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;
        DataTable dt2 = new DataTable("DonHangKH");
        void ketnoicsdl()
        {
            chuoikn = global::QLBANHANG.Properties.Settings.Default.QLBanHangConnectionString;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select MaDSKH, MaKH, TenKH, SDT, NhanVienBan from DanhSachKhachHang where TinhTrang = N'" + "Chưa Mua" + "'";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridView.DataSource = dt;
        }
        void ketnoicsdl1()
        {
            chuoikn = global::QLBANHANG.Properties.Settings.Default.QLBanHangConnectionString;
            ketnoi = new SqlConnection(chuoikn);

            string sql1 = "select MaSP, TenSP, GiaBan from SanPham";
            SqlCommand cmd1 = new SqlCommand(sql1, ketnoi);
            bodocghi = new SqlDataAdapter();
            bodocghi.SelectCommand = cmd1;
            DataTable dt1 = new DataTable();
            bodocghi.Fill(dt1);
            comboBoxTenSP.DataSource = dt1;
            comboBoxTenSP.DisplayMember = "TenSP";
            comboBoxTenSP.ValueMember = "MaSP";
            comboBoxGia.DataSource = dt1;
            comboBoxGia.DisplayMember = "GiaBan";
            comboBoxGia.ValueMember = "GiaBan";



            ketnoi.Open();
            string sql2 = "select MaDonHang, MaSP, TenSP, SoLuong, GiaBan from SanPhamKH where MaDonHang = '" + textBoxMaDH.Text + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, ketnoi);
            cmd2.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            bodocghi.Fill(dt2);
            ketnoi.Close();
            dataGridViewDH.DataSource = dt2;
        }
        public DonHang()
        {
            InitializeComponent();
        }
        public void tinhtongsp()
        {
            int tien = dataGridViewDH.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < tien - 1; i++)
            {
                thanhtien += float.Parse(dataGridViewDH.Rows[i].Cells["GiaBan"].Value.ToString()) * float.Parse(dataGridViewDH.Rows[i].Cells["SoLuong"].Value.ToString());
            }
            labelTT.Text = thanhtien.ToString("#,###");
        }

        private void DonHang_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            ketnoicsdl1();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int luukb;
                luukb = e.RowIndex;
                textBoxMaKHC.Text = dataGridView.Rows[luukb].Cells[0].Value.ToString();
                textBoxMaKH.Text = dataGridView.Rows[luukb].Cells[1].Value.ToString();
                textBoxHoTen.Text = dataGridView.Rows[luukb].Cells[2].Value.ToString();
                textBoxSDT.Text = dataGridView.Rows[luukb].Cells[3].Value.ToString();
                textBoxNhanVienBan.Text = dataGridView.Rows[luukb].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("delete from DanhSachKhachHang where MaDSKH = '" + textBoxMaKHC.Text + "' and TinhTrang = N'" + "Chưa Mua" + "'");
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

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql1 = ("update DanhSachKhachHang set  TinhTrang = N'" + "Đã Thêm Vào Đơn Hàng" + "' where MaDSKH = '" + textBoxMaKHC.Text + "'");
            SqlCommand cmd1 = new SqlCommand(sql1, ketnoi);
            string sql = string.Format("insert into DonHang VALUES (N'{0}', '{1}', N'{2}', '{3}', '{4}', N'{5}')", textBoxHoTen.Text, textBoxSDT.Text, textBoxNhanVienBan.Text, textBoxMaKHC.Text, dateTimePickerThem.Value.ToString("MM/dd/yyyy"),"Chưa Thanh Toán");
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Thêm Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            string sqlrs = "select MaDSKH, MaKH, TenKH, SDT, NhanVienBan from DanhSachKhachHang where TinhTrang = N'" + "Chưa Mua" + "'";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "DanhSachKhachHang");
            dataGridView.DataSource = ds.Tables[0];
        }

        private void buttonChonKH_Click(object sender, EventArgs e)
        {
            DanhSachDonHang dsdh = new DanhSachDonHang();
            dsdh.ShowDialog();
            textBoxMaDH.Text = ClassKhachHang.MADONHANG;
            textBoxHoTenDH.Text = ClassKhachHang.TENKH;
            textBoxSDTDH.Text = ClassKhachHang.SDTKH;
            textBoxNVB.Text = ClassKhachHang.NHANVIENBAN;
            textBoxNgayMuaDH.Text = ClassKhachHang.NGAYMUA;
        }

        private void buttonThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.Open();
                string sql = string.Format("insert into SanPhamKH(MaDonHang, MaSP, TenSP, SoLuong, GiaBan) VALUES ('{0}','{1}',N'{2}','{3}', '{4}')", int.Parse(textBoxMaDH.Text), int.Parse(comboBoxTenSP.SelectedValue.ToString()), comboBoxTenSP.Text, numericUpDownSL.Value, Convert.ToDecimal(comboBoxGia.SelectedValue));
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                string sql1 = "update SanPham set SoLuong = SoLuong - '" + Convert.ToDecimal(numericUpDownSL.Value) + "' where MaSP = '" + int.Parse(comboBoxTenSP.SelectedValue.ToString()) + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, ketnoi);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Thêm Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ketnoi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.Open();
                string sql = string.Format("delete from SanPhamKH where MaDonHang = '" + int.Parse(textBoxMaDH.Text) + "' and MaSP = '" + int.Parse(comboBoxTenSP.SelectedValue.ToString()) + "'");
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ketnoi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLamMoiSP_Click(object sender, EventArgs e)
        {
            string sqlrs = "select MaDonHang, MaSP, TenSP, SoLuong, GiaBan from SanPhamKH where MaDonHang = '" + textBoxMaDH.Text + "'";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "SanPhamKH");
            dataGridViewDH.DataSource = ds.Tables[0];
            tinhtongsp();
        }

        private void buttonCNSP_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql = ("update SanPhamKH set SoLuong = '" + Convert.ToDecimal(numericUpDownSL.Value) + "' where MaDonHang = '" + int.Parse(textBoxMaDH.Text) + "' and MaSP = '" + int.Parse(comboBoxTenSP.SelectedValue.ToString()) + "'");
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql1 = string.Format("insert into ThongTinKHDaMua VALUES ('{0}', N'{1}', '{2}')", int.Parse(textBoxMaDH.Text), textBoxHoTenDH.Text, textBoxSDTDH.Text);
            SqlCommand cmd1 = new SqlCommand(sql1, ketnoi);
            string sql = string.Format("insert into HoaDon VALUES ('{0}', N'{1}', '{2}', N'{3}', '{4}', '{5}')", int.Parse(textBoxMaDH.Text), textBoxHoTenDH.Text, textBoxSDTDH.Text, textBoxNVB.Text, Convert.ToDecimal(labelTT.Text), textBoxNgayMuaDH.Text);
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            string sql2 = ("update DonHang set ThanhToan = N'" + "Đã thanh toán" + "' where MaDonHang = '" + textBoxMaDH.Text + "'");
            SqlCommand cmd2 = new SqlCommand(sql2, ketnoi);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Thanh Toán Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
            InHoaDon inhd = new InHoaDon();
            inhd.ShowDialog();
        }
    }
}
