using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_2_2MX.Entities;

namespace Week_2_2MX.Services
{
    internal class NotepadService
    {
        public void WriteToNotepad(Playlist playlist)
        {
            string directory = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\Playlists";

            //if there is no directory 
            if (!File.Exists(directory))
                Directory.CreateDirectory(directory);


            string saveFile = Path.Combine(directory, $"{playlist.Id}.txt");//decide to name of the file which I saved

            File.WriteAllText(saveFile, playlist.GetSongs());
            Console.WriteLine("Data Successfully Saved to Notepad!");
        }
    }
}
