using FilmApp.Forms.AuthForms;
using FilmApp.Forms.Layout;
using FilmApp.repository;
using FilmApp.Utils;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace FilmApp.Forms.UserForms
{
    public partial class filmImage : UserLayoutbase
    {
        public int FilmId { get; set; }
        
        private readonly FilmRepo _filmRepo;
        private readonly UtilsFnc _utilsFnc;
        public filmImage(int filmId)
        {
            InitializeComponent();
            _filmRepo = new FilmRepo();
            _utilsFnc = new UtilsFnc();
            this.FilmId = filmId;
        }

        private void FilmDetail_Load(object sender, EventArgs e)
        {
            LoadFilmDetails();
        }

        private async void LoadFilmDetails()
        {
            var filmDetail = await _filmRepo.getFilmDetails(this.FilmId);
            if (filmDetail.Id > 0) {
                System.Windows.Forms.Label filmDesLabell = new System.Windows.Forms.Label()
                {
                    ForeColor = Color.White,
                    Dock = DockStyle.Top,
                    Text = filmDetail.Content,
                    AutoSize = true,
                    MaximumSize = new Size(this.panelDes.Width, 0),
                    TextAlign = ContentAlignment.TopLeft
                };
                this.panelDes.Controls.Add(filmDesLabell);
                await _utilsFnc.LoadImageAsync(filmDetail.Poster, this.filmBackground);
                this.filmStatus.Text = filmDetail.Status;
                this.filmTime.Text = filmDetail.Runtime;
                this.filmViewed.Text = filmDetail.Viewed.ToString() + " " + "Lượt Xem";
                this.filmYear.Text ="Năm" + " " + filmDetail.ReleaseYear.ToString();
                this.filmRating.Text = filmDetail.Rating.ToString() + " " +"SAO";
                this.filmName.Text = filmDetail.Name;
                this.filmGenres.Text = filmDetail.Genres != null && filmDetail.Genres.Any()
                    ? string.Join(" - ", filmDetail.Genres.Select(g => g.Name))
                    : "Đang cập nhật";

                this.filmCountry.Text = filmDetail.Countries != null && filmDetail.Countries.Any()
                    ? string.Join(" - ", filmDetail.Countries.Select(c => c.Name))
                    : "Đang cập nhật";
            }
        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trailerLable_Click(object sender, EventArgs e)
        {
            WatchingFilm watchingFilmForm = new WatchingFilm(FilmId,"trailer");
            watchingFilmForm.Show();
            this.Hide();
        }

        private void WatchLabel_Click(object sender, EventArgs e)
        {
            WatchingFilm watchingFilmForm = new WatchingFilm(FilmId,"video");
            watchingFilmForm.Show();
            this.Hide();
        }
    }
}
