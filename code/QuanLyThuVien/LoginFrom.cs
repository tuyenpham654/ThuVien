using QuanLyThuVien.DAO;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace QuanLyThuVien
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtTenUS.Text;
            string passWord = txtMatKhau.Text;


            if (Login(userName, passWord))
            {
                MessageBox.Show("Đăng nhập thành công", "Thông Báo!");
               /* AdminForm Admin = new AdminForm();
                string valueToSend = userName;
                Admin.txtval = valueToSend;*/
                MenuForm menuForm = new MenuForm();
                menuForm.ID = userName;
                menuForm.Show();
                this.Hide();
                
              

            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }

        }



        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
    }
}
