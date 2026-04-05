using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL6_103022400095
{
    internal class SayaMusikTracks
    {
        private int id;
        private string playCount;
        private string title;

        public SayaMusikTracks(string title)
        {
            this.title = title;
            this.playCount = "0";
            Random random = new Random();
            this.id = random.Next(10000, 99999);
        }

        public void IncreasePlayCount(int count)
        {
            playCount = (int.Parse(playCount) + count).ToString();
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
