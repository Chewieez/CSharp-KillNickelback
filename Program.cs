using System;
using System.Collections.Generic;
using System.Linq;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {

            List<(string, string)> goodSongs = new List<(string, string)>();
            
            HashSet<(string, string)> allSongs = new HashSet<(string, string)>();
            
            allSongs.Add(("Asheville Turnaround", "Del McCoury Band"));
            allSongs.Add(("Gamma Ray", "Beck"));
            allSongs.Add(("Photograph", "Nickleback"));
            allSongs.Add(("Rockstar", "Nickleback"));
            allSongs.Add(("Too Bad", "Nickleback"));
            allSongs.Add(("Resurection Fern", "Iron & Wine"));
            allSongs.Add(("Cannot Contain This", "Moloko"));
                
            
            
            foreach ((string, string) song in allSongs) {
                if (song.Item2 != "Nickleback") {
                    goodSongs.Add(song);
                }
            }

            foreach ((string, string) song in goodSongs) {
                Console.WriteLine(song.Item1 + " " + song.Item2);
            }

            


        }
    }
}
