using MediaCollection.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollection.Domain
{
    public class Podcast:Media
    {
        public string Description { get; set; }
        //public List<MediaFunction> PodcastFunctions { get; set; }
        //public List<Person> Hosts { get; set; }
        //public List<Person> Producers { get; set; }
        //public List<Person> Writers { get; set; }
       
    }
}
