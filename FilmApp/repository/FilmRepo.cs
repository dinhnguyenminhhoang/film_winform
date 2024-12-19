using FilmApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApp.repository
{
    public class FilmRepo
    {
        public async Task<List<Films>> GetFilmHot()
        {
            FilmDBEntities context = new FilmDBEntities();
            var hotFilms = await context.Films
                                        .OrderByDescending(f => f.Viewed)
                                        .Take(6)
                                        .ToListAsync();
            return hotFilms;
        }

        public async Task<List<Films>> GetFilmStatus(string status)
        {
            FilmDBEntities context = new FilmDBEntities();
            var statusFilms = await context.Films
                                        .Where(f => f.Status == status)
                                        .Take(6)
                                        .OrderByDescending(f => f.Viewed)
                                        .ToListAsync();
            return statusFilms;
        }
        public async Task<List<Films>> GetAllFilms(int pageNumber, int pageSize)
        {
            using (FilmDBEntities context = new FilmDBEntities())
            {
                var allFilms = await context.Films
                                            .OrderBy(f => f.Id) 
                                            .Skip((pageNumber - 1) * pageSize) 
                                            .Take(pageSize) 
                                            .ToListAsync();
                return allFilms;
            }
        }
        public async Task<int> GetFilmCount()
        {
            using (FilmDBEntities context = new FilmDBEntities())
            {
                var filmCount = await context.Films.CountAsync(); 
                return filmCount;
            }
        }

    }
}
