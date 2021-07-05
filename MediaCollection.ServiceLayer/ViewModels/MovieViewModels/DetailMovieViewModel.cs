using MediaCollection.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollection.ServiceLayer.ViewModels.MovieViewModels
{
    public class DetailMovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string Country { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Genres { get; set; }
    }
}
