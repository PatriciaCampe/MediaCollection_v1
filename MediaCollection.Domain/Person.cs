using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollection.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public MediaRole MediaRole { get; set; }

        //public List<Media> MediaList { get; set; }
    }
}
