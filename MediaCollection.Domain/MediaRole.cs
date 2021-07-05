using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollection.Domain
{
    public class MediaRole
    {
        public int Id { get; set; }
        public string Role { get; set; }
        
        public Media Media { get; set; }
        public int MediaId { get; set; }
        public List<Person> Persons { get; set; }

    }
}
