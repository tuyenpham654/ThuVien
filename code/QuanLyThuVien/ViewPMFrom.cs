using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien
{
    public partial class ViewPMForm : Form
    {
        public ViewPMForm()
        {
            InitializeComponent();
        }

        public string txtval { get; internal set; }

        private void ViewPMForm_Load(object sender, EventArgs e)
        {
            List<viewPM> phieuMuonCT = PhieuMuonDAO.Instance.viewPM(txtval);
            lblMaPM.Text = txtval;
            if (phieuMuonCT.Count != 0) // Kiểm tra xem có phải là một hàng hợp lệ không
            {
                lblMaTV.Text = phieuMuonCT[0].MaTV;
                lblTenTV.Text = phieuMuonCT[0].TenTV;
                lblEmail.Text = phieuMuonCT[0].Sdt.ToString();
                DateTime ngayMuon =phieuMuonCT[0].NgayMuon;
                DateTime ngayTra = phieuMuonCT[0].NgayTra;
                lblNgayMuon.Text = ngayMuon.ToString("MM/dd/yyyy");
                lblNgayTra.Text = ngayTra.ToString("MM/dd/yyyy");

                DataTable dt = new DataTable();
                dt.Columns.Add("MaSach");
                dt.Columns.Add("TenSach");
                dt.Columns.Add("TrangThai");
                foreach (var item in phieuMuonCT)
                {
                    dt.Rows.Add(item.MaSach, item.TenSach, item.TrangThai);
                }
                dataGridView1.DataSource = dt;
            }
            else
            {
                const string message = "Phiếu mượn này chưa tạo thông tin đầy đủ, bạn có muốn tạo không ?";
                const string caption = "Thông báo";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                    ChiTietPMForm FormCTPM = new ChiTietPMForm();
                    FormCTPM.txtval = txtval;
                    FormCTPM.Show();
                }
            }
        }

    }
}
