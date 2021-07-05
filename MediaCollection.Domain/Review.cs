using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollection.Domain
{
    public class Review
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int rating { get; set; }
        public string Comment { get; set; }
        public Media Media { get; set; }
        public int MediaId { get; set; }

    }
}
