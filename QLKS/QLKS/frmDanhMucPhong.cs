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
            if (String.IsNullOrEmpty(tenPhong.Text) || String.IsNullOrEmpty(maLoaiPhong.Text) || String.IsNullOrEmpty(giaPhong.Text) || String.IsNullOrEmpty(ghiChuPhong.Text))
            {
                return false;
            }
            return true;
        }

        public void showLoaiPhong()
        {
            dataGridView1.DataSource = busLoaiPhong.showLoaiPhong();
        }

        private void button3_Click(object sender, EventArgs e) //insert
        {
            if (!validateData())
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
                    DTO_LoaiPhong loaiphong = new DTO_LoaiPhong(maLoaiPhong.Text, tenPhong.Text, Int32.Parse(giaPhong.Text), ghiChuPhong.Text);
                    if (busLoaiPhong.themLoaiPhong(loaiphong))
                    {
                        MessageBox.Show("Thêm loại phòng thành công!");

                    }
                    else
                    {
                        MessageBox.Show("Thêm loại phòng không thành công!");
                    }
                    showLoaiPhong();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tenPhong.Text = dataGridView1.SelectedRows[0].Cells["LOAIPHONG_TENLOAIPHONG"].Value.ToString();
            giaPhong.Text = dataGridView1.SelectedRows[0].Cells["DONGIA"].Value.ToString();
            tenPhong.Text = dataGridView1.SelectedRows[0].Cells["GHICHU"].Value.ToString();
        }

    }
}
