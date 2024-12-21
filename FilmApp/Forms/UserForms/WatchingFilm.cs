using FilmApp.Forms.Layout;
using FilmApp.Models;
using FilmApp.repository;
using FilmApp.Utils;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;

namespace FilmApp.Forms.UserForms
{
    public partial class WatchingFilm : Form
    {
        public int FilmId { get; set; }
        public string Type { get; set; }
        private readonly FilmRepo _filmRepo;
        private readonly UtilsFnc _utilsFnc;


        public WatchingFilm(int filmId,string type)
        {
            InitializeComponent();
            this.FilmId = filmId;
            this.Type = type;
            _filmRepo = new FilmRepo();
            _utilsFnc = new UtilsFnc();
        }

        private async void WatchingFilm_Load_1(object sender, EventArgs e)
        {
            try
            {
                var filmdetail = await _filmRepo.getFilmDetails(FilmId);
                var episodesFilm = await _filmRepo.getEpisodesFilms(FilmId);
                if (filmdetail != null)
                {
                    filmNameLabel.Text = filmdetail.Name;

                    Label filmDesLabel = new Label()
                    {
                        ForeColor = Color.White,
                        Dock = DockStyle.Top,
                        Text = filmdetail.Content,
                        AutoSize = true, 
                        MaximumSize = new Size(this.desFlowLable.Width, 0),
                        TextAlign = ContentAlignment.TopLeft 
                    };

                    this.desFlowLable.Controls.Add(filmDesLabel);
                    await _utilsFnc.LoadVideo(filmdetail.Trailer, this.fullScreenBtn);
                }

                if (filmdetail.Type != "TV Series")
                {
                    this.episodesPanel.Hide();
                }
                else if (episodesFilm != null)
                {
                    initBtnEpi(episodesFilm);
                }

            }
            catch (Exception ex) { }
        }
        private void initBtnEpi(List<Episodes> episodesFilm)
        {
            FlowLayoutPanel currentPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                Dock = DockStyle.Top,
            };
            flowLayoutPanelBtn.Controls.Add(currentPanel);
            foreach (var episode in episodesFilm)
            {
                Button episodeButton = new Button
                {
                    Text = episode.Name,
                    ForeColor = Color.White,
                    Width = 75,
                    Height = 35,
                    Cursor = Cursors.Hand
                };

                episodeButton.Click += async (sender, e) =>
                {
                    await _utilsFnc.LoadVideo(episode.Link, this.fullScreenBtn);
                };
                currentPanel.Controls.Add(episodeButton);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            FullScreenFilm fullScreenFilmForm = new FullScreenFilm(FilmId);
            fullScreenFilmForm.Show();
            this.Hide();
        }
    }
}
