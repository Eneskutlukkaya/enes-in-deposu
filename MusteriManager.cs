using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public  void add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name+"eklendi");
           
        }
        public  void delete (Musteri musteri)
        {
            Console.WriteLine(musteri.Name+" silindi");
        }
        public  void list( Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri................................");
            Console.WriteLine( musteri.Id);
            Console.WriteLine(musteri.Name);
            Console.WriteLine(musteri.Job);
        }

    }
}
