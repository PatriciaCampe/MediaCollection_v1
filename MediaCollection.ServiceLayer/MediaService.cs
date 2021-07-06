using MediaCollection.Domain;
using MediaCollection.Repository;
using MediaCollection.ServiceLayer.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MediaCollection.ServiceLayer
{
    public class MediaService
    {
        private readonly ApplicationDbContext _appDbCtx;
        public MediaService(ApplicationDbContext appDbCtx)
        {
            _appDbCtx = appDbCtx ?? throw new ArgumentNullException(nameof(appDbCtx));                
        }
        //----------------------------------------------------------------------------//
        // Search all Media on title and sort on title                                //
        //----------------------------------------------------------------------------//
        public ListMediaGenreViewModel SearchMediaOnTitle(string searchString)
        {
            var media = _appDbCtx.Media.Where(t => t.Title.Contains(searchString)).OrderBy(_ => _.Title).ToList();
            return ConvertMedia2View(media);
        }
 
        //----------------------------------------------------------------------------//
        // Search all Media on Genre and sort on title                                //
        //----------------------------------------------------------------------------//
        public ListMediaGenreViewModel SearchMediaOnGenre(string mediaGenre)
        {
            var media = _appDbCtx.Media.Where(t => t.Genre == mediaGenre).OrderBy(_ => _.Title).ToList();
            return ConvertMedia2View(media);
        }
        //----------------------------------------------------------------------------//
        // Select  all Media and sort on title                                        //
        //----------------------------------------------------------------------------//
        public ListMediaGenreViewModel ListMedia()
        {
            var media = _appDbCtx.Media.OrderBy(_ => _.Title).ToList();
            return ConvertMedia2View(media);
        }
 
        //----------------------------------------------------------------------------//
        // Convert Media to MediaViewModel                                            //
        //----------------------------------------------------------------------------//
        public ListMediaGenreViewModel ConvertMedia2View(List<Media> media)
        {
            List<ListMediaViewModel> mediaViewList = new List<ListMediaViewModel>();
            foreach (var mediaItem in media)
            {
                ListMediaViewModel mediaView = new ListMediaViewModel()
                {
                    Id = mediaItem.Id,
                    PosterUrl = mediaItem.Url,
                    Title = mediaItem.Title,
                    Country = mediaItem.Country,
                    Genre = mediaItem.Genre,
                    Descriminator = mediaItem.GetType().Name
                };
                mediaViewList.Add(mediaView);
            }

            var mediaGenreVM = new ListMediaGenreViewModel
            {
                Genres = new SelectList(_appDbCtx.Media.Select(_ => _.Genre).Distinct().ToList()),
                ListMediaViewModels = mediaViewList
            };

            return mediaGenreVM;
        }

        //----------------------------------------------------------------------------//
        // Select  all Media of type MOVIE and sort on title                          //
        //----------------------------------------------------------------------------//
        public List<ListMediaViewModel> ListMovies()
        {
            List<Movie> movies = _appDbCtx.Media.OfType<Movie>().ToList();

            List<ListMediaViewModel> movieList = new List<ListMediaViewModel>();
            foreach (var movie in movies)
            {
                    ListMediaViewModel movieListItem = new ListMediaViewModel()
                    {
                        Id = movie.Id,
                        PosterUrl = movie.Url,
                        Title = movie.Title,
                        Country = movie.Country,
                        Genre = movie.Genre,
                        Descriminator = movie.GetType().Name
                    };
                    movieList.Add(movieListItem);
            }

            return movieList;
        }
        public List<ListMediaViewModel> ListSeries()
        {
            var series = _appDbCtx.Media.OfType<Serie>().ToList();
            List<ListMediaViewModel> serieList = new List<ListMediaViewModel>();
            foreach (var serie in series)
            {
                     ListMediaViewModel serieListItem = new ListMediaViewModel()
                    {
                        Id = serie.Id,
                        PosterUrl = serie.Url,
                        Title = serie.Title,
                        Country = serie.Country,
                        Genre = serie.Genre,
                        Descriminator = serie.GetType().Name
                    };
                    serieList.Add(serieListItem);
            }
            return serieList;
        }

        public List<ListMediaViewModel> ListMusic()
        {
            var music = _appDbCtx.Media.OfType<Music>().ToList();
            List<ListMediaViewModel> musicList = new List<ListMediaViewModel>();
            foreach (var musicItem in music)
            {
                   ListMediaViewModel musicListItem = new ListMediaViewModel()
                    {
                        Id = musicItem.Id,
                        PosterUrl = musicItem.Url,
                        Title = musicItem.Title,
                        Country = musicItem.Country,
                        Genre = musicItem.Genre,
                        Descriminator = musicItem.GetType().Name
                    };
                    musicList.Add(musicListItem);
            }
            return musicList;
        }
        public List<ListMediaViewModel> ListPodcasts()
        {
            var podcasts = _appDbCtx.Media.OfType<Podcast>().ToList();
            List<ListMediaViewModel> podcastList = new List<ListMediaViewModel>();
            foreach (var podcast in podcasts)
            {
                ListMediaViewModel podcastListItem = new ListMediaViewModel()
                {
                    Id = podcast.Id,
                    PosterUrl = podcast.Url,
                    Title = podcast.Title,
                    Country = podcast.Country,
                    Genre = podcast.Genre,
                    Descriminator = podcast.GetType().Name
                };
                podcastList.Add(podcastListItem);
            }
            return podcastList;
        }
    }
}

