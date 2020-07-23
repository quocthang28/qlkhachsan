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
using System.Data.SqlClient;
namespace QLKS
{
    public partial class frmPhong : UserControl
    {
        private string ghiChu; //ghi chu phong
        BUS_Phong busPhong = new BUS_Phong();
        BUS_LoaiPhong busLoaiPhong = new BUS_LoaiPhong();
        public frmPhong()
        {
            InitializeComponent();
            showLoaiPhongList();
            showPhong(false);
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

        private void showChiTietPhong(string idPhong)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLKS;Integrated Security=True"))
            {
                try
                {
                    string query = String.Format("SELECT KH.TENKHACHHANG as 'Tên khách hàng', LKH.TENLOAIKHACHHANG as 'Loại khách hàng', KH.CMND as 'Số CMND', KH.DIACHI as 'Địa chỉ', PT.NGAYLAPPHIEU as 'Ngày lập phiếu' FROM KHACHHANG AS KH JOIN LOAIKHACHHANG LKH ON KH.MALOAIKHACHHANG = LKH.MALOAIKHACHHANG JOIN CHITIETPHIEUTHUEPHONG CT ON CT.MAKHACHHANG = KH.MAKHACHHANG JOIN PHIEUTHUEPHONG PT ON PT.MAPHIEUTHUE = CT.MAPHIEUTHUE WHERE MAPHONG = N'{0}'", idPhong);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dAdapter.Fill(ds);
                    dgvChiTietPhong.ReadOnly = true;
                    dgvChiTietPhong.DataSource = ds.Tables[0];
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Exception: " + e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void showPhong(bool buttonClicked)
        {
            flpPhong.Controls.Clear();
            flpPhong.HorizontalScroll.Maximum = 0;
            flpPhong.AutoScroll = false;
            flpPhong.VerticalScroll.Visible = false;
            flpPhong.AutoScroll = true;
            List<DTO_Phong> phongList = busPhong.getPhongList(loaiPhong.Text);
            string tinhTrang;
            foreach (DTO_Phong phong in phongList)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Margin = new Padding(20, 5, 0, 20);
                btn.Tag = phong;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 5;
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
                btn.Click += (sender, EventArgs) => { Btn_Click(sender, EventArgs, phong.PHONG_ID, phong.PHONG_TENPHONG, phong.PHONG_GHICHU); };
            }

            if (phongList.Any() && buttonClicked == false)
            {
                DTO_Phong firstPhong = phongList.First();
                tenPhong.Text = firstPhong.PHONG_TENPHONG;
                ghiChu = firstPhong.PHONG_GHICHU;
                ghiChuPhong.Text = firstPhong.PHONG_GHICHU;
                maPhong.Text = firstPhong.PHONG_ID.ToString();
            }
            else
            {
                tenPhong.Text = ghiChuPhong.Text = maPhong.Text = "";
            }

        }

        private void Btn_Click(object sender, EventArgs e, int id, string tenp, string gc) // Phong btn click
        {
            tenPhong.Text = tenp;
            ghiChuPhong.Text = gc;
            maPhong.Text = id.ToString();
            ghiChu = gc;
            lblTenPhong.Text = tenp;
            showChiTietPhong(id.ToString());
        }

        private void loaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPhong(false);
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
                        showPhong(true);
                        System.Windows.Forms.MessageBox.Show("Thêm phòng thành công");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Thêm phòng thất bại");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                System.Windows.Forms.MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                if (!busPhong.checkTrungTenPhong(tenPhong.Text) && (ghiChuPhong.Text == ghiChu))
                {
                    System.Windows.Forms.MessageBox.Show("Tên phòng đã tồn tại!");
                }
                else
                {
                    DTO_Phong phong = new DTO_Phong(loaiPhong.SelectedValue.ToString(), tenPhong.Text, ghiChuPhong.Text, 0);
                    if (busPhong.suaPhong(phong, maPhong.Text))
                    {
                        showPhong(true);
                        System.Windows.Forms.MessageBox.Show("Sửa phòng thành công");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Sửa phòng thất bại");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                System.Windows.Forms.MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                if (busPhong.checkTinhTrangPhong(maPhong.Text))
                {
                    System.Windows.Forms.MessageBox.Show("Phòng đang có người!");
                }
                else
                {
                    DTO_Phong phong = new DTO_Phong(loaiPhong.SelectedValue.ToString(), tenPhong.Text, ghiChuPhong.Text, 0);
                    if (busPhong.xoaPhong(phong, maPhong.Text))
                    {
                        showPhong(true);
                        System.Windows.Forms.MessageBox.Show("Xóa phòng thành công");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Xóa phòng thất bại");
                    }
                }
            }

            //check hoa don
        }

    }
}
