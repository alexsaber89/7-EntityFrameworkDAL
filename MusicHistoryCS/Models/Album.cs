using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicHistoryCS.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public ICollection<Artist> Artists { get; set; }
    }
}