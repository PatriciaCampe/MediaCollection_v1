using MediaCollection.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollection.Domain
{
    public class Serie : Media
    {
        public string Description { get; set; }
        //public List<MediaFunction> SerieFunctions { get; set; }
        //public List<Person> Actors { get; set; }
        //public List<Person> Producers { get; set; }
        //public List<Person> Directors { get; set; }
        //public List<Person> Writers { get; set; }
       
        public int AmountSeasons { get; set; }
        public List<Episode> Episodes { get; set; }
    }
}
