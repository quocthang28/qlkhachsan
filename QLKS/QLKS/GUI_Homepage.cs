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

            // pnlContent.Controls.Add(laphoadon);
            pnlContent.Controls.Add(dmPhong);
            pnlContent.Controls.Add(phong);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dmPhong.BringToFront();
            //danhmucphong.Dock = DockStyle.Fill;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            phong.BringToFront();
            phong.showLoaiPhongList();
        }
    }
}
