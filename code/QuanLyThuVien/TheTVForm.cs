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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics;

namespace QuanLyThuVien
{
    public partial class TheTVForm : Form
    {
        public TheTVForm()
        {
            InitializeComponent();
        }


        private void rboAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
        void load()
        {
            List<TheThanhVien> theList = TheTVDAO.Instance.GetListTheTV();
            dataGridView1.DataSource = theList;
        }
        private void TheTVForm_Load(object sender, EventArgs e)
        {
            load();
        }

     

        void reset()
        {
            txtMaTV.Text = null;
            txtTenTV.Text = null;
            txtDiaChi.Text = null;
            txtEmail.Text = null;
            txtSdt.Text = null;
            rboNam.Checked = false;
            rboNu.Checked = false;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string maTV = txtMaTV.Text;
            string tenTV = txtTenTV.Text;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;
            int gioiTinh = 2;

            //   gioiTinh = rboNam.Checked ? true : false;
            if (rboNam.Checked == true)
            {
                gioiTinh = 1;
            }
            else if (rboNam.Checked == false)
                gioiTinh = 0;

            string sdt = txtSdt.Text;

            if (maTV == "" || tenTV == "" || diaChi == "" || email == "" || sdt == "" || gioiTinh == 2)
            {

                MessageBox.Show("Các trường không được để trống");
            }
            else
            {
              
               // load();

            
                if (TheTVDAO.Instance.InsertThe(maTV, tenTV, diaChi, email, gioiTinh, sdt))
                {
                    MessageBox.Show("Thêm thẻ thành viên thành công");
                   // reset();
                    load();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm thẻ");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reset();
            txtMaTV.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ma = txtMaTV.Text;
            TheTVDAO.Instance.DeleteThe(ma);
            reset();
            load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maTV = txtMaTV.Text;
            string tenTV = txtTenTV.Text;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;
            int gioiTinh = 0;

            if (rboNam.Checked == true)
            {
                gioiTinh = 1;
            }
              
            else 
            {
                gioiTinh = 0;
            }
               

            string sdt = txtSdt.Text;
            if (maTV == "" || tenTV == "" || diaChi == "" || email == "" || sdt == "")
            {

                MessageBox.Show("Các trường không được để trống");
            }
            else
            {
                TheTVDAO.Instance.UpdateThe(maTV, tenTV, diaChi, email, gioiTinh, sdt);
                //reset();
                load();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có phải là một hàng hợp lệ không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string maTV = row.Cells[0].Value.ToString();
                List<TheThanhVien> theList = TheTVDAO.Instance.SearchTheByID(maTV);
                txtMaTV.Text = maTV;
                txtTenTV.Text = theList[0].TenTV.ToString();
                txtDiaChi.Text = theList[0].DiaChi.ToString();
                txtEmail.Text = theList[0].Email.ToString();
                txtSdt.Text = theList[0].SDT.ToString();


               if(theList[0].GioiTinh == true)
                {
                    rboNam.Checked = true;
                }
                else
                {
                    rboNu.Checked = true;
                }
                tabControl1.SelectTab(tabPage2);
                txtMaTV.Enabled = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = txtTimKiem.Text;
            List<TheThanhVien> the = TheTVDAO.Instance.SearchTheByID(ma);
            dataGridView1.DataSource = the;
        }
    }
}