using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WindowsAndUserControl.DataAccess.Services;
using WindowsAndUserControl.Model;

namespace WindowAndUserControlWPF.UI.UserControls
{
    public class MovieListViewModel : INotifyPropertyChanged
    {
        private IMoviesRepo _repo = new MoviesRepo();

        public MovieListViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject())) return;
            Movies = _repo.GetAllMovies();
        }
        public ObservableCollection<Movies> Movies { get; set; }

        private Movies _movie;

        public Movies Movie
        {
            get { return _movie; }
            set
            { _movie = value;
              NotifyPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
