using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class ThongKe
    {
        private string tongSach;
        private string sachKho;
        private string sachMuon;
        private string thanhVien;
        private string thanhVienThue;
        private string tongPhieu;

        public ThongKe(DataRow row)
        {

            this.TongSach = row["TongSachKhiNhapVe"].ToString();
            this.SachKho = row["SoSachConTrongKho"].ToString();
            this.SachMuon = row["SoSachDangMuon"].ToString();
            this.ThanhVien = row["SoLuongThanhVien"].ToString();
            this.ThanhVienThue = row["SoLuongThanhVienDaMuonSach"].ToString();
            this.TongPhieu = row["SoPhieu"].ToString();
        }

        public string TongSach { get => tongSach; set => tongSach = value; }
        public string SachKho { get => sachKho; set => sachKho = value; }
        public string SachMuon { get => sachMuon; set => sachMuon = value; }
        public string ThanhVien { get => thanhVien; set => thanhVien = value; }
        public string ThanhVienThue { get => thanhVienThue; set => thanhVienThue = value; }
        public string TongPhieu { get => tongPhieu; set => tongPhieu = value; }
    }
}
