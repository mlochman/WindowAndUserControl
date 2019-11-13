using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAndUserControl.Model;

namespace WindowsAndUserControl.DataAccess.Services
{
    public interface IMoviesRepo
    {
        ObservableCollection<Movies> GetAllMovies();

        Movies GetMovieById(int id);
    }
}
