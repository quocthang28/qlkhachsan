using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Hotel;
using BUS_Hotel;

namespace QLKS
{
    public partial class frmLapPhieuThue : UserControl
    {
        
        BUS_LapPhieuThue busHotel = new BUS_LapPhieuThue();
        BUS_KhachHang busKh = new BUS_KhachHang();
        BUS_ChiTietPhieuThue busctpt = new BUS_ChiTietPhieuThue();
        BUS_Phong busPhong = new BUS_Phong();

        

        public frmLapPhieuThue()
        {
            InitializeComponent();
            
        }

        private void frmLapPhieuThue_Load(object sender, EventArgs e)
        {
            dgvPT.DataSource = busHotel.getPhieuthue();

            cbLP.DataSource = BUS_LoaiPhong.Instance.LoadDanhSachLoaiPhong();
            cbLP.DisplayMember = "LOAIPHONG_TENLOAIPHONG";
            cbLP.ValueMember = "LOAIPHONG_MALOAIPHONG";

            cbK.DataSource = BUS_LoaiKhachHang.Instance.loadDanhSachLoaiKhachHang();
            cbK.DisplayMember = "LOAIKHACHHANG_TENLOAIKHACHHANG";
            cbK.ValueMember = "LOAIKHACHHANG_MALOAIKHACHHANG";

            

        }

        //Load phòng theo loại phòng vừa chọn
        private void cbLP_SelectedIndexChanged(object sender, EventArgs e)
        {

            string id;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            DTO_LoaiPhong selected = cb.SelectedItem as DTO_LoaiPhong;
            id = selected.LOAIPHONG_MALOAIPHONG;

            cbP.DataSource = BUS_Phong.Instance.loadDanhSachPhongTheoLoaiPhong(id);
            cbP.DisplayMember = "PHONG_TENPHONG";
            cbP.ValueMember = "PHONG_MAPHONG";

        }

        public int t = 0;
        public int d = 0;
        public int m = 0;
        public int mp = 0;
        //Load dữ liệu khi bấm vào Datagridview
        private void dgvPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            cbLP.Text = dgvPT.Rows[index].Cells[6].Value.ToString();
            cbP.Text = dgvPT.Rows[index].Cells[7].Value.ToString();
            dtNgayLap.Text = dgvPT.Rows[index].Cells[8].Value.ToString();
            txtName.Text = dgvPT.Rows[index].Cells[0].Value.ToString();
            txtPhoneNumber.Text = dgvPT.Rows[index].Cells[4].Value.ToString();
            txtDiachi.Text = dgvPT.Rows[index].Cells[5].Value.ToString();
            txtCMND.Text = dgvPT.Rows[index].Cells[3].Value.ToString();
            dtNgaySinh.Text = dgvPT.Rows[index].Cells[2].Value.ToString();
            cbK.Text = dgvPT.Rows[index].Cells[1].Value.ToString();
            string id = busHotel.loadMaPhieuThue(dtNgayLap.Text, Convert.ToInt32(cbP.SelectedValue.ToString()));
            t = Convert.ToInt32(id);
            string id1 = busKh.loadMaKhachHang(txtCMND.Text);
            d = Convert.ToInt32(id1);
            string id2 = busctpt.loadMaChiTietPhieuThue(t, d);
            m = Convert.ToInt32(id2);
            string id3 = busHotel.loadMaPhong(t);
            mp = Convert.ToInt32(id3);
        }

