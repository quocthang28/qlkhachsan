using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_Hotel;
using MySql.Data.MySqlClient;

namespace DAL_Hotel
{
    public class DAL_Account
    {

        public bool DangNhap(DTO_Account dn)
        {
            string query = string.Format("SELECT * FROM TAIKHOAN WHERE TENDANGNHAP = '{0}' AND MATKHAU = '{1}'", dn.DANGKI_TK, dn.DANGKI_MK);
            DataTable result = DBConnect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public bool DangKi(DTO_Account dk)
        {
            string query = string.Format("INSERT INTO TAIKHOAN(TENDANGNHAP, HOTEN, EMAIL, DIACHI, SDT, MATKHAU, ISADMIN) VALUES('{0}', N'{1}', '{2}', N'{3}', {4}, '{5}', {6})", dk.DANGKI_TK, dk.DANGKI_NAME, dk.DANGKI_EMAIL, dk.DANGKI_DIACHI, dk.DANGKI_PHONENUMBER, dk.DANGKI_MK, dk.DANGKI_ISADMIN);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool checkISADMIN(string tk)
        {
            string query = "SELECT * FROM TAIKHOAN WHERE TENDANGNHAP = '" + tk + "' AND ISADMIN = 1";
            DataTable result = DBConnect.Instance.ExecuteQuery(query);
            return result.Rows.Count == 1;
        }

        public List<DTO_Account> getName()
        {
            List<DTO_Account> listName = new List<DTO_Account>();
            string query = "SELECT * FROM TAIKHOAN";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_Account acc = new DTO_Account(item);
                listName.Add(acc);
            }
            return listName;
        }

        public DataTable getAccountInfo(string ten)
        {
            string query = "SELECT * FROM TAIKHOAN WHERE HOTEN = '" + ten + "'";
            DataTable result = DBConnect.Instance.ExecuteQuery(query);
            return result;
        }

        public bool suaAccount(DTO_Account acc, string id)
        {
            string query = string.Format("UPDATE TAIKHOAN SET HOTEN = N'{0}', TENDANGNHAP = '{1}', EMAIL = '{2}', DIACHI = N'{3}', SDT = '{4}' WHERE ID = {5}", acc.DANGKI_NAME, acc.DANGKI_TK, acc.DANGKI_EMAIL, acc.DANGKI_DIACHI, acc.DANGKI_PHONENUMBER, id);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool xoaAccount(string id)
        {
            string query = "DELETE FROM TAIKHOAN WHERE ID = " + id;
            int reuslt = DBConnect.Instance.ExecuteNonQuery(query);
            return reuslt > 0;
        }

        public bool checkPassword(string tentk, string pass)
        {
            string query = "SELECT * FROM TAIKHOAN WHERE MATKHAU = '" + pass + "' AND TENDANGNHAP = '" + tentk + "'";
            DataTable result = DBConnect.Instance.ExecuteQuery(query);
            return result.Rows.Count == 1;
        }

        public bool changePassword(string tk, string pass)
        {
            string query = "UPDATE TAIKHOAN SET MATKHAU = '" + pass + "' WHERE TENDANGNHAP = '" + tk + "'";
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }

}
