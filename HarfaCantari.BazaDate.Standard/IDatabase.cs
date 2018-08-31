using HarfaCantari.BazaDate.Modele.Standard;
using System.Collections.Generic;

namespace HarfaCantari.BazaDate.Standard
{
    public interface IDatabase
    {
        Database Instance { get; }
        #region List
        List<string> SongsList();
        Song Cantare(int id);
        #endregion List

        bool AddSong(Song song);
        bool EditSong(Song song);
        bool DeleteSong(Song song);
        bool DeleteSong(int id);

        bool AddFavouriteSong(int id);
        bool DeleteFavouriteSong(int id);
    }
}