using FilmApp.Models;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FilmApp.Forms.AuthForms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private async void registerBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string email = emailInput.Text;
            string password = passwordInput.Text;
            string confirmPassword = confirmPasswordInput.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var context = new FilmDBEntities())
                {
                    var existingUser = await context.Users
                        .Where(u => u.Email == email)
                        .FirstOrDefaultAsync();

                    if (existingUser != null)
                    {
                        MessageBox.Show("Email này đã được sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Mã hóa mật khẩu
                    string hashedPassword = HashPassword(password);

                    var newUser = new Users
                    {
                        Name = name,
                        Email = email,
                        Password = hashedPassword, // Lưu mật khẩu đã mã hóa
                        RoleId = 1,
                        Avatar = "",
                    };

                    context.Users.Add(newUser);
                    await context.SaveChangesAsync();

                    MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
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
    }
}
