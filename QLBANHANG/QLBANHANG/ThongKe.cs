using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBANHANG
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void buttonTKHoaDon_Click(object sender, EventArgs e)
        {
            ThongKeHoaDon tkhd = new ThongKeHoaDon();
            tkhd.ShowDialog();
        }

        private void buttonThongKeNgay_Click(object sender, EventArgs e)
        {
            ThongKeNgay tkn = new ThongKeNgay();
            tkn.ShowDialog();
        }

        private void buttonThongKeDTNam_Click(object sender, EventArgs e)
        {
            DoanhThuNam dtn = new DoanhThuNam();
            dtn.ShowDialog();
        }
    }
}
