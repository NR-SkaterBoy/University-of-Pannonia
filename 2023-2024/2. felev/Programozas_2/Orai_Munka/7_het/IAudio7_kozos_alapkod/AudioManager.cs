using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAudio7_kozos
{
    internal class AudioManager
    {
        private List<IAudio> audios = new List<IAudio>();

        public List<IAudio> Audios { get { return audios; } }

        public void AddAudio(IAudio audio)
        {
            audios.Add(audio);
        }

        public void PlayAudio()
        {
            foreach (IAudio audio in audios)
            {
                audio.Play();
            }
        }

        public void Countdown()
        {

        }
    }
}
