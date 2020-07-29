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

namespace QLKS
{
    public partial class frmThayDoiQuiDinh : UserControl
    {
        public frmThayDoiQuiDinh()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnHeSo_Click(object sender, EventArgs e)
        {
            float result = 0;
            if (float.TryParse(tbHeSo.Text, out result))
            {
                if (BUS_ThamSo.Instance.ThayDoiHeSo(result))
                {
                    MessageBox.Show("Thay đổi thành công");
                }
                else MessageBox.Show("Thay đổi không thành công");
            }

            else
            {
                MessageBox.Show("Nhập sai");
            }
        }

        private void btnSLNguoiTrongPhong_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(tbSLNguoiTrongPhong.Text, out result))
            {
                if (BUS_ThamSo.Instance.ThayDoiSoNguoiToiDaTrongPhong(result))
                {
                    MessageBox.Show("Thay đổi thành công");
                }
                else MessageBox.Show("Thay đổi không thành công");
            }

            else
            {
                MessageBox.Show("Nhập sai");
            }
        }

        private void btnPhuThu_Click(object sender, EventArgs e)
        {
            float result = 0;
            if (float.TryParse(tbPhuThu.Text, out result))
            {
                if (BUS_ThamSo.Instance.ThayDoiPhuThu(result))
                {
                    MessageBox.Show("Thay đổi thành công");
                }
                else MessageBox.Show("Thay đổi không thành công");
            }

            else
            {
                MessageBox.Show("Nhập sai");
            }
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            if (Session.isAdmin == true)
            {
                var qltk = new frmQLTK();
                qltk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản này không có quyền chỉnh sửa!");
            }
        }
    }
}
