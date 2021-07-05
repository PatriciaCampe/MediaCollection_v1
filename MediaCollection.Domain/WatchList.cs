using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollection.Domain
{
    public class WatchList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<Media> MediaList { get; set; }
    }
}
