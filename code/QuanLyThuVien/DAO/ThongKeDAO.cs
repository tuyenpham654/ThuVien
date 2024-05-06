using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace QuanLyThuVien.DAO
{
    public class ThongKeDAO
    {
        private static ThongKeDAO instance;
        public static ThongKeDAO Instance
        {
            get { if (instance == null) instance = new ThongKeDAO(); return instance; }
            private set { instance = value; }
        }

        public List<ThongKe> ThongKe()
        {
            List<ThongKe> list = new List<ThongKe>();
            string query = "select * from ThongKe();";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThongKe tacgia = new ThongKe(item);
                list.Add(tacgia);
            }

            return list;
        }
    }
}