        //Lưu phiếu thuê phòng, khách hàng, chi tiết phiếu thuê phòng
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtCMND.Text != "" && txtDiachi.Text != "" && txtPhoneNumber.Text != "")
            {
                DTO_PhieuThuePhong lpt = new DTO_PhieuThuePhong(0, dtNgayLap.Text, cbP.SelectedValue.ToString());
                DTO_KhachHang tkh = new DTO_KhachHang(0, Convert.ToInt32(cbK.SelectedValue.ToString()), txtName.Text, txtCMND.Text, txtDiachi.Text, txtPhoneNumber.Text, dtNgaySinh.Text);
                if (busHotel.lapPhieuThue(lpt) && busKh.themKhachHang(tkh))
                {

                    DTO_ChiTietPhieuThuePhong ctpt = new DTO_ChiTietPhieuThuePhong(Convert.ToInt32(busHotel.loadMaPhieuThue(dtNgayLap.Text, Convert.ToInt32(cbP.SelectedValue.ToString()))), Convert.ToInt32(busKh.loadMaKhachHang(txtCMND.Text)));
                    if (busctpt.lapctphieuthue(ctpt))
                    {
                        dgvPT.DataSource = busHotel.getPhieuthue();
                        txtName.Text = "Họ tên";
                        txtPhoneNumber.Text = "Số điện thoại";
                        txtCMND.Text = "CMND";
                        txtDiachi.Text = "Địa chỉ";
                        cbLP.Text = "A";
                        cbP.Text = "101";
                        cbK.Text = "Trong nước";
                        dtNgayLap.Text = Convert.ToString(DateTime.Today);
                        dtNgaySinh.Text = Convert.ToString(DateTime.Today);
                        MessageBox.Show("Lập phiếu thuê thành công!");
                        int mpt = Convert.ToInt32(busHotel.loadMaPhieuThue(dtNgayLap.Text, Convert.ToInt32(cbP.SelectedValue.ToString())));
                        string t = "1";
                        busPhong.updateTinhTrangPhong(t, Convert.ToInt32(busHotel.loadMaPhong(mpt)));
                    }

                }
                else
                {
                    MessageBox.Show("Lập phiếu thuê không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }

}

        //Sửa phiếu thuê phòng, khách hàng, chi tiết phiếu thuê phòng
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtCMND.Text != "" && txtDiachi.Text != "" && txtPhoneNumber.Text != "")
            {
                DTO_PhieuThuePhong spt = new DTO_PhieuThuePhong(t,dtNgayLap.Text, (cbP.SelectedValue.ToString()));
                t = 0;
                DTO_KhachHang skh = new DTO_KhachHang(d, Convert.ToInt32(cbK.SelectedValue.ToString()), txtName.Text, txtCMND.Text, txtDiachi.Text, txtPhoneNumber.Text, dtNgaySinh.Text);
                d = 0;
                if (busHotel.suaPhieuThue(spt)&& busKh.suaKhachHang(skh))
                {
                    MessageBox.Show("Sửa phiếu thuê thành công!");
                    dgvPT.DataSource = busHotel.getPhieuthue();
                    txtName.Text = "Họ tên";
                    txtPhoneNumber.Text = "Số điện thoại";
                    txtCMND.Text = "CMND";
                    txtDiachi.Text = "Địa chỉ";
                    cbLP.Text = "A";
                    cbP.Text = "101";
                    cbK.Text = "Trong nước";
                    dtNgayLap.Text = Convert.ToString(DateTime.Today);
                    dtNgaySinh.Text = Convert.ToString(DateTime.Today);
                }
                else
                {
                    MessageBox.Show("Sửa phiếu thuê không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
}


        //Xóa phiếu thuê phòng, khách hàng, chi tiết phiếu thuê phòng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (busctpt.xoactphieuthue(m) )
            {
                if(busHotel.xoaPhieuThue(t) && busKh.xoaKhachHang(d))
                {
                    MessageBox.Show("Xóa  thành công!");
                    dgvPT.DataSource = busHotel.getPhieuthue();
                    txtName.Text = "Họ tên";
                    txtPhoneNumber.Text = "Số điện thoại";
                    txtCMND.Text = "CMND";
                    txtDiachi.Text = "Địa chỉ";
                    cbLP.Text = "A";
                    cbP.Text = "101";
                    cbK.Text = "Trong nước";
                    dtNgayLap.Text = Convert.ToString(DateTime.Today);
                    dtNgaySinh.Text = Convert.ToString(DateTime.Today);
                    
                    string tt = "0";
                    busPhong.updateTinhTrangPhong(tt,mp);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }

            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
            m = 0;
            t = 0;
            d = 0;
            
        }

        

        //Thoát khỏi form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Clear();
        }

        private void txtPhoneNumber_Click(object sender, EventArgs e)
        {
            txtPhoneNumber.Clear();
        }

        private void txtDiachi_Click(object sender, EventArgs e)
        {
            txtDiachi.Clear();
        }

        private void txtCMND_Click(object sender, EventArgs e)
        {
            txtCMND.Clear();
        }
    }
}
