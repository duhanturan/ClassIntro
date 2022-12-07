using System;

namespace ClassIntro
{
    class Kurs
    {
        string KursAdi;
        string Egitmen;
        int IzlenmeOrani;
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Duhan Turan";
            kurs1.IzlenmeOrani = 45;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Duhan Turan";
            kurs2.IzlenmeOrani = 25;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "Duhan Turan";
            kurs3.IzlenmeOrani = 55;

            Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);
            Console.WriteLine(kurs2.KursAdi + ":" + kurs2.Egitmen);
            Console.WriteLine(kurs3.KursAdi + ":" + kurs3.Egitmen);

        }
            

    }
}
