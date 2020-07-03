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
            cbTenKhachHang.DisplayMember = "TENKHACHHANG";
            cbTenKhachHang.ValueMember = "MAKHACHHANG";
        }

        void LoadPhong()
        {
            cbRoom.DataSource = BUS_Phong.Instance.layDanhSachPhongCoNguoi();
            cbRoom.DisplayMember = "PHONG_TENPHONG";
            cbRoom.ValueMember = "PHONG_MAPHONG";
        }


        void hienThiHoaDon(int makh)
        {
            List<DTO_ChiTietHoaDon> listRoom = BUS_ChiTietHoaDon.Instance.layDanhSachChiTietHoaDon(makh);
            lvBill.Items.Clear();
            int totalPrice = 0;
            foreach (DTO_ChiTietHoaDon item in listRoom)
            {
                ListViewItem lvItem = new ListViewItem((item.CHITIETHOADON_MAPHONG).ToString());
                lvItem.SubItems.Add(item.CHITIETHOADON_SONGAY.ToString());
                lvItem.SubItems.Add(item.CHITIETHOADON_DONGIA.ToString());
                lvItem.SubItems.Add(item.CHITIETHOADON_THANHTIEN.ToString());

                totalPrice += item.CHITIETHOADON_THANHTIEN;
                lvBill.Items.Add(lvItem);
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
            makh = selected.maKhachHang;
            hienThiHoaDon(makh);
            tbAddress.Text = BUS_KhachHang.Instance.layDiaChiKhach(makh);
        }




        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            int maPhong = (cbRoom.SelectedItem as DTO_Phong).PHONG_MAPHONG;
            if (BUS_HoaDon.Instance.themHoaDon(makh) == true)
            {
                BUS_ChiTietHoaDon.Instance.ThemChiTietHoaDon(BUS_HoaDon.Instance.GetMaxIDBill(), maPhong);
                MessageBox.Show("Thêm thành công");
                LoadPhong();
            }
            else MessageBox.Show("Thêm không thành công");
        }


        #endregion


    }
}
