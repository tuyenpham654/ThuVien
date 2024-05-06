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

namespace QuanLyThuVien
{
    public partial class QTVForm : Form
    {
        public QTVForm()
        {
            InitializeComponent();
        }


        private void QTVForm_Load(object sender, EventArgs e)
        {
            load();
            txtID.Enabled = false;
            txtTen.Enabled = false;
            txtEmail.Enabled = false;
            txtSDT.Enabled = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có phải là một hàng hợp lệ không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string ma = row.Cells[0].Value.ToString();
                string ten = row.Cells[1].Value.ToString();
                string email = row.Cells[2].Value.ToString();
                string sdt = row.Cells[3].Value.ToString();
                txtID.Text = ma;
                txtTen.Text = ten;
                txtEmail.Text = email;
                txtSDT.Text = sdt;

                tabControl1.SelectTab(tabPage2);

            }
        }
        void load()
        {
            List<Account> ac = AccountDAO.Instance.getListAC();

            //dataGridView1.DataSource = ac;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("", "Mã Thủ Thư");
            dataGridView1.Columns.Add("", "Tên Thủ Thư");
            dataGridView1.Columns.Add("", "Email");
            dataGridView1.Columns.Add("", "Số Điện Thoại");

            foreach (var account in ac)
            {
                dataGridView1.Rows.Add(account.MaUS, account.TenUS, account.Email, account.Sdt);
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); // Xóa tất cả các dòng
            dataGridView1.Columns.Clear(); // Xóa tất cả các cột
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("", "Mã Thủ Thư");
            dataGridView1.Columns.Add("", "Tên Thủ Thư");
            dataGridView1.Columns.Add("", "Email");
            dataGridView1.Columns.Add("", "Số Điện Thoại");

            string ma= txtSearch.Text;
            if(ma != "")
            {
                List<Account> ac = AccountDAO.Instance.getIdAC(ma);
                foreach (var account in ac)
                {
                    dataGridView1.Rows.Add(account.MaUS, account.TenUS, account.Email, account.Sdt);
                }
            }
            else
            {
                List<Account> ac = AccountDAO.Instance.getListAC();
                foreach (var account in ac)
                {
                    dataGridView1.Rows.Add(account.MaUS, account.TenUS, account.Email, account.Sdt);
                }
            }
        }
    }
}
