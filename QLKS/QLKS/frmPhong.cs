using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Hotel;
using BUS_Hotel;
using System.Windows;
using System.Globalization;

namespace QLKS
{
    public partial class frmPhong : UserControl
    {
        BUS_Phong busPhong = new BUS_Phong();
        BUS_LoaiPhong busLoaiPhong = new BUS_LoaiPhong();
        public frmPhong()
        {
            InitializeComponent();
            showLoaiPhongList();
            showPhong();
            showDonGia();
        }

        public bool validateData()
        {
            return (string.IsNullOrEmpty(tenPhong.Text) || string.IsNullOrEmpty(ghiChuPhong.Text));
        }

        public void showLoaiPhongList() //to combobox
        {
            List<DTO_LoaiPhong> loaiPhongList = busLoaiPhong.getLoaiPhongList();
            loaiPhong.DisplayMember = "LOAIPHONG_TENLOAIPHONG";
            loaiPhong.ValueMember = "LOAIPHONG_MALOAIPHONG";
            loaiPhong.DataSource = loaiPhongList;
        }

        public void showDonGia()
        {
            List<DTO_LoaiPhong> lpList = busLoaiPhong.getLoaiPhongList();
            foreach (DTO_LoaiPhong lp in lpList)
            {
                if (loaiPhong.SelectedValue.ToString() == lp.LOAIPHONG_MALOAIPHONG)
                {
                    // donGia.Text = lp.LOAIPHONG_DONGIA.ToString();
                    CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   
                    donGia.Text = double.Parse(lp.LOAIPHONG_DONGIA.ToString()).ToString("#,###", cul.NumberFormat);
                }
            }
        }

        public void showPhong()
        {
            flpPhong.Controls.Clear();
            List<DTO_Phong> phongList = busPhong.getPhongList(loaiPhong.Text);
            string tinhTrang;
            foreach (DTO_Phong phong in phongList)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Margin = new Padding(20, 0, 0, 20);
                btn.Tag = phong;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 3;
                if (phong.PHONG_TINHTRANG == 1)
                {
                    tinhTrang = "Có người";
                    btn.FlatAppearance.BorderColor = Color.Red;
                }
                else
                {
                    tinhTrang = "Còn trống";
                    btn.FlatAppearance.BorderColor = Color.Green;
                }
                btn.Text = phong.PHONG_TENPHONG + "\n" + tinhTrang;
                flpPhong.Controls.Add(btn);
                btn.Click += (sender, EventArgs) => { Btn_Click(sender, EventArgs, phong.PHONG_TENPHONG, phong.PHONG_GHICHU); };
            }
            if (phongList.Any())
            {
                var firstPhong = phongList.First();
                tenPhong.Text = firstPhong.PHONG_TENPHONG;
                ghiChuPhong.Text = firstPhong.PHONG_GHICHU;
            }
            else
            {
                tenPhong.Text = ghiChuPhong.Text = "";
            }

        }

        private void Btn_Click(object sender, EventArgs e, string tenp, string gc) // phong btn click
        {
            tenPhong.Text = tenp;
            ghiChuPhong.Text = gc;
        }

        public bool checkTrungTenPhong(string tenphong)
        {
            return busPhong.checkTrungTenPhong(tenphong);
        }


        private void loaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPhong();
            showDonGia();
        }

        private void button1_Click(object sender, EventArgs e) // add
        {
            if (validateData())
            {
                System.Windows.Forms.MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                if (!busPhong.checkTrungTenPhong(tenPhong.Text))
                {
                    System.Windows.Forms.MessageBox.Show("Tên phòng không được trùng!");
                }
                else
                {
                    DTO_Phong phong = new DTO_Phong(loaiPhong.SelectedValue.ToString(), tenPhong.Text, ghiChuPhong.Text, 0);
                    if (busPhong.addPhong(phong))
                    {
                        showPhong();
                        System.Windows.Forms.MessageBox.Show("Thêm phòng thành công");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Thêm phòng thất bại");
                    }
                }
            }
        }

        // check duplicate
    }
}
