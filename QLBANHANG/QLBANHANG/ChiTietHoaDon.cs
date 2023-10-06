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
    public partial class ChiTietHoaDon : Form
    {

        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;
        DataTable dt1 = new DataTable("DonHangKH");


        void ketnoicsdl()
        {
            chuoikn = global::QLBANHANG.Properties.Settings.Default.QLBanHangConnectionString;
            ketnoi = new SqlConnection(chuoikn);

            string sql = "select MaSP, TenSP, GiaBan from SanPham";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            bodocghi = new SqlDataAdapter();
            bodocghi.SelectCommand = cmd;
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            comboBoxTenSP.DataSource = dt;
            comboBoxTenSP.DisplayMember = "TenSP";
            comboBoxTenSP.ValueMember = "MaSP";
            comboBoxGia.DataSource = dt;
            comboBoxGia.DisplayMember = "GiaBan";
            comboBoxGia.ValueMember = "GiaBan";

            ketnoi.Open();
            string sql1 = "select MaDonHang, MaSP, TenSP, SoLuong, GiaBan from SanPhamKH where MaDonHang = '" + textBoxMaDH.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, ketnoi);
            cmd1.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            bodocghi.Fill(dt1);
            ketnoi.Close();
            dataGridView1.DataSource = dt1;

            textBoxMaHD.Text = ClassKhachHang.MAHD;
            textBoxMaDH.Text = ClassKhachHang.MADONHANG;
            textBoxTen.Text = ClassKhachHang.TENKH;
            textBoxSDT.Text = ClassKhachHang.SDTKH;
            textBoxNV.Text = ClassKhachHang.NHANVIENBAN;
            textBoxNB.Text = ClassKhachHang.NGAYMUA;

            string sqlrs = "select MaDonHang, MaSP, TenSP, SoLuong, GiaBan from SanPhamKH where MaDonHang = '" + textBoxMaDH.Text + "'";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "SanPhamKH");
            dataGridView1.DataSource = ds.Tables[0];
            tinhtongsp();
        }

        public void tinhtongsp()
        {
            int tien = dataGridView1.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < tien - 1; i++)
            {
                thanhtien += float.Parse(dataGridView1.Rows[i].Cells["GiaBan"].Value.ToString()) * float.Parse(dataGridView1.Rows[i].Cells["SoLuong"].Value.ToString());
            }
            labelTT.Text = thanhtien.ToString("#,###");
        }
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            string sqlrs = "select MaDonHang, MaSP, TenSP, SoLuong, GiaBan from SanPhamKH where MaDonHang = '" + textBoxMaDH.Text + "'";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "SanPhamKH");
            dataGridView1.DataSource = ds.Tables[0];
            tinhtongsp();
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
                MessageBox.Show("Đã có Sản Phẩm!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql = ("update SanPhamKH set SoLuong = '" + Convert.ToDecimal(numericUpDownSL.Value) + "' where MaDonHang = '" + int.Parse(textBoxMaDH.Text) + "' and MaSP = '" + int.Parse(comboBoxTenSP.SelectedValue.ToString()) + "'");
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đổi sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
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

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
