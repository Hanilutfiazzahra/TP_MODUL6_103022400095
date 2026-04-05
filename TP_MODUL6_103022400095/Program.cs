using TP_MODUL6_103022400095;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TUGAS PENDAHULUAN MODUL 6 KONSTRUKSI PERANGKAT LUNAK");

        SayaMusikTracks track1 = new SayaMusikTracks("Bermekaran dan Mewangi - Pendarra");
        track1.IncreasePlayCount(100);
        track1.PrintTrackDetails();

        SayaMusikTracks track2 = new SayaMusikTracks("Di Sudut Purnama - Pendarra");
        for (int i = 0; i < 300; i++)
        {
            track2.IncreasePlayCount(10000000);
        }

        track2.PrintTrackDetails();

    }
}
