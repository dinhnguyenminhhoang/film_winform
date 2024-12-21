using FilmApp.Forms.AuthForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmApp.Forms.Layout
{
    public partial class UserLayoutbase : Form
    {
        public UserLayoutbase()
        {
            InitializeComponent();
            this.CreateHeader();
        }
        private void CreateHeader()
        {
            // Lớp ngoài
            Panel outerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 100,
                BackColor = ColorTranslator.FromHtml("#1B2D3C") // Màu nền cho lớp ngoài
            };

            // Lớp bên trong
            Panel innerPanel = new Panel
            {
                Width = (int)(this.Width * 0.6), // 60% chiều ngang
                Height = 60,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.Transparent // Không màu, để nhìn xuyên qua lớp ngoài
            };

            outerPanel.Resize += (s, e) =>
            {
                innerPanel.Width = (int)(outerPanel.Width * 0.6);
                innerPanel.Location = new Point((outerPanel.Width - innerPanel.Width) / 2, (outerPanel.Height - innerPanel.Height) / 2); // Căn giữa
            };

            TableLayoutPanel headerPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                ColumnCount = 3
            };

            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            PictureBox logo = new PictureBox
            {
                Image = Image.FromFile("D:\\workspace\\project\\FilmApp\\FilmApp\\Resources\\filmlogo-removebg-preview.png"),
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill,
                Width = 100,
                Height = 60,
                Margin = new Padding(0, 0, 0, 40)
            };

            TextBox searchBox = new TextBox
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(10, 20, 10, 20),
                Font = new Font("Arial", 12)
            };

            // Panel chứa nút
            FlowLayoutPanel buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft,
                Margin = new Padding(0, 10, 0, 0)
            };

            Button loginButton = new Button
            {
                Text = "Login",
                Width = 80,
                Height = 30,
                Margin = new Padding(5),
                Cursor = Cursors.Hand,
                ForeColor = Color.White,
                BackColor = ColorTranslator.FromHtml("#34495E")
            };
            loginButton.Click += LoginButton_Click;
            Button registerButton = new Button
            {
                Text = "Register",
                Width = 80,
                Height = 30,
                Margin = new Padding(5),
                Cursor = Cursors.Hand,
                ForeColor = Color.White,
                BackColor = ColorTranslator.FromHtml("#2ECC71")
            };
            registerButton.Click += RegisterButton_Click;
            buttonPanel.Controls.Add(registerButton);
            buttonPanel.Controls.Add(loginButton);

            // Thêm các thành phần vào headerPanel
            headerPanel.Controls.Add(logo, 0, 0);
            headerPanel.Controls.Add(searchBox, 1, 0);
            headerPanel.Controls.Add(buttonPanel, 2, 0);

            innerPanel.Controls.Add(headerPanel);
            outerPanel.Controls.Add(innerPanel);
            this.Controls.Add(outerPanel);
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void UserLayoutbase_Load(object sender, EventArgs e)
        {

        }
    }
}
