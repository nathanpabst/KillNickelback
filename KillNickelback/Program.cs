using System;
using System.Collections.Generic;

namespace KillNickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();

            var allSongs = new HashSet<Song>();

            allSongs.Add(new Song("Lynyrd Skynard", "Simple Man"));
            allSongs.Add(new Song("Foghat", "Slow Ride"));
            allSongs.Add(new Song("Elton John", "Funeral for a Friend"));
            allSongs.Add(new Song("Father John Misty", "Now I'm Learning to Love the War"));
            allSongs.Add(new Song("Nickelback", "Photograph"));
            allSongs.Add(new Song("Nickelback", "How You Remind Me"));
            allSongs.Add(new Song("Nickelback", "Rockstar"));

            foreach (var song in allSongs)
            {

            }

        public class Song
        {
            public string Artist { get;  }
            public string Name { get; }
            public Song(string artist, string name)
            {
                Artist = artist;
                Name = name;
            }
        }




        }
    }
}
