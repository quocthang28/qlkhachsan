using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class GUI_Homepage : Form
    {
        public GUI_Homepage()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
        frmDanhMucPhong danhmucphong = new frmDanhMucPhong();
        frmLapHoaDon laphoadon = new frmLapHoaDon();
        frmLapPhieuThue lapphieuthue = new frmLapPhieuThue();
        frmThayDoiPhuThu thaydoiphuthu = new frmThayDoiPhuThu();
        private void GUI_Homepage_Load(object sender, EventArgs e)
        {

            pnlContent.Controls.Add(laphoadon);

            pnlContent.Controls.Add(danhmucphong);

            pnlContent.Controls.Add(lapphieuthue);

            pnlContent.Controls.Add(thaydoiphuthu);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            danhmucphong.BringToFront();
            //danhmucphong.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lapphieuthue.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thaydoiphuthu.BringToFront();
        }
    }
}
