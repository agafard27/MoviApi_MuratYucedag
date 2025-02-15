using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviApiDomein.Entities
{
    public class Movie
    {
        
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string CoverImageUrl { get; set; }
        public Decimal Rating { get; set; }
        public string Desciription { get; set; }
        public int Duration { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        public String CreatedYear { get; set; }
        public bool Status { get; set; }

    }
}
