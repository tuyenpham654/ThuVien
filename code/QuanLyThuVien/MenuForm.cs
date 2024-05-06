using System.Timers;

namespace QuanLyThuVien
{
    public partial class MenuForm : Form
    {
        public string ID { get; internal set; }

        public MenuForm()
        {
            InitializeComponent();

            timer1.Interval = 1000; // 1000 milliseconds = 1 second
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            label2.Text = time.ToString("HH:mm:ss");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SachForm sachForm = new SachForm();
            sachForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoaiSachFrom loaiSach = new LoaiSachFrom();
            loaiSach.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TacGiaForm tacGia = new TacGiaForm();
            tacGia.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PhieuMuonForm phieuMuon = new PhieuMuonForm();
            phieuMuon.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChiTietPMForm chiTietPM = new ChiTietPMForm();
            chiTietPM.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QTVForm qtvForm = new QTVForm();
            qtvForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TheTVForm theTVForm = new TheTVForm();
            theTVForm.Show();
        }

      

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Thực hiện các công việc cần thiết để đăng xuất, chẳng hạn như đặt lại trạng thái đăng nhập
                // Để minh họa, chúng ta chỉ đóng cửa sổ chính
                this.Hide();

                // Hiển thị lại form đăng nhập hoặc form khác tùy thuộc vào yêu cầu của ứng dụng
                LoginFrom LoginFrom = new LoginFrom();
                LoginFrom.Show();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TacGiaForm tacGiaForm = new TacGiaForm();
            tacGiaForm.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            ThongKeForm tk = new ThongKeForm();
            tk.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string id = ID;
            AdminForm ad= new AdminForm(id);

            ad.Show();
        }
    }
}
