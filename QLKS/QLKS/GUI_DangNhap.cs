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
    public partial class GUI_DangNhap : Form
    {
        BUS_Account busAccount = new BUS_Account();
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPass.Text != "")
            {
                DTO_Account dn = new DTO_Account(txtUsername.Text, txtPass.Text);
                if (busAccount.DangNhap(dn))
                {
                    Session.tk = txtUsername.Text;
                    Session.mk = txtPass.Text;
                    if (busAccount.checkISADMIN(txtUsername.Text))
                    {
                        Session.isAdmin = true;
                    }

                    var homepage = new GUI_Homepage();
                    homepage.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Meo cho vo!");
                }
            }
            else
            {
                MessageBox.Show("dien day du!");
            }
        }

        private void GUI_DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            GUI_DangKi dk = new GUI_DangKi();
            dk.ShowDialog();
        }
    }
}
