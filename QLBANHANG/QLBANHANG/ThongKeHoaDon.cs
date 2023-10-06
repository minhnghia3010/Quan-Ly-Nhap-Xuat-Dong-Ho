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
using DGVPrinterHelper;

namespace QLBANHANG
{
    public partial class ThongKeHoaDon : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;

        void ketnoicsdl()
        {
            chuoikn = global::QLBANHANG.Properties.Settings.Default.QLBanHangConnectionString;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select * from HoaDon";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridViewDSHD.DataSource = dt;
        }

        void dt()
        {
            ketnoi.Open();
            string sql = "select TenSP, SoLuong from SanPhamKH where MaDonHang = '" + textBoxMaDH.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridViewCTSP.DataSource = dt;
        }
        public ThongKeHoaDon()
        {
            InitializeComponent();
        }
        public void cbxloaitk()
        {
            List<string> loaitk = new List<string>() { "Tên Khách Hàng", "SĐT"};
            comboBoxTim.DataSource = loaitk;
        }
        private void ThongKeHoaDon_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            cbxloaitk();
        }

        private void dataGridViewDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int luuhd;
            luuhd = e.RowIndex;
            textBoxMaHD.Text = dataGridViewDSHD.Rows[luuhd].Cells[0].Value.ToString();
            textBoxMaDH.Text = dataGridViewDSHD.Rows[luuhd].Cells[1].Value.ToString();
            textBoxHoTen.Text = dataGridViewDSHD.Rows[luuhd].Cells[2].Value.ToString();
            textBoxSDT.Text = dataGridViewDSHD.Rows[luuhd].Cells[3].Value.ToString();
            textBoxNVB.Text = dataGridViewDSHD.Rows[luuhd].Cells[4].Value.ToString();
            textBoxTT.Text = dataGridViewDSHD.Rows[luuhd].Cells[5].Value.ToString();
            textBoxNM.Text = dataGridViewDSHD.Rows[luuhd].Cells[6].Value.ToString();
            dt();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from HoaDon where MaHD = ('{0}')", textBoxMaHD.Text);
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            ketnoi.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlrs = "select * from HoaDon";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "HoaDon");
            dataGridViewDSHD.DataSource = ds.Tables[0];
            textBoxTim.Text = "";
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (comboBoxTim.Text == "Tên Khách Hàng")
            {
                dateTimePicker1.Enabled = false;
                textBoxTim.Enabled = true;
                string sql = "select * from HoaDon where TenKH like N'%" + textBoxTim.Text.Trim() + "%' ";
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.CommandType = CommandType.Text;
                bodocghi = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                bodocghi.Fill(dt);
                ketnoi.Close();
                dataGridViewDSHD.DataSource = dt;
            }
            if (comboBoxTim.Text == "SĐT")
            {
                dateTimePicker1.Enabled = false;
                textBoxTim.Enabled = true;
                string sql = "select * from HoaDon where SDT like '%" + textBoxTim.Text.Trim() + "%' ";
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.CommandType = CommandType.Text;
                bodocghi = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                bodocghi.Fill(dt);
                ketnoi.Close();
                dataGridViewDSHD.DataSource = dt;
            }
            //if (comboBoxTim.Text == "Ngày Mua")
            //{
            //    dateTimePicker1.Enabled = true;
            //    textBoxTim.Enabled = false;
            //    string sql = "select * from HoaDon where NgayBan like '%" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "%' ";
            //    SqlCommand cmd = new SqlCommand(sql, ketnoi);
            //    cmd.CommandType = CommandType.Text;
            //    bodocghi = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    bodocghi.Fill(dt);
            //    ketnoi.Close();
            //    dataGridViewDSHD.DataSource = dt;
            //}
        }

        private void comboBoxTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTim.Text == "Tên Khách Hàng")
            {
                dateTimePicker1.Enabled = false;
                textBoxTim.Enabled = true;
            }
            if (comboBoxTim.Text == "SĐT")
            {
                dateTimePicker1.Enabled = false;
                textBoxTim.Enabled = true;
            }
            //if (comboBoxTim.Text == "Ngày Mua")
            //{
            //    dateTimePicker1.Enabled = true;
            //    textBoxTim.Enabled = false;
            //}
        }

        private void buttonCTHD_Click(object sender, EventArgs e)
        {
            if (textBoxMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ClassKhachHang.MAHD = textBoxMaHD.Text;
                ClassKhachHang.MADONHANG = textBoxMaDH.Text;
                ClassKhachHang.TENKH = textBoxHoTen.Text;
                ClassKhachHang.NHANVIENBAN = textBoxNVB.Text;
                ClassKhachHang.SDTKH = textBoxSDT.Text;
                ClassKhachHang.NGAYMUA = textBoxNM.Text;
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.ShowDialog();
            }
        }

        private void buttonIN_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Danh Sách Hóa Đơn"; //give your report name
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true; // if you need page numbers you can keep this as true other wise false
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "The End"; //this is the footer
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridViewDSHD);
        }
    }
}
