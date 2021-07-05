using MediaCollection.Domain;
using MediaCollection.Domain.Enums;
using MediaCollection.Repository;
using MediaCollection.ServiceLayer.ViewModels;
using MediaCollection.ServiceLayer.ViewModels.MovieViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace MediaCollection.ServiceLayer
{
    public class MovieService
    {
        private readonly ApplicationDbContext _appDbCtx;
        public MovieService(ApplicationDbContext appDbCtx)
        {
            _appDbCtx = appDbCtx ?? throw new ArgumentNullException(nameof(appDbCtx));
        }

        public DetailMovieViewModel GetMovie(int id)
        {
            
            var movie = _appDbCtx.Movies
                //.Include(mg => mg.MediaGenres)
                //.ThenInclude(g => g.Genre)
                .FirstOrDefault(m => m.Id == id);

            var dvm = new DetailMovieViewModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                Length = movie.Length,
                Country = movie.Country,
                ReleaseDate = movie.ReleaseDate,
                Url = movie.Url,
                Genres = movie.Genre
            };

            return dvm;
        }
        public AddMovieViewModel GetMovieGenres()
        {
            AddMovieViewModel vm = new AddMovieViewModel();
            vm.ReleaseDate = DateTime.Now;

            vm.Genres = new SelectList(_appDbCtx.MovieGenres.Select(g => g.Name).ToList());
            //vm.Genres = movieGenres.Select(g => new System.Web.Mvc.SelectListItem() { Value = g.Id.ToString(), Text = g.Name }).ToList();

            return vm;
        }

        public void AddMovie(AddMovieViewModel addMovieViewModel)
        {
            Movie movie = new Movie()
            {
                Title = addMovieViewModel.Title,
                Length = addMovieViewModel.Length,
                Country = addMovieViewModel.Country,
                ReleaseDate = addMovieViewModel.ReleaseDate,
                Url = addMovieViewModel.Url,
                Description = addMovieViewModel.Description
                //Genre = addMovieViewModel.SelectedGenres
                
            };

            var movieGenres = "";
            foreach (var selectedGenre in addMovieViewModel.SelectedGenres)
            {
                movieGenres = movieGenres + selectedGenre + ", ";
            }
            movie.Genre = movieGenres;
            
            _appDbCtx.Movies.Add(movie);
            _appDbCtx.SaveChanges();
        }
        public void UpdateMovie(int id,AddMovieViewModel addMovieViewModel)
        {
            Movie movie = _appDbCtx.Movies.Find(id);
            movie.Title = addMovieViewModel.Title;
            movie.Length = addMovieViewModel.Length;
            movie.Country = addMovieViewModel.Country;
            movie.ReleaseDate = addMovieViewModel.ReleaseDate;
            movie.Url = addMovieViewModel.Url;
            movie.Description = addMovieViewModel.Description;

            var movieGenres = "";
            //new List<MediaGenre>();
            foreach (var selectedGenre in addMovieViewModel.SelectedGenres)
            {
                //movieGenres.Add(new MediaGenre() { GenreId = selectedGenre });
                //Convert.ToInt32(selectedGenre.Value), Name = selectedGenre.Text });
                movieGenres = movieGenres + selectedGenre + ", ";
            }

            movie.Genre = movieGenres;

            _appDbCtx.Movies.Update(movie);
            _appDbCtx.SaveChanges();
        }
        public bool DeleteMovie(int id)
        {
            Movie movie = _appDbCtx.Movies.Find(id);
            if (movie == null)
            {
                return false;
            }
            else
            { 
                _appDbCtx.Movies.Remove(movie);
                _appDbCtx.SaveChanges();
                return true;
            }
        }
        public DeleteMovieViewModel GetMovieToDelete(int id)
        {
            Movie movie = _appDbCtx.Movies.Find(id);
            
            var dvm = new DeleteMovieViewModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                Url = movie.Url,
            };

            return dvm;
        }
    }

    //public IEnumerable<Genre> GetEnumGenre()
    //{
    //    return Enum.GetValues(typeof(Genre)).Cast<Genre>().ToList();

    //    //    Select(v => new List<Genre>
    //    //{
    //    //    Text = v.ToString()
    //    //}).ToList();
    //}
}
