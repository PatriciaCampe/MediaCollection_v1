using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollection.Domain
{
    public abstract class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public ICollection<MediaGenre> MediaGenre { get; set; }
    }
}
