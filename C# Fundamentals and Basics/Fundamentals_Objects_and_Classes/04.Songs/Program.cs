using System;
using System.Collections.Generic;

namespace _04.Songs
{
    class Song
    {
        ///Type list // Name // Duration
        public string TypeList { get; set; }
        public string Name { get; set; }

        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ///
            //3
            //favourite_DownTown_3: 14
            //favourite_Kiss_4: 16
            //favourite_Smooth Criminal_4:01
            //favourite

            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split('_');

                string typeList = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song();
                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string targetListType = Console.ReadLine();
            if (targetListType == "all")
            {
                for (int i = 0; i < songs.Count; i++)
                {
                    Console.WriteLine(songs[i].Name);
                }
            }
            else
            {
                for (int i = 0; i < songs.Count; i++)
                {
                    if (songs[i].TypeList == targetListType)
                    {
                        Console.WriteLine(songs[i].Name);
                    }
                }
                ///2nd example
                //songs = songs.FindAll(x => x.TypeList == targetListType);
                //foreach (var currSong in songs)
                //{
                //    Console.WriteLine(currSong.Name);
                //}
            }

        }
    }
}
