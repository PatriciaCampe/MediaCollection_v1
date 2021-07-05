using MediaCollection.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MediaCollection.ServiceLayer.ViewModels
{
    public class ListMediaGenreViewModel
    {
        public List<ListMediaViewModel> ListMediaViewModels { get; set; }
        public SelectList Genres { get; set; }
        public string MediaGenre { get; set; }
        public string SearchTitle { get; set; }
    }
}
