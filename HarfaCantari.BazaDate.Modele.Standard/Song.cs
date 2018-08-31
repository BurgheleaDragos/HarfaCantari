using System;
using System.Collections.Generic;

namespace HarfaCantari.BazaDate.Modele.Standard
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Lyrics { get; set; }
        public List<string> Chorus { get; set; }
        public bool Favorite { get; set; }
        public List<string> Type { get; set; }
    }

}
