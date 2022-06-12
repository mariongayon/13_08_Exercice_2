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
            

            SongData.Select(x => x[19]).GroupBy(
                x => x,
                x => x,
                (year, _) => new Tuple<string, int>
                    (year,
                    year.Count()
                    )
                ).OrderBy(x => x.Item1).Select(x =>
                    {
                        Console.WriteLine(x.Item1);
                        return x;
                    }
                ).ToList();
            
        }
    }
}
;