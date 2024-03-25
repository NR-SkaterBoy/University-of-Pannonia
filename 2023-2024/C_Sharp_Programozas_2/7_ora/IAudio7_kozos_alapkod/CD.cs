using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAudio7_kozos
{
    internal class CD : IAudio
    {
        public string Title { get; }
        public int Length { get; }

        public CD(string title, int length)
        {
            this.Title = title;
            this.Length = length;
        }

        public void Play()
        {
            Console.WriteLine($"Playback: {this.Title}, {this.Length}");
        }
    }
}
