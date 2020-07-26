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
    public partial class frmDoiPhong : Form
    {
        private frmPhong Phong = new frmPhong();
        BUS_LapPhieuThue busHotel = new BUS_LapPhieuThue();
        BUS_Phong busPhong = new BUS_Phong();
        public frmDoiPhong(frmPhong phong)
        {
            Phong = phong;
            InitializeComponent();
        }

        private void frmDoiPhong_Load(object sender, EventArgs e)
        {
            cbLpCu.DisplayMember = "LOAIPHONG_TENLOAIPHONG";
            cbLpCu.ValueMember = "LOAIPHONG_MALOAIPHONG";
            cbLpCu.DataSource = BUS_LoaiPhong.Instance.LoadDanhSachLoaiPhong();

            cbLpMoi.DisplayMember = "LOAIPHONG_TENLOAIPHONG";
            cbLpMoi.ValueMember = "LOAIPHONG_MALOAIPHONG";
            cbLpMoi.DataSource = BUS_LoaiPhong.Instance.LoadDanhSachLoaiPhong();
        }

        
        private void cbLpCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            DTO_LoaiPhong selected = cb.SelectedItem as DTO_LoaiPhong;
            id = selected.LOAIPHONG_MALOAIPHONG;

            cbPCu.DataSource = BUS_Phong.Instance.loadDanhSachPhongTheoLoaiPhong(id);
            cbPCu.DisplayMember = "PHONG_TENPHONG";
            cbPCu.ValueMember = "PHONG_MAPHONG";
        }

        
        private void cbLpMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            DTO_LoaiPhong selected = cb.SelectedItem as DTO_LoaiPhong;
            id = selected.LOAIPHONG_MALOAIPHONG;

            cbPMoi.DataSource = BUS_Phong.Instance.loadDanhSachPhongTheoLoaiPhong(id);
            cbPMoi.DisplayMember = "PHONG_TENPHONG";
            cbPMoi.ValueMember = "PHONG_MAPHONG";
        }

        public int mpcu=0;
        public int mpt = 0;
        public string id1;
        private void cbPCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            DTO_Phong selected = cb.SelectedItem as DTO_Phong;
            id1 = selected.PHONG_MAPHONG;
            mpcu = Convert.ToInt32(id1);

            string lmpt = busHotel.loadMaPhieuThue(mpcu);
            mpt = Convert.ToInt32(lmpt);
        }

        public int mpmoi = 0;
        public string id2;
        private void cbPMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            DTO_Phong selected = cb.SelectedItem as DTO_Phong;
            id2 = selected.PHONG_MAPHONG;
            mpmoi = Convert.ToInt32(id2);
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (busHotel.suaPhieuThue(mpmoi, mpt))
            {
                string ttmoi = "1";
                busPhong.updateTinhTrangPhong(ttmoi, mpmoi);

                string ttcu = "0";
                busPhong.updateTinhTrangPhong(ttcu, mpcu);
                
            
                Phong.showPhong(false);

                MessageBox.Show("Đổi phòng thành công!");
                this.Close();
            }
        }
    }
}
