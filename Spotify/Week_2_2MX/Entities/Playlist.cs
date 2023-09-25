using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_2MX.Entities
{
    internal class Playlist
    {
        public Guid Id { get; set; }
        private List<Song> Songs { get; set; }
        Random random;
        public Playlist(Song firstSong)
        {
            Songs = new List<Song>();
            random = new();
            AddSong(firstSong);
        }
        public void AddSong(Song song)
        {
            if (song != null)
            {
                Songs.Add(song);
            }
        }
        public string GetSongs()
        {
            //StringBuilder stringBuilder = new StringBuilder();
            //foreach (Song song in Songs) 
            //{ 
            //    stringBuilder.Append($"Title:{song.Title}-{song.Composer}")
            //}
            //return stringBuilder.ToString();
            return string.Join("\n", Songs.Select(songs => $"{songs.Title} - {songs.Composer}"));
        }
        public void ShuffleSongs()
        {
            int songCount = Songs.Count;

            while (songCount > 0)
            {
                songCount--;
                Song song = Songs[songCount];

                int random_index = random.Next(songCount);
                Songs[songCount] = Songs[random_index];//songCount = maxValue 
                Songs[random_index] = song;
            }
        }
    }
}   
