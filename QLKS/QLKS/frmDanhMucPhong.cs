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

        void clearTextBox()
        {
            maLoaiPhong.Text = giaLoaiPhong.Text = ghiChuLoaiPhong.Text = tenLoaiPhong.Text = giaLoaiPhong.Text = "";
        }

        bool validateData()
        {
            return (String.IsNullOrEmpty(tenLoaiPhong.Text) || String.IsNullOrEmpty(maLoaiPhong.Text) || String.IsNullOrEmpty(giaLoaiPhong.Text) || String.IsNullOrEmpty(ghiChuLoaiPhong.Text));
        }

        public void showLoaiPhong()
        {
            dgvLoaiPhong.DataSource = busLoaiPhong.getLoaiPhongList();
            dgvLoaiPhong.Columns["LOAIPHONG_MALOAIPHONG"].HeaderText = "Mã loại phòng";
            dgvLoaiPhong.Columns["LOAIPHONG_TENLOAIPHONG"].HeaderText = "Tên loại phòng";
            dgvLoaiPhong.Columns["LOAIPHONG_DONGIA"].HeaderText = "Đơn giá";
            dgvLoaiPhong.Columns["LOAIPHONG_GHICHU"].HeaderText = "Ghi chú";
            try
            {
                if (dgvLoaiPhong != null)
                {
                    maLoaiPhong.Text = dgvLoaiPhong.Rows[0].Cells[0].Value.ToString();
                    tenLoaiPhong.Text = dgvLoaiPhong.Rows[0].Cells[1].Value.ToString();
                    giaLoaiPhong.Text = dgvLoaiPhong.Rows[0].Cells[2].Value.ToString();
                    ghiChuLoaiPhong.Text = dgvLoaiPhong.Rows[0].Cells[3].Value.ToString();
                }
            }
            catch (Exception) { }
        }

        private void button3_Click(object sender, EventArgs e) //insert
        {
            if (Session.isAdmin == true)
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
                            showLoaiPhong();
                            MessageBox.Show("Thêm loại phòng thành công!");
                            clearTextBox();
                        }
                        else
                        {
                            MessageBox.Show("Thêm loại phòng thất bại!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tài khoản này không được phép chỉnh sửa!");
            }
        }
        private void button5_Click(object sender, EventArgs e) //edit
        {

            if (validateData())
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (busLoaiPhong.suaLoaiPhong(tenLoaiPhong.Text, Int32.Parse(giaLoaiPhong.Text), ghiChuLoaiPhong.Text, maLoaiPhong.Text))
                {
                    showLoaiPhong();
                    MessageBox.Show("Sửa loại phòng thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa loại phòng thất bại!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) //delete
        {
            if (validateData())
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else if (busLoaiPhong.checkMaLoaiPhong(maLoaiPhong.Text))
            {
                MessageBox.Show("Mã loại phòng không tồn tại");
            }
            else if (busLoaiPhong.checkPhongByMALOAIPHONG(maLoaiPhong.Text))
            {
                if (busLoaiPhong.xoaLoaiPhong(maLoaiPhong.Text))
                {
                    showLoaiPhong();
                    MessageBox.Show("Xóa loại phòng thành công!");
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("Xóa loại phòng thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Xóa thất bại vì còn phòng thuộc loại phòng này");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tenLoaiPhong.Text = dgvLoaiPhong.Rows[e.RowIndex].Cells["LOAIPHONG_TENLOAIPHONG"].Value.ToString();
                maLoaiPhong.Text = dgvLoaiPhong.Rows[e.RowIndex].Cells["LOAIPHONG_MALOAIPHONG"].Value.ToString();
                giaLoaiPhong.Text = dgvLoaiPhong.Rows[e.RowIndex].Cells["LOAIPHONG_DONGIA"].Value.ToString();
                ghiChuLoaiPhong.Text = dgvLoaiPhong.Rows[e.RowIndex].Cells["LOAIPHONG_GHICHU"].Value.ToString();
            }
            catch (Exception) { }
        }
    }
}
