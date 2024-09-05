using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IAudio7_kozos
{
    internal class FileHandling
    {
        public static void Save(string filename, List<IAudio> audios)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (IAudio audio in audios)
                {
                    if (audio is CD)
                    {
                        CD cd = (CD)audio;
                        sw.WriteLine($"cd;{cd.Title};{cd.Length}");
                    } else if (audio is Cassette)
                    {
                        Cassette cassette = (Cassette)audio;
                        sw.WriteLine($"cassette;{cassette.Title};{cassette.NumberOfSides}");
                    }
                }
            }
        }

        public static List<IAudio> Load(string filename)
        {
            List<IAudio> audios = new List<IAudio>();
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] parts = line.Split(';');
                    switch (parts[0])
                    {
                        case "cd":
                            CD cd = new CD(parts[1], int.Parse(parts[2]));
                            audios.Add(cd);
                            break;
                        default:
                            Cassette cas = new Cassette(parts[1], int.Parse(parts[2]));
                            audios.Add(cas);
                            break;
                    }
                    line = sr.ReadLine();
                }
            }
            return audios;
        }
    }
}
