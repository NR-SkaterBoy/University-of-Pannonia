using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAudio7_kozos
{
    internal class Cassette : IAudio
    {
        public string Title { get; }
        public int NumberOfSides { get; }

        public Cassette(string title, int numberOfSides)
        {
            this.Title = title;
            this.NumberOfSides = numberOfSides;
        }

        public void Play()
        {
            Console.WriteLine($"Playback: {this.Title}, {this.NumberOfSides}");
        }
    }
}
