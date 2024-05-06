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
using QuanLyThuVien.DTO;
using QuanLyThuVien.DAO;

namespace QuanLyThuVien
{
    public partial class AdminForm : Form
    {
        private string id { get; set; }

        //  public string txtval { get; set; }
        public AdminForm(string id)
        {
            InitializeComponent();
            txtID.Text = id;
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
            txtID.Enabled = false;
            string ma = txtID.Text;
            List<Account> ac = AccountDAO.Instance.getIdAC(ma);

            txtTen.Text = ac[0].TenUS;
            txtPass.Text = ac[0].MatKhau;
            txtEmail.Text = ac[0].Email;
            txtSDT.Text = ac[0].Sdt.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = txtID.Text;
            string ten = txtTen.Text;
            string pass = txtPass.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;

            const string message = "Bạn chắc chắn có muốn cập nhật lại không ?";
            const string caption = "Thông báo";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                AccountDAO.Instance.UpdateQTV(ma, ten, pass, email, sdt);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
