using MediaCollection.ServiceLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Controllers
{
    public class PodcastController : Controller
    {
        private readonly MediaService _mediaService;
        //private readonly MovieService _movieService;
        //private readonly AddMovieViewModel _addMovieViewModel;

        public PodcastController(MediaService mediaService, MovieService movieService)
        {
            _mediaService = mediaService ?? throw new ArgumentNullException(nameof(MediaService));
        //    _movieService = movieService ?? throw new ArgumentNullException(nameof(MediaService));
        }

        // GET: PodcastController
        public ActionResult Index()
        {
            return View(_mediaService.ListPodcasts());
        }
    }
}
