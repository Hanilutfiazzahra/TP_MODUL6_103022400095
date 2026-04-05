using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            Debug.Assert(title != null, "Title tidak boleh null");
            Debug.Assert(title.Length <= 100, "Title maksimal 100 karakter");
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Maksimal 10 juta");

            try
            {
                int current = int.Parse(playCount);

                checked
                {
                    current += count;
                }

                playCount = current.ToString();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow!");
            }
        }
        

        public void PrintTrackDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
