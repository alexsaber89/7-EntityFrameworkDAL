using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicHistoryCS.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }

        public string Name { get; set; }

        public ICollection<Artist> Artists { get; set; }
    }
}