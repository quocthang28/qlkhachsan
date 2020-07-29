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
        frmDanhMucPhong dmPhong = new frmDanhMucPhong();
        frmPhong phong = new frmPhong();
        frmLapHoaDon laphoadon = new frmLapHoaDon();
        frmLapPhieuThue lapphieuthue = new frmLapPhieuThue();
        //frmThayDoiPhuThu thaydoiphuthu = new frmThayDoiPhuThu();
        frmThayDoiQuiDinh thaydoiquydinh = new frmThayDoiQuiDinh();
        public GUI_Homepage()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void GUI_Homepage_Load(object sender, EventArgs e)
        {

           
            pnlContent.Controls.Add(dmPhong);
            pnlContent.Controls.Add(phong);
            pnlContent.Controls.Add(laphoadon);
            pnlContent.Controls.Add(lapphieuthue);
            pnlContent.Controls.Add(thaydoiquydinh);

            dmPhong.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dmPhong.BringToFront();
            //danhmucphong.Dock = DockStyle.Fill;
        }

        public void button7_Click_1(object sender, EventArgs e)
        {
            
            phong.BringToFront();
            phong.showLoaiPhongList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Refresh();
            lapphieuthue.BringToFront();
            lapphieuthue.loadListLoaiPhong();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thaydoiquydinh.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            laphoadon.BringToFront();
            laphoadon.LoadPhong();
        }

    }
}
