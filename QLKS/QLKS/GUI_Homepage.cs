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
        frmLapHoaDon phieuHoaDon = new frmLapHoaDon();
        frmLapPhieuThue phieuthue = new frmLapPhieuThue();
        public GUI_Homepage()
        {
            InitializeComponent();
        }
        Button lastBtnClicked = new Button();
        private void button7_Click(object sender, EventArgs e)
        {
            
        }
        //frmDanhMucPhong danhmucphong = new frmDanhMucPhong();
        //frmLapHoaDon laphoadon = new frmLapHoaDon();
        private void GUI_Homepage_Load(object sender, EventArgs e)
        {
            lastBtnClicked = btnHome;
            // pnlContent.Controls.Add(laphoadon);
            pnlContent.Controls.Add(phieuthue);
            pnlContent.Controls.Add(phieuHoaDon);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //danhmucphong.Dock = DockStyle.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            phieuHoaDon.BringToFront();
            button5.ForeColor = Color.FromArgb(248, 183, 57);
            button5.BackColor = Color.FromArgb(130, 144, 155);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            phieuthue.BringToFront();
        }

 
    }
}
