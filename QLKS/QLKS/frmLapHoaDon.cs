using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Hotel;
using DTO_Hotel;


namespace QLKS
{
    public partial class frmLapHoaDon : UserControl
    {
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        int makh = 0;
        int maHoaDon = 0;
        int maChiTietHoaDon = 0;

        public frmLapHoaDon()
        {
            InitializeComponent();
            loadCustomerName();
            LoadPhong();
            hienThiHoaDon(makh);
            loadThongTinKhachHang(makh);
        }
        #region rac
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region METHODS


        void loadCustomerName()
        {
            cbTenKhachHang.DataSource = busKhachHang.layDanhSachTenKhach();
            cbTenKhachHang.DisplayMember = "KHACHHANG_TENKHACHHANG";
            cbTenKhachHang.ValueMember = "KHACHHANG_MAKHACHHANG";
        }

        void LoadPhong()
        {
            cbRoom.DataSource = BUS_Phong.Instance.layDanhSachPhongCoNguoi();
            cbRoom.DisplayMember = "PHONG_TENPHONG";
            cbRoom.ValueMember = "PHONG_MAPHONG";
        }


        void hienThiHoaDon(int makh)
        {
            DataTable data = BUS_ChiTietHoaDon.Instance.layDanhSachChiTietHoaDon(makh);

            int totalPrice = 0;
       
            dgvChiTietHoaDon.DataSource = data;

            for (int i = 0; i < dgvChiTietHoaDon.RowCount;i++)
            {
                if (dgvChiTietHoaDon.Rows[i].Cells["THÀNH TIỀN"].Value != null)
                {
                    totalPrice += (int)dgvChiTietHoaDon.Rows[i].Cells["THÀNH TIỀN"].Value;
                }
                else totalPrice += 0;
            }
            tbTongTien.Text = totalPrice.ToString();

        }

        void loadThongTinKhachHang(int makh)
        {
            DataTable data = BUS_KhachHang.Instance.layThongTinKhach(makh);

            tbDiaChi.Text = data.Rows[0]["DIACHI"].ToString();
            tbCMND.Text = data.Rows[0]["CMND"].ToString();
            tbSDT.Text = data.Rows[0]["SODIENTHOAI"].ToString();
        }


        #endregion

        #region EVENTS
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            DTO_KhachHang selected = cb.SelectedItem as DTO_KhachHang;
            makh = selected.KHACHHANG_MAKHACHHANG;
            hienThiHoaDon(makh);
            loadThongTinKhachHang(makh);
        }


        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            int maPhong = (cbRoom.SelectedItem as DTO_Phong).PHONG_MAPHONG;
            if (BUS_HoaDon.Instance.getUnCheckIDBillByIDCustomer(makh) == -1)
            {
                if (BUS_HoaDon.Instance.themHoaDon(makh) ==true )
                {
                    if (BUS_ChiTietHoaDon.Instance.ThemChiTietHoaDon(BUS_HoaDon.Instance.GetMaxIDBill(), maPhong) ==true)
                    {
                        MessageBox.Show("Thêm thành công");
                        BUS_ChiTietHoaDon.Instance.updateChiTietHoaDon(maPhong);
                    }
                    else MessageBox.Show("Phòng đã được chọn thanh toán bởi khách hàng khác");
                    hienThiHoaDon(makh);
                }
                else MessageBox.Show("Thêm không thành công");
            }
            else
            {
                if (BUS_ChiTietHoaDon.Instance.ThemChiTietHoaDon(BUS_HoaDon.Instance.getUnCheckIDBillByIDCustomer(makh), maPhong) ==true)
                {
                    MessageBox.Show("Thêm thành công");
                    BUS_ChiTietHoaDon.Instance.updateChiTietHoaDon(maPhong);
                }
                else MessageBox.Show("Thêm không thành công");
                hienThiHoaDon(makh);
            }


        }


        #endregion


        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietHoaDon.SelectedCells.Count > 0)
            {
                 maChiTietHoaDon = (int)dgvChiTietHoaDon.SelectedCells[0].OwningRow.Cells["MÃ CHI TIẾT HÓA ĐƠN"].Value;
                 maHoaDon=(int)dgvChiTietHoaDon.SelectedCells[0].OwningRow.Cells["MÃ HÓA ĐƠN"].Value;
            }
        }

        private void btnDelRoom_Click(object sender, EventArgs e)
        {
            if(BUS_ChiTietHoaDon.Instance.XoaChiTietHoaDon(maChiTietHoaDon,maHoaDon) == true )
            {
                MessageBox.Show("Xoa thanh cong");
                hienThiHoaDon(makh);
            }
            else
            {
                MessageBox.Show("Xoa khong thanh cong");
            }
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (BUS_HoaDon.Instance.thanhToanHoaDon(BUS_HoaDon.Instance.getUnCheckIDBillByIDCustomer(makh), Convert.ToInt32(this.tbTongTien.Text)))
            {
                MessageBox.Show("Thanh toan thanh cong");
                hienThiHoaDon(makh);
            }
            else MessageBox.Show("Thanh toan khong thanh cong");

            LoadPhong();
        }


        int maPhong = 0;
        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            DTO_Phong selected = cb.SelectedItem as DTO_Phong;
            maPhong = selected.PHONG_MAPHONG;
        }
    }
}
