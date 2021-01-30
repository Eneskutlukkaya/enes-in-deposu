using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1234 ;
            musteri1.Name = "Nicola Tesla";
            musteri1.Job = "Bilim insanı";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2345;
            musteri2.Name = "Albert Einstein";
            musteri2.Job = "Teorik Fizikçi";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 4321;
            musteri3.Name = "Bill Gates";
            musteri3.Job = "İş Adamı";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.add(musteri1);
            musteriManager.list(musteri2);
            musteriManager.delete(musteri3);


        }
    }
}
