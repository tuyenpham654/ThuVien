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
    public partial class ThongKeForm : Form
    {
        public ThongKeForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void QuaHanForm_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
      //  SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-8RQTHGM;Initial Catalog=QuanLyThuVien;User ID=sa;Password=123456;Integrated Security=True");
        private void ketnoicsdl()
        {

            List<ThongKe> thongKe = ThongKeDAO.Instance.ThongKe();
            lblTongSach.Text = thongKe[0].TongSach;
            lblSachKho.Text = thongKe[0].SachKho;
            lblSachThue.Text = thongKe[0].SachMuon;
            lblThanhVien.Text = thongKe[0].ThanhVien;
            lblTVThue.Text = thongKe[0].ThanhVienThue;
            lblPhieu.Text = thongKe[0].TongPhieu;
        }
    }
 }

