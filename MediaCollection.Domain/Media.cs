using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollection.Domain
{
    public abstract class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string Country { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Url { get; set; }
        public string Genre { get; set; }
        //public ICollection<MediaGenre> MediaGenres { get; set; }
        public ICollection<MediaRole> MediaRoles { get; set; }
        public List<Review> Reviews { get; set; }
        
    }
}
