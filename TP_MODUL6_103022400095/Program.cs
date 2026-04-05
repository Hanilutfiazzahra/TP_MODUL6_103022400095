using TP_MODUL6_103022400095;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TUGAS PENDAHULUAN MODUL 6 KONSTRUKSI PERANGKAT LUNAK");

        SayaMusikTracks track1 = new SayaMusikTracks("Bermekaran dan Mewangi - Pendarra");
        track1.IncreasePlayCount(100);
        track1.PrintTrackDetails();

    }
}
