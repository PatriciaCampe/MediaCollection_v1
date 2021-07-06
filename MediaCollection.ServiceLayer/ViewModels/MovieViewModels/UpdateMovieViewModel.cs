using MediaCollection.Domain;
using MediaCollection.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MediaCollection.ServiceLayer.ViewModels.MovieViewModels
{
    public class UpdateMovieViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A movie title is required")]
        [StringLength(50)]
        public string Title { get; set; }

        [DisplayName("Duration in minutes")]
        public int Length { get; set; }
        public string Country { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [DisplayName("Movie Poster URL")]
        public string Url { get; set; }

        public string Description { get; set; }
        public string ExistingGenres { get; set; }
        public SelectList Genres { get; set; } 
        public List<string> SelectedGenres { get; set; }
    }
    
}
