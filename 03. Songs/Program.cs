using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read the input lines, make a collection and store the data.
            int numSongs = int.Parse(Console.ReadLine()); 
            List<Song> songs = new List<Song>();
            for (int i = 0; i < numSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");
                string type = data[0];
                string name = data[1];
                string time = data[2];
                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;
                songs.Add(song);
            }
            //Finally read your last line – Type List and print the result.
            string typeOfList = Console.ReadLine();
            if (typeOfList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeOfList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
