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
    public partial class DanhSachDonHang : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;

        void ketnoicsdl()
        {
            chuoikn = global::QLBANHANG.Properties.Settings.Default.QLBanHangConnectionString;
            ketnoi = new SqlConnection(chuoikn);
        }
        public DanhSachDonHang()
        {
            InitializeComponent();
        }
        void napdsdonhang()
        {
            ketnoi.Open();
            string sql = "select MaDonHang, TenKH, SDT, NhanVienBan, NgayMua from DonHang where ThanhToan = N'" + "Chưa Thanh Toán" + "' ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridView1.DataSource = dt;
        }
        private void DanhSachDonHang_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            napdsdonhang();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ClassKhachHang.MADONHANG = dataGridView1.SelectedRows[0].Cells["MaDonHang"].Value.ToString();
            ClassKhachHang.TENKH = dataGridView1.SelectedRows[0].Cells["TenKH"].Value.ToString();          
            ClassKhachHang.NHANVIENBAN = dataGridView1.SelectedRows[0].Cells["NhanVienBan"].Value.ToString();
            ClassKhachHang.SDTKH = dataGridView1.SelectedRows[0].Cells["SDT"].Value.ToString();
            ClassKhachHang.NGAYMUA = dataGridView1.SelectedRows[0].Cells["NgayMua"].Value.ToString();
            Close();
        }
    }
}
