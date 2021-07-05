using MediaCollection.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollection.Domain
{
    public class Music: Media
    {
        
       
        public string Lyrics { get; set; }
        //public List<Person> Producers { get; set; }
        //public List<Person> Writers { get; set; }
    }
}
