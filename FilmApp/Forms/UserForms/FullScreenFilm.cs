using FilmApp.repository;
using FilmApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmApp.Forms.UserForms
{
    public partial class FullScreenFilm : Form
    {
        private int FilmId;
        private readonly UtilsFnc _utilsFnc;
        private readonly FilmRepo _filmRepo;

        public FullScreenFilm(int filmId)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += FilmDetail_KeyDown; 
            FilmId = filmId;
            _utilsFnc = new UtilsFnc();
            _filmRepo = new FilmRepo();
            this.LoadFim();
        }
        public async void LoadFim()
        {
            var filmDetail = await _filmRepo.getFilmDetails(FilmId);
            await _utilsFnc.LoadVideo(filmDetail.Trailer, this.webView21);
        }
        private void webView21_Click(object sender, EventArgs e)
        {

        }
        private async void FilmDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var filmDetail = await _filmRepo.getFilmDetails(FilmId);
                WatchingFilm watchingFilmForm = new WatchingFilm(FilmId, filmDetail.Type);
                watchingFilmForm.Show();
            }
        }
    }
}
