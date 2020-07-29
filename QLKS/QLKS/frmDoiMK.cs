using BUS_Hotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmDoiMK : Form
    {
        BUS_Account busAccount = new BUS_Account();
        private string tenTK;
        public frmDoiMK()
        {
            InitializeComponent();
            tenTK = Session.tk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbReEnter.Text == "" || tbNewPass.Text == "" || tbOldPass.Text == "")
            {
                MessageBox.Show("Nhập đầy dủ thông tin");
            }
            else
            {
                if (tbNewPass.Text != tbReEnter.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không khớp");
                }
                else
                {
                    if (busAccount.checkPassword(tenTK, tbOldPass.Text))
                    {
                        if (busAccount.changePassword(tenTK, tbNewPass.Text))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công");
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu không thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu");
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
