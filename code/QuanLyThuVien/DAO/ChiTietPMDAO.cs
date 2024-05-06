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
    public class ChiTietPMDAO
    {
        private static ChiTietPMDAO instance;
        private ChiTietPMDAO() { }
       
        public static ChiTietPMDAO Instance
        {
            get { if (instance == null) instance = new ChiTietPMDAO(); return ChiTietPMDAO.instance; }
            private set { ChiTietPMDAO.instance = value; }
        }

        public List<PhieuMuonCT> GetListPM()
        {
            List<PhieuMuonCT> list = new List<PhieuMuonCT>();

            string query = "select * from View_PhieuMuon_CT";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuonCT phieuMuon = new PhieuMuonCT(item);
                list.Add(phieuMuon);
            }

            return list;
        }

        public List<PhieuMuonCT> SearchPhieuById(string id)
        {

            List<PhieuMuonCT> list = new List<PhieuMuonCT>();

            string query = string.Format("SELECT * FROM View_PhieuMuon_CT where MaPM = '{0}' ", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuonCT pm = new PhieuMuonCT(item);
                list.Add(pm);
            }

            return list;
        }

        public bool InsertPhieu(string maPhieu, string maSach, int trangThai)
        {
            //string query = string.Format("INSERT dbo.ChiTietPM (MaPM , MaSach , TrangThai) values('{0}' , '{1}' , {2} );", maPhieu, maSach, trangThai);
           // int result = DataProvider.Instance.ExecuteNonQuery(query);
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC InsertPhieuMuonCT @MaPhieu , @MaSach , @TrangThai ", new object[] { maPhieu, maSach, trangThai});

            return result > 0;
        }

        public bool UpdatePhieu(string maPhieu, string maSach, int trangThai)
        {
            //  string query = string.Format("UPDATE dbo.ChiTietPM SET TrangThai = {0} WHERE MaPM = '{1}' and MaSach = '{2}'", trangThai, maPM, maSach);
            //  int result = DataProvider.Instance.ExecuteNonQuery(query);
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC UpdatePhieuMuonCT @MaPhieu , @MaSach , @TrangThai ", new object[] { maPhieu, maSach, trangThai });

            return result > 0;
        }

        public bool DeletePhieu(string maPhieu, string maSach)
        {
            //  string query = string.Format("Delete ChiTietPM where MaPM = '{0}' and MaSach = '{1}'", maPM, maSach);
            // int result = DataProvider.Instance.ExecuteNonQuery(query);
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC DeletePhieuMuonCT @MaPhieu , @MaSach ", new object[] { maPhieu, maSach });
            return result > 0;
        }
    }
}
