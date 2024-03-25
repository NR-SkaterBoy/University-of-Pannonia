using System;
using System.Collections.Generic;

namespace IAudio7_kozos
{  
    internal class Program
    {
        static void Print(List<IAudio> audios)
        {
            foreach (var audio in audios)
            {
                if (audio is CD)
                {
                    CD cd = (CD)audio;
                    Console.WriteLine($"Type: CD, Title: {cd.Title}, Length: {cd.Length}");
                }
                else if (audio is Cassette)
                {
                    Cassette cassette = (Cassette)audio;
                    Console.WriteLine($"Type: Cassette, Title: {cassette.Title}, Number of Sides: {cassette.NumberOfSides}");
                }
            }
        }

        static void Main(string[] args)
        {
            AudioManager audioManager = new AudioManager();

            // Testing adding CDs and cassettes to the AudioManager list
            audioManager.AddAudio(new CD("Favorites", 45));
            audioManager.AddAudio(new Cassette("Retro Hits", 60));

            Print(audioManager.Audios);
            Console.WriteLine();

            // Testing playback
            audioManager.PlayAudio();
            Console.WriteLine();

            // Testing file handling - save and load
            FileHandling.Save("audios.txt", audioManager.Audios);
            List<IAudio> loadedAudios = FileHandling.Load("audios.txt");
            foreach (var audio in loadedAudios)
            {
                audioManager.AddAudio(audio);
            }
            Console.WriteLine();
            Print(audioManager.Audios);
            Console.WriteLine();

            // Testing countdown
            audioManager.Countdown();
        }
    }
}