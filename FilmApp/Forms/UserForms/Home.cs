using FilmApp.Forms.AuthForms;
using FilmApp.Models;
using FilmApp.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmApp.Forms.UserForms
{
    public partial class Home : Form
    {
        private readonly FilmRepo _filmRepo;
        private int currentPage = 1;
        private const int pageSize = 12;
        private  int totalPages = 1;
        public Home()
        {
            InitializeComponent();
            _filmRepo = new FilmRepo();
        }

        private async void Home_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(0, 0);
            this.CreateHeader();
            await LoadFilmsAsync();
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
       
        private void Film_Click(object sender, EventArgs e)
        {
            int filmId = GetFilmIdFromClick(sender);
            FilmDetail filmDetailForm = new FilmDetail(filmId);
            filmDetailForm.Show();
            this.Hide();
        }

        private int GetFilmIdFromClick(object sender)
        {
            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null && clickedPanel.Tag is int)
            {
                return (int)clickedPanel.Tag;
            }
            return -1; 
        }
        private async Task LoadFilmsAsync()
        {
            int filmCount = await _filmRepo.GetFilmCount();
            totalPages = (int)Math.Ceiling((double)filmCount / pageSize);
            var topFilms = await _filmRepo.GetFilmHot();
            var compeleteFilms = await _filmRepo.GetFilmStatus("Complete");
            var filmList = await _filmRepo.GetAllFilms(currentPage, pageSize);

            var filmPanel = new[] { panelFIm1, panelFIm2, panelFIm3, panelFIm4, panelFIm5, panelFIm6, panelFIm7, panelFIm8, panelFIm9, panelFIm10, panelFIm11, panelFIm12, panelFIm13, panelFIm14, panelFIm15, panelFIm16, panelFIm17, panelFIm18, panelFIm19, panelFIm20, panelFIm21, panelFIm22, panelFIm23, panelFIm24 };
            var nameLabels = new[] { nameFilmLabel1, nameFilmLabel2, nameFilmLabel3, nameFilmLabel4, nameFilmLabel5, nameFilmLabel6 };
            var descriptionLabels = new[] { filmDescription1, filmDescription2, filmDescription3, filmDescription4, filmDescription5, filmDescription6 };
            var yearLabels = new[] { yearLabel1, yearLabel2, yearLabel3, yearLabel4, yearLabel5, yearLabel6 };
            var imageControls = new[] { filmImage1, filmImage2, filmImage3, filmImage4, filmImage5, filmImage6 };
           //
            var namestatusLabels = new[] { nameStatus1, nameStatus2, nameStatus3, nameStatus4, nameStatus5, nameStatus6 };
            var descriptionStatusLabels = new[] { desStatus1, desStatus2, desStatus3, desStatus4, desStatus5, desStatus6 };
            var statusLabels = new[] { statusLabel1, statusLabel2, statusLabel3, statusLabel4, statusLabel5, statusLabel6 };
            var yearStatusLabels = new[] { yearStatus1, yearStatus2, yearStatus3, yearStatus4, yearStatus5, yearStatus6 };
            var imageCptControls = new[] { filmImageStaus1, filmImageStaus2, filmImageStaus3, filmImageStaus4, filmImageStaus5, filmImageStaus6 };
           //
            var nameCompleteLabels = new[] { nameCompleteLabel1, nameCompleteLabel2, nameCompleteLabel3, nameCompleteLabel4, nameCompleteLabel5, nameCompleteLabel6, nameCompleteLabel7, nameCompleteLabel8, nameCompleteLabel9, nameCompleteLabel10, nameCompleteLabel11, nameCompleteLabel12 };
            var descriptionCompleteLabels = new[] { descriptionCompleteLabel1, descriptionCompleteLabel2, descriptionCompleteLabel3, descriptionCompleteLabel4, descriptionCompleteLabel5, descriptionCompleteLabel6, descriptionCompleteLabel7, descriptionCompleteLabel8, descriptionCompleteLabel9, descriptionCompleteLabel10, descriptionCompleteLabel11, descriptionCompleteLabel12 };
            var statusCompleteLabels = new[] { statusCompleteLabel1, statusCompleteLabel2, statusCompleteLabel3, statusCompleteLabel4, statusCompleteLabel5, statusCompleteLabel6, statusCompleteLabel7, statusCompleteLabel8, statusCompleteLabel9, statusCompleteLabel10, statusCompleteLabel11, statusCompleteLabel12, statusCompleteLabel6 };
            var yearCompleteLabels = new[] { yearCompleteLabel1, yearCompleteLabel2, yearCompleteLabel3, yearCompleteLabel4, yearCompleteLabel5, yearCompleteLabel6, yearCompleteLabel7, yearCompleteLabel8, yearCompleteLabel9, yearCompleteLabel10, yearCompleteLabel11, yearCompleteLabel12 };
            var imageAllControls = new[] { filmStatusImage1, filmStatusImage2, filmStatusImage3, filmStatusImage4, filmStatusImage5, filmStatusImage6 , filmStatusImage7 , filmStatusImage8 , filmStatusImage9 , filmStatusImage10 , filmStatusImage11 , filmStatusImage12 };

            for (int i = 0; i < topFilms.Count && i < 6; i++)
            {
                var film = topFilms[i];
                nameLabels[i].Text = film.Name;
                descriptionLabels[i].Text = film.Content;
                statusLabels[i].Text = film.Status;
                yearLabels[i].Text = film.ReleaseYear.ToString();

                if (!string.IsNullOrEmpty(film.Poster))
                {
                    try
                    {
                        if (film.Poster.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                        {
                            using (HttpClient client = new HttpClient())
                            {
                                var response = await client.GetAsync(film.Poster);
                                response.EnsureSuccessStatusCode();

                                using (var stream = await response.Content.ReadAsStreamAsync())
                                {
                                    imageControls[i].Image = Image.FromStream(stream);
                                }
                            }
                        }
                        else
                        {
                            imageControls[i].Image = Image.FromFile(film.Poster);
                        }

                        imageControls[i].SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                    }
                }
                filmPanel[i].Click += Film_Click;
                filmPanel[i].Tag = film.Id;
            }
            for (int i = 0; i < compeleteFilms.Count && i < 6; i++)
            {
                var film = compeleteFilms[i];

                namestatusLabels[i].Text = film.Name;
                descriptionStatusLabels[i].Text = film.Content;
                yearStatusLabels[i].Text = film.ReleaseYear.ToString();

                if (!string.IsNullOrEmpty(film.Poster))
                {
                    try
                    {
                        if (film.Poster.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                        {
                            using (HttpClient client = new HttpClient())
                            {
                                var response = await client.GetAsync(film.Poster);
                                response.EnsureSuccessStatusCode();

                                using (var stream = await response.Content.ReadAsStreamAsync())
                                {
                                    imageCptControls[i].Image = Image.FromStream(stream);
                                }
                            }
                        }
                        else
                        {
                            imageCptControls[i].Image = Image.FromFile(film.Poster);
                        }

                        imageCptControls[i].SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                    }
                }
                filmPanel[i + 6].Click += Film_Click;
                filmPanel[i + 6].Tag = film.Id;
            }

            for (int i = 0; i < filmList.Count && i < 12; i++)
            {
                var film = filmList[i];

                nameCompleteLabels[i].Text = film.Name;
                descriptionCompleteLabels[i].Text = film.Content;
                statusCompleteLabels[i].Text = film.Status;
                yearCompleteLabels[i].Text = film.ReleaseYear.ToString();

                if (!string.IsNullOrEmpty(film.Poster))
                {
                    try
                    {
                        if (film.Poster.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                        {
                            using (HttpClient client = new HttpClient())
                            {
                                var response = await client.GetAsync(film.Poster);
                                response.EnsureSuccessStatusCode();

                                using (var stream = await response.Content.ReadAsStreamAsync())
                                {
                                    imageAllControls[i].Image = Image.FromStream(stream);
                                }
                            }
                        }
                        else
                        {
                            imageAllControls[i].Image = Image.FromFile(film.Poster);
                        }

                        imageAllControls[i].SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                    }
                }
                filmPanel[i + 12].Click += Film_Click;
                filmPanel[i + 12].Tag = film.Id;
            }
           
            // Update pagination buttons and current page
            curentPage.Text = currentPage.ToString();
            preBtn.Enabled = currentPage > 1;
            nextBtn.Enabled = currentPage < totalPages;
        }
        private async Task LoadImageAsync(string posterUrl, PictureBox imageControl)
        {
            try
            {
                if (posterUrl.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = await client.GetAsync(posterUrl);
                        response.EnsureSuccessStatusCode();

                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            imageControl.Image = Image.FromStream(stream);
                        }
                    }
                }
                else
                {
                    imageControl.Image = Image.FromFile(posterUrl);
                }

                imageControl.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
            }
        }

        private async void preBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                await LoadFilmsAsync();
            }
        }

        private async void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                await LoadFilmsAsync();
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
