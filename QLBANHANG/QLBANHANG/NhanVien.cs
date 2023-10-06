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
using Excel = Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QLBANHANG
{
    public partial class NhanVien : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;
        void ketnoicsdl()
        {
            chuoikn = global::QLBANHANG.Properties.Settings.Default.QLBanHangConnectionString;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select * from NhanVien ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridViewNhanVien.DataSource = dt;
        }
        public NhanVien()
        {
            InitializeComponent();
        }
        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            ThemNV tnv = new ThemNV();
            tnv.ShowDialog();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int luunv;
            luunv = e.RowIndex;
            textBoxMaNV.Text = dataGridViewNhanVien.Rows[luunv].Cells[0].Value.ToString();
            textBoxTenNV.Text = dataGridViewNhanVien.Rows[luunv].Cells[1].Value.ToString();
            textBoxSDT.Text = dataGridViewNhanVien.Rows[luunv].Cells[2].Value.ToString();
            textBoxDiaChi.Text = dataGridViewNhanVien.Rows[luunv].Cells[3].Value.ToString();
            textBoxLuong.Text = dataGridViewNhanVien.Rows[luunv].Cells[4].Value.ToString();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql = ("update NhanVien set TenNV = N'" + textBoxTenNV.Text + "', SDT = '" + textBoxSDT.Text + "', DiaChi  = N'" + textBoxDiaChi.Text + "', Luong = '" + textBoxLuong.Text + "' where MaNV = '" + int.Parse(textBoxMaNV.Text) + "'");
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from NhanVien where MaNV = ('{0}')", textBoxMaNV.Text);
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            ketnoi.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            string sqlrs = "select * from NhanVien";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "NhanVien");
            dataGridViewNhanVien.DataSource = ds.Tables[0];
        }

        private void textBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonXuatFileExcel_Click(object sender, EventArgs e)
        {
            export2Excel(dataGridViewNhanVien, @"D:\", "XuatfileExcel - Nhân Viên");
            MessageBox.Show("Xuất File Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
