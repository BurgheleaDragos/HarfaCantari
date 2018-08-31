using System;
using System.Collections.Generic;
using HarfaCantari.BazaDate.Modele.Standard;

namespace HarfaCantari.BazaDate.Standard
{
    public class Database : IDatabase
    {
        private Database _instance;

        public Database Instance => _instance ?? (_instance = new Database());

        public List<string> SongsList()
        {
            return new List<string>();
        }

        public Song Cantare(int id)
        {
            throw new NotImplementedException();
        }

        public bool AddSong(Song song)
        {
            throw new NotImplementedException();
        }

        public bool EditSong(Song song)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSong(Song song)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSong(int id)
        {
            throw new NotImplementedException();
        }

        public bool AddFavouriteSong(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFavouriteSong(int id)
        {
            throw new NotImplementedException();
        }
    }
}
