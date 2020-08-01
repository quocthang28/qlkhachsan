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
        BUS_Account busAccount = new BUS_Account();
        private int isAd;
        public GUI_DangKi()
        {
            InitializeComponent();
        }

        private bool validateTextbox()
        {
            return (string.IsNullOrEmpty(txtTk.Text) || string.IsNullOrEmpty(txtPhonenumber.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtMk.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtDiachi.Text));
        }

        private bool checkPass()
        {
            return (txtMk.Text == txtMk2.Text);
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (validateTextbox())
            {
                MessageBox.Show("Điền đầy đủ thông tin!");
            }
            else
            {
                if (checkPass())
                {
                    if(cbAdmin.SelectedItem.ToString() == "Có")
                    {
                        isAd = 1;
                    }
                    else if (cbAdmin.SelectedItem.ToString() == "Không")
                    {
                        isAd = 0;
                    }
                    DTO_Account acc = new DTO_Account(txtTk.Text ,txtMk.Text, isAd, txtName.Text ,txtEmail.Text, txtPhonenumber.Text, txtDiachi.Text);
                    if (busAccount.DangKi(acc))
                    {
                        MessageBox.Show("Đăng kí thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Đăng kí không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không khớp!");
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
