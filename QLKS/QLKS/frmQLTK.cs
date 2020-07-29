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
        public frmQLTK()
        {
            InitializeComponent();
            showUsername();
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
            foreach(DataRow dr in dt.Rows)
            {
                tbTK.Text = dr["TENDANGNHAP"].ToString();
                tbDiachi.Text = dr["DIACHI"].ToString();
                tbEmail.Text = dr["EMAIL"].ToString();
                tbSDT.Text = dr["SDT"].ToString();
            }
        }

        private void cbNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            showAccountInfo(cbNameList.Text);
        }
    }
}
