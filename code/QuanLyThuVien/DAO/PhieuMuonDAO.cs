using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class PhieuMuonDAO
    {
        private static PhieuMuonDAO instance;
        private PhieuMuonDAO() { }
        public static PhieuMuonDAO Instance
        {
            get { if (instance == null) instance = new PhieuMuonDAO(); return PhieuMuonDAO.instance; }
            private set { PhieuMuonDAO.instance = value; }
        }

        public List<PhieuMuon> GetListPM()
        {
            List<PhieuMuon> list = new List<PhieuMuon>();

            string query = "select * from PhieuMuon";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuon phieuMuon = new PhieuMuon(item);
                list.Add(phieuMuon);
            }

            return list;
        }

        public List<PhieuMuon> SearchPhieuById(string id)
        {

            List<PhieuMuon> list = new List<PhieuMuon>();

            string query = string.Format("SELECT * FROM PhieuMuon where MaPM like '%{0}%' ", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuon pm = new PhieuMuon(item);
                list.Add(pm);
            }

            return list;
        }

        public List<viewPM> viewPM(string id)
        {

            List<viewPM> list = new List<viewPM>();

            string query = string.Format("SELECT * FROM View_PhieuMuon_CT where MaPM = '{0}' ", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                viewPM pm = new viewPM(item);
                list.Add(pm);
            }

            return list;
        }

        public bool InsertPhieu(string maPhieu, string maTV, DateTime ngayMuon, DateTime ngayTra)
        {
            string query = string.Format("INSERT dbo.PhieuMuon (MaPM , MaTV, NgayMuon, NgayTra) values('{0}' , '{1}' , '{2}' , '{3}');", maPhieu, maTV,  ngayMuon,  ngayTra);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdatePhieu(string maPhieu, string maTV, DateTime ngayMuon, DateTime ngayTra)
        {
            //    string query = string.Format("UPDATE dbo.PhieuMuon SET MaTV = '{0}' , NgayMuon = '{1}' , NgayTra = '{2}' WHERE MaPM = '{3}'", maTV, ngayMuon, ngayTra, maPhieu);
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC UpdatePhieuMuon @MaPM , @MaTV , @NgayMuon , @NgayTra ", new object[] { maPhieu, maTV, ngayMuon, ngayTra});
            return result > 0;
        }

        public bool DeletePhieu(string maPhieu)
        {
            //       string query = string.Format("Delete PhieuMuon where MaPM = '{0}'", maPhieu);
            //      int result = DataProvider.Instance.ExecuteNonQuery(query);
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC DeletePhieuMuon @MaPM ", new object[] { maPhieu });
            return result > 0;
        }
    }
}
