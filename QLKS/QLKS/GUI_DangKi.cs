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
    public partial class GUI_DangKi : Form
    {
        BUS_Account busDK = new BUS_Account();
        public GUI_DangKi()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            DTO_Account dk = new DTO_Account(null, null,txtName.Text, txtPhonenumber.Text, txtEmail.Text, null);

            if (busDK.themDangKi(dk))
            {
                MessageBox.Show("Đăng kí thành công!");

            }
            else
            {
                MessageBox.Show("Đăng kí không thành công!");
            }
            //    DTO_DangKi dk = new DTO_DangKi(txtTk.Text, txtMk.Text);
            //    if (busDK.themDangKi(dk))
            //    {
            //        MessageBox.Show("Đăng kí thành công!");

            //    }
            //    else
            //    {
            //        MessageBox.Show("Đăng kí không thành công!");
            //    }


            //if (txtTk.Text != "" && txtMk.Text != "" && txtName.Text != "" && txtEmail.Text != "" && txtPhonenumber.Text != "" && txtDiachi.Text != "")
            //{
            //    DTO_DangKi dk = new DTO_DangKi(txtTk.Text, txtMk.Text, txtName.Text, txtEmail.Text, txtPhonenumber.Text, txtDiachi.Text);

            //    if (busDK.themDangKi(dk))
            //    {
            //        MessageBox.Show("Đăng kí thành công!");

            //    }
            //    else
            //    {
            //        MessageBox.Show("Đăng kí không thành công!");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            //}


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
