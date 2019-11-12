using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAndUserControl.Model
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateReleased { get; set; }
        public int GenreId { get; set; }

    }
}
