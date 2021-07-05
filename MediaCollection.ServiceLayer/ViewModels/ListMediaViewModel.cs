using MediaCollection.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Mvc;

namespace MediaCollection.ServiceLayer.ViewModels
{
    public class ListMediaViewModel
    {
        public int Id { get; set; }
        public string PosterUrl { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string Genre { get; set; }
        public string Descriminator { get; set; }
    }
}
