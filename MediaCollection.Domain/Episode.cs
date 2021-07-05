using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollection.Domain
{
    public class Episode
    {
        public int Id { get; set; }
        public int Season { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Serie Serie { get; set; }
        public int SerieId { get; set; }
    }
}
