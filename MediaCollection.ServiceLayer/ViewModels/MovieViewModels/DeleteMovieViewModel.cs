using MediaCollection.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollection.ServiceLayer.ViewModels.MovieViewModels
{
    public class DeleteMovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
         public string Url { get; set; }
 
    }
}
