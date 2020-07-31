﻿using System;
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
        frmBaoCao baocao = new frmBaoCao();
        frmTrangChu trangchu = new frmTrangChu();
        public GUI_Homepage()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            if(Session.isAdmin == true)
            {
                lblChucVu.Text = "Quản lí";
            }
            else if (Session.isAdmin == false)
            {
                lblChucVu.Text = "Nhân viên";
            }
            lblTen.Text = Session.tk;
        }

        private void GUI_Homepage_Load(object sender, EventArgs e)
        {

           
            pnlContent.Controls.Add(dmPhong);
            pnlContent.Controls.Add(phong);
            pnlContent.Controls.Add(laphoadon);
            pnlContent.Controls.Add(lapphieuthue);
            pnlContent.Controls.Add(thaydoiquydinh);
            pnlContent.Controls.Add(baocao);
            pnlContent.Controls.Add(trangchu);
            trangchu.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dmPhong.BringToFront();
            
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
            laphoadon.loadCustomerName();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baocao.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trangchu.BringToFront();
        }
    }
}
