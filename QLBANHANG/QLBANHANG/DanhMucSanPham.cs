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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace QLBANHANG
{
    public partial class DanhMucSanPham : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;
        void ketnoicsdl()
        {
            chuoikn = global::QLBANHANG.Properties.Settings.Default.QLBanHangConnectionString;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select * from SanPham";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridViewNhapSP.DataSource = dt;
        }
        public DanhMucSanPham()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ThemSP tt = new ThemSP();
            tt.ShowDialog();
        }

        private void dataGridViewNhapSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int luusp;
            luusp = e.RowIndex;
            textBoxMaSP.Text = dataGridViewNhapSP.Rows[luusp].Cells[0].Value.ToString();
            textBoxTenSP.Text = dataGridViewNhapSP.Rows[luusp].Cells[1].Value.ToString();
            textBoxSoLuong.Text = dataGridViewNhapSP.Rows[luusp].Cells[2].Value.ToString();
            textBoxMoTa.Text = dataGridViewNhapSP.Rows[luusp].Cells[3].Value.ToString();
            textBoxGiaNhap.Text = dataGridViewNhapSP.Rows[luusp].Cells[4].Value.ToString();
            textBoxGiaBan.Text = dataGridViewNhapSP.Rows[luusp].Cells[5].Value.ToString();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            string sqlrs = "select * from SanPham";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "SanPham");
            dataGridViewNhapSP.DataSource = ds.Tables[0];
        }

        private void DanhMucSanPham_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            comboBox1.Items.Add(filterInfo.Name);
            comboBox1.SelectedIndex = 0;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql = ("update SanPham set TenSP = N'" + textBoxTenSP.Text + "', SoLuong = '" + Convert.ToDecimal(textBoxSoLuong.Text) + "', GiaNhap  = N'" + textBoxGiaNhap.Text + "',GiaBan  = N'" + textBoxGiaBan.Text + "', MoTa = N'" + textBoxMoTa.Text + "' where MaSP = '" + int.Parse(textBoxMaSP.Text) + "'");
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from SanPham where MaSP = ('{0}')", textBoxMaSP.Text);
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            ketnoi.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void textBoxSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            string sql = "select * from SanPham where TenSP like '%" + textBoxTim.Text.Trim() + "%' ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridViewNhapSP.DataSource = dt;
        }

        private void buttonQuet_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
            textBoxQR.Clear();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result !=null)
                {
                    textBoxQR.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }
    }
}
