using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAndUserControl.Model;

namespace WindowsAndUserControl.DataAccess.Services
{
    public class MoviesRepo : IMoviesRepo
    {
        public ObservableCollection<Movies> GetAllMovies()
        {
            ObservableCollection<Movies> movies = new ObservableCollection<Movies>();

            using (var context = new MasterMovieDbContext())
            {
                var query = context.GetAllMovies().ToList();

                foreach (var item in query)
                {
                    Movies movie = new Movies();
                    movie.Id = item.Id;
                    movie.Name = item.Name;
                    movie.DateReleased = item.DateReleased;
                    movie.GenreId = item.GenreId;

                    movies.Add(movie);
                }
                return movies;
            }
        }

        public Movies GetMovieById(int id)
        {
            using (var db = new MasterMovieDbContext())
            {
                
                var query = db.Movies1.Where(c => c.Id.Equals(id)).FirstOrDefault();
                Movies movie = new Movies
                {
                    Id = query.Id,
                    Name = query.Name,
                    DateReleased = query.DateReleased,
                    GenreId = query.GenreId
                };

                return movie;
            }
        }
    }
}
