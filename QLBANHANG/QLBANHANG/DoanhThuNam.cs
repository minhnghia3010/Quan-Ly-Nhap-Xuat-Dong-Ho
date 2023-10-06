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
    public partial class DoanhThuNam : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;
        void ketnoicsdl()
        {
            chuoikn = global::QLBANHANG.Properties.Settings.Default.QLBanHangConnectionString;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select Sum(TongTien) as TT, Month(NgayBan) as Month from HOADON where YEAR(NgayBan) = YEAR(GETDATE()) group by month(NgayBan)";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            chart1.DataSource = bodocghi;
            chart1.Series["DoanhThu"].XValueMember = "Month";
            chart1.Series["DoanhThu"].YValueMembers = "TT";
            ketnoi.Close();
            
        }
        public DoanhThuNam()
        {
            InitializeComponent();
        }

        private void DoanhThuNam_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
    }
}
