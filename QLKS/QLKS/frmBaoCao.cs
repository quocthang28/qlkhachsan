using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKS
{
    public partial class frmBaoCao : UserControl
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            String a = cbMonth.Text;
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLKS;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    string query = string.Format("select tenloaiphong as 'Tên loại phòng',doanhthu as 'Doanh thu theo tháng',D.maloaiphong as 'Tỷ Lệ' from (SELECT maloaiphong, sum(thanhtien) as DoanhThu from(select P.maloaiphong, thanhtien, P.maphong from(select C.maphong, C.thanhtien from hoadon H, CHITIETHOADON C where H.mahoadon = C.mahoadon AND month(H.NGAYLAP) = '{0}') as A, PHONG P WHERE A.maphong = P.MAPHONG) as B Group by maloaiphong) as D, LOAIPHONG M WHERE D.maloaiphong = M.MALOAIPHONG", a);

                    string query2 = "SELECT sum(thanhtien) as DoanhThu from (select P.maloaiphong, thanhtien, P.maphong from(select C.maphong, C.thanhtien from hoadon H, CHITIETHOADON C where H.mahoadon = C.mahoadon AND year(H.NGAYLAP) = '2020') as A, PHONG P WHERE A.maphong = P.MAPHONG) as B";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    float totalMoney = (float)Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dAdapter.Fill(dt);

                    foreach (DataRow currentRow in dt.Rows)
                    {
                        currentRow.BeginEdit();
                        var temp = Math.Round(Convert.ToDecimal(100 * (float)Convert.ToInt32(currentRow["Doanh thu theo tháng"].ToString()) / totalMoney), 2);
                        currentRow["Tỷ Lệ"] = (float)temp + " %";
                        currentRow.EndEdit();
                    }

                    dgvDoanhThu.DataSource = dt;
                }
                catch (Exception)
                {
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
