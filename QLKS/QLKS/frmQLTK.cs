using BUS_Hotel;
using DTO_Hotel;
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
    public partial class frmQLTK : Form
    {
        BUS_Account busAccount = new BUS_Account();
        private string id;
        public frmQLTK()
        {
            InitializeComponent();
            showUsername();
        }

        private bool validateData()
        {
            return (string.IsNullOrEmpty(tbDiachi.Text) || string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbSDT.Text) || string.IsNullOrEmpty(tbTK.Text));
        }

        private void showUsername() // show ho ten nguoi dung trong cb box
        {
            List<DTO_Account> nameList = busAccount.getName();
            cbNameList.DisplayMember = "DANGKI_NAME";
            cbNameList.ValueMember = "DANGKI_NAME";
            cbNameList.DataSource = nameList;
        }

        private void showAccountInfo(string ten)
        {
            DataTable dt = busAccount.getAccountInfo(ten);
            foreach (DataRow dr in dt.Rows)
            {
                tbTK.Text = dr["TENDANGNHAP"].ToString();
                tbDiachi.Text = dr["DIACHI"].ToString();
                tbEmail.Text = dr["EMAIL"].ToString();
                tbSDT.Text = dr["SDT"].ToString();
                id = dr["ID"].ToString();
            }
        }

        private void cbNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            showAccountInfo(cbNameList.Text);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                DTO_Account tk = new DTO_Account(cbNameList.Text, tbTK.Text, tbEmail.Text, tbDiachi.Text, tbSDT.Text);
                if (busAccount.suaAccount(tk, id))
                {
                    MessageBox.Show("Sửa tài khoản thành công!");
                    showUsername();
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản không thành công!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                if (busAccount.xoaAccount(id))
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    showUsername();
                    cbNameList.Text = tbTK.Text = tbEmail.Text = tbDiachi.Text = tbSDT.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản không thành công!");
                }
            }
        }
    }
}
