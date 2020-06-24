using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DAL_Hotel
{


    public class DBConnect
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=./SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
       
    }
}
