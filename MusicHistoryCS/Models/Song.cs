using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicHistoryCS.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }

        public string Name { get; set; }

        public int Duration { get; set; }

        public int MyProperty { get; set; }
    }
}