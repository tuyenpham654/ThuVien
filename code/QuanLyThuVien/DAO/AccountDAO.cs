using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        public bool Login(string userName, string passWord)
        {

              string query = "CheckLogin @Username , @Password ;";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName , passWord});
            return result.Rows.Count > 0;
        }

        public List<Account> getListAC()
        {
            List<Account> list = new List<Account>();

            string query = "select * from QuanTriVien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account ac = new Account(item);
                list.Add(ac);
            }

            return list;
        }

        public List<Account> getIdAC(string id)
        {
            List<Account> list = new List<Account>();

            string query = string.Format("select * from QuanTriVien where MaUS = '{0}' ", id) ;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account ac = new Account(item);
                list.Add(ac);
            }

            return list;
        }
        public bool UpdateQTV(string ma, string ten, string matKhau, string email, string sdt)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC UpdateQTV @MaUS , @TenUS , @MatKhau , @Email , @SDT ", new object[] { ma, ten, matKhau, email, sdt });
            return result > 0;
        }
    }
}
