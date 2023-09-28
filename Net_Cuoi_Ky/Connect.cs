using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Cuoi_Ky
{
    internal class Connect
    {
        private string constr = @"Data Source=LAPTOP-F78SMRJU\THUHUYEN;Initial Catalog=net_cuoi_ki;Integrated Security=True";
        private SqlConnection conn;
        public Connect()
        {
            conn = new SqlConnection(constr);
        }
        public DataTable laydulieu(string truyvan)
        {
            SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public bool thucthi(string truyvan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch
            {
                return false;
            }
        }
    }

}
