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
                if (dgvChiTietHoaDon.Rows[i].Cells["THANHTIEN"].Value != null)
                {
                    totalPrice += (int)dgvChiTietHoaDon.Rows[i].Cells["THANHTIEN"].Value;
                }
                else totalPrice += 0;
            }
            tbTongTien.Text = totalPrice.ToString();

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
            tbAddress.Text = BUS_KhachHang.Instance.layDiaChiKhach(makh);
        }


        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            int maPhong = (cbRoom.SelectedItem as DTO_Phong).PHONG_MAPHONG;
            if (BUS_HoaDon.Instance.getUnCheckIDBillByIDCustomer(makh) == -1)
            {
                if (BUS_HoaDon.Instance.themHoaDon(makh) == true)
                {
                    BUS_ChiTietHoaDon.Instance.ThemChiTietHoaDon(BUS_HoaDon.Instance.GetMaxIDBill(), maPhong);
                    MessageBox.Show("Thêm thành công");
                    BUS_ChiTietHoaDon.Instance.updateChiTietHoaDon();
                    hienThiHoaDon(makh);
                }
                else MessageBox.Show("Thêm không thành công");
            }
            else
            {
                BUS_ChiTietHoaDon.Instance.ThemChiTietHoaDon(BUS_HoaDon.Instance.getUnCheckIDBillByIDCustomer(makh), maPhong);
                MessageBox.Show("Thêm thành công");
                BUS_ChiTietHoaDon.Instance.updateChiTietHoaDon();
                hienThiHoaDon(makh);
            }


        }


        #endregion


        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietHoaDon.SelectedCells.Count > 0)
            {
                 maChiTietHoaDon = (int)dgvChiTietHoaDon.SelectedCells[0].OwningRow.Cells["MACHITIETHOADON"].Value;
                 maHoaDon=(int)dgvChiTietHoaDon.SelectedCells[0].OwningRow.Cells["MAHOADON"].Value;
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
        }
    }
}
