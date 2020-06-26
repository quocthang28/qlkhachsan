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

namespace QLKS
{
    public partial class frmDanhMucPhong : UserControl
    {
        BUS_LoaiPhong busLoaiPhong = new BUS_LoaiPhong();
        public frmDanhMucPhong()
        {
            InitializeComponent();
            showLoaiPhong();
        }

        bool validateData()
        {
            return (String.IsNullOrEmpty(tenLoaiPhong.Text) || String.IsNullOrEmpty(maLoaiPhong.Text) || String.IsNullOrEmpty(giaLoaiPhong.Text) || String.IsNullOrEmpty(ghiChuLoaiPhong.Text));
        }

        public void showLoaiPhong()
        {
            dataGridView1.DataSource = busLoaiPhong.showLoaiPhong();
            dataGridView1.Columns["LOAIPHONG_MALOAIPHONG"].HeaderText = "Mã loại phòng";
            dataGridView1.Columns["LOAIPHONG_TENLOAIPHONG"].HeaderText = "Tên loại phòng";
            dataGridView1.Columns["LOAIPHONG_DONGIA"].HeaderText = "Đơn giá";
            dataGridView1.Columns["LOAIPHONG_GHICHU"].HeaderText = "Ghi chú";
        }

        private void button3_Click(object sender, EventArgs e) //insert
        {
            if (validateData())
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (!busLoaiPhong.checkMaLoaiPhong(maLoaiPhong.Text))
                {
                    MessageBox.Show("Mã loại phòng đã tồn tại!");
                }
                else
                {
                    DTO_LoaiPhong loaiphong = new DTO_LoaiPhong(maLoaiPhong.Text, tenLoaiPhong.Text, Int32.Parse(giaLoaiPhong.Text), ghiChuLoaiPhong.Text);
                    if (busLoaiPhong.themLoaiPhong(loaiphong))
                    {
                        MessageBox.Show("Thêm loại phòng thành công!");
                        maLoaiPhong.Text = giaLoaiPhong.Text = ghiChuLoaiPhong.Text = tenLoaiPhong.Text = giaLoaiPhong.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại phòng thất bại!");
                    }
                    showLoaiPhong();
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {

            if (validateData())
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (busLoaiPhong.suaLoaiPhong(tenLoaiPhong.Text, Int32.Parse(giaLoaiPhong.Text), ghiChuLoaiPhong.Text, maLoaiPhong.Text))
                {
                    MessageBox.Show("Sửa loại phòng thành công!");

                }
                else
                {
                    MessageBox.Show("Sửa loại phòng thất bại!");
                }
                showLoaiPhong();
            }
        }
       
    }
}
