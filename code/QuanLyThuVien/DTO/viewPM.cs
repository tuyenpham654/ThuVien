using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class viewPM
    {
        private string maPM;
        private string maTV;
        private string tenTV;
        private int sdt;
        private string tenSach;
        private string maSach;
        private DateTime ngayMuon;
        private DateTime ngayTra;
        private string trangThai;

        public viewPM(DataRow row)
        {
            maPM = row["MaPM"].ToString();
            maTV = row["MaTV"].ToString();
            NgayMuon = (DateTime)row["NgayMuon"];
            NgayTra = (DateTime)row["NgayTra"];
            tenTV = row["TenTV"].ToString();
            sdt =(int) row["SDT"];
            maSach = row["MaSach"].ToString();
            trangThai = row["TrangThai"].ToString();
            tenSach = row["TenSach"].ToString();
        }

        public string MaPM { get => maPM; set => maPM = value; }
        public string MaTV { get => maTV; set => maTV = value; }
        public string TenTV { get => tenTV; set => tenTV = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
        public int Sdt { get => sdt; set => sdt = value; }
    }
}
