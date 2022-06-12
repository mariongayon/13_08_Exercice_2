using System;
using System.IO;
using System.Linq;

namespace Songs
{

    class Program
    {
        static void Main(string[] args)
        {
            var fichier = File.ReadAllLines(@"C:\Users\Administrateur\source\repos\13_06_Exercice_2\Songs\SongCSV.csv");

            var SongData = fichier.Skip(1).Select(x => x.Split(',')).ToList();

            // number of songs by year
            var SongByYear = SongData.Select(x => x[17]).GroupBy(
                x => x,
                x => x,
                (year, x) => new Tuple<string, int>
                    (year,
                    x.Count()
                    )
                ).OrderBy(x => x.Item2).Reverse().Skip(1).Select(x =>
                    {
                        Console.WriteLine(x.Item1 + ":" + x.Item2);
                        return x;
                    }
                ).ToList();

            // Year with more songs but I didn't find how to select the year and then the number of song
            Console.WriteLine($"The year with more musics is { SongByYear.First()}");

            // number of albums by year
            
        }
    }
}
;