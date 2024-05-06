using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Xps;

namespace QuanLyThuVien
{
    public partial class PhieuMuonForm : Form
    {


        public PhieuMuonForm()
        {
            InitializeComponent();
        }

        private void PhieuMuonForm_Load(object sender, EventArgs e)
        {
            load();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        void load()
        {
            List<PhieuMuon> phieuMuon = PhieuMuonDAO.Instance.GetListPM();
            dataGridView1.DataSource = phieuMuon;
        }

        void reset()
        {
            txtMaPM.Enabled = true;
            txtMaPM.Text = null;
            txtMaTV.Text = null;
            dtNgayMuon.Text = null;
            dtNgayTra.Text = null;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnInsert.Enabled = true;

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có phải là một hàng hợp lệ không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string maPM = row.Cells[0].Value.ToString();
                string maTV = row.Cells[1].Value.ToString();
                string ngayMuon = row.Cells[2].Value.ToString();
                string ngayTra = row.Cells[3].Value.ToString();
                tabControl1.SelectTab(tabPage2);
                // gửi data qua cập nhập
                txtMaPM.Text = maPM;
                txtMaTV.Text = maTV;
                dtNgayMuon.Text = ngayMuon;
                dtNgayTra.Text = ngayTra;

                txtMaPM.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnInsert.Enabled = false;

                // gửi data form View
                string valueToSend = maPM;
                ViewPMForm view = new ViewPMForm();
                view.txtval = valueToSend;
                view.Show();

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string maPM = txtMaPM.Text;
            string maTV = txtMaTV.Text;
            DateTime ngayMuon = dtNgayMuon.Value;
            DateTime ngayTra = dtNgayTra.Value;

            if (PhieuMuonDAO.Instance.InsertPhieu(maPM, maTV, ngayMuon, ngayTra))
            {
                MessageBox.Show("Tạo phiếu mượn thành công");
                load();
                string valueToSend = txtMaPM.Text;
                ChiTietPMForm FormCTPM = new ChiTietPMForm();
                FormCTPM.txtval = valueToSend;
                FormCTPM.Show();
            }
            else
            {
                MessageBox.Show("Có lỗi khi tạo phiếu mượn");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maPM = txtMaPM.Text;
            string maTV = txtMaTV.Text;
            DateTime ngayMuon = dtNgayMuon.Value;
            DateTime ngayTra = dtNgayTra.Value;

            PhieuMuonDAO.Instance.UpdatePhieu(maPM, maTV, ngayMuon, ngayTra);
            load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maPM = txtMaPM.Text;
            PhieuMuonDAO.Instance.DeletePhieu(maPM);
            load();
            reset();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = txtSearch.Text;
            List<PhieuMuon> phieuMuon = PhieuMuonDAO.Instance.SearchPhieuById(ma);
            dataGridView1.DataSource = phieuMuon;
        }
    }
}
