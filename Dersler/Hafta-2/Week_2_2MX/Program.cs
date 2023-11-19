// See https://aka.ms/new-console-template for more information
using Week_2_2MX.Entities;
using Week_2_2MX.Services;

Console.WriteLine("Hello, World!");

var Song1 = new Song("Kısmetim kapanmış","Müslüm Gürses","Bilinmiyor","Bilinmiyor");
var Song2 = new Song("Requiem K. 626","W.A.","Fazıl Say","Warner Music");
var Song3 = new Song("Moonlight Sonata", "Ludwig van Beethoven", "Various Artist", "Classical Records");
var Song4 = new Song("The Four Seasons", "Antonio Vivaldi", "Chamber Orchestra", "Baroque Productions");


var playlist1= new Playlist(Song1);
playlist1.AddSong(Song2);
playlist1.AddSong(Song3);
playlist1.AddSong(Song4);

Console.WriteLine(playlist1.GetSongs());

Console.WriteLine("Before Shuffle : ");
Console.WriteLine(playlist1.GetSongs());

playlist1.ShuffleSongs();

Console.WriteLine("\n\nAfter Shuffle : ");
Console.WriteLine(playlist1.GetSongs());

NotepadService notepadService = new NotepadService();
notepadService.WriteToNotepad(playlist1);