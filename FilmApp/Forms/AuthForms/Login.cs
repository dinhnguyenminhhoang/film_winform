using FilmApp.Forms.UserForms;
using FilmApp.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmApp.Forms.AuthForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailInput.Text;
            string password = passwordInput.Text;

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin email và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool loginSuccess = await CheckUserCredentials(email, password);

            if (loginSuccess)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Home homeForm = new Home();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> CheckUserCredentials(string email, string password)
        {
            bool isValid = false;

            try
            {
                using (var context = new FilmDBEntities())
                {
                    var user = await context.Users
                        .Where(u => u.Email == email)
                        .FirstOrDefaultAsync();

                    if (user != null)
                    {
                        // Hash mật khẩu người dùng nhập vào
                        string hashedPassword = HashPassword(password);

                        // So sánh mật khẩu đã hash với mật khẩu trong cơ sở dữ liệu
                        if (user.Password == hashedPassword)
                        {
                            isValid = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
    }
}
