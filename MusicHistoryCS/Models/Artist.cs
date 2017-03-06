using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicHistoryCS.Models
{
    public class Artist
    {
        [Key]
        public int ArtistID { get; set; }

        public string Name { get; set; }

        public int MyProperty { get; set; }

        public ICollection<Artist> Artists { get; set; }
    }
}