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
    public partial class frmThayDoiPhuThu : UserControl
    {
        //BUS_PhuThu buspt = new BUS_PhuThu();
        //public frmThayDoiPhuThu()
        //{
        //    InitializeComponent();
        //}

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
            
        //}

        //private void frmThayDoiPhuThu_Load(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource = buspt.getPhuThu();

        //    string SQL = string.Format("SELECT * FROM PHUTHU ");
        //    DataTable dt = buspt.Hienthi(SQL);
        //    cbPT.DisplayMember = "TENPHUTHU";
        //    cbPT.ValueMember = "MAPHUTHU";
        //    cbPT.DataSource = dt;
        //}

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    DTO_PhuThu editpt = new DTO_PhuThu(cbPT.SelectedValue.ToString(), txtTyLe.Text, txtGhiChu.Text);

        //    if(buspt.editPhuThu(editpt))
        //    {
        //        MessageBox.Show("Thay đổi thành công!");
        //        dataGridView1.DataSource = buspt.getPhuThu();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thay đổi không thành công!");
        //    }
        //}

        //private void btnThoat_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}
