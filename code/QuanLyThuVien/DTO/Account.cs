using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class Account
    {
        private string maUS;
        private string tenUS;
        private string matKhau;
        private string email;
        private int sdt;

        public Account(DataRow row)
        {

            this.MaUS = row["MaUS"].ToString();
            this.TenUS = row["TenUS"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.Email = row["Email"].ToString();
            this.Sdt = (int)row["SDT"];

        }
        public string MaUS { get => maUS; set => maUS = value; }
        public string TenUS { get => tenUS; set => tenUS = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string Email { get => email; set => email = value; }
        public int Sdt { get => sdt; set => sdt = value; }
    }
}
