using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "demirağ";
            musteri1.TcNo = "21312321";


            // Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.SirketAdi = "kodlama io";
            musteri2.MusteriNo = "q2123123";
            musteri2.VergiNo = "23123123";


            Musteri musteri3 = new GercekMusteri(); ;
            Musteri musteri4 = new TuzelMusteri();

            MusterıManager musterıManager = new MusterıManager();
            musterıManager.Ekle(musteri1);
            musterıManager.Ekle(musteri2);

        }
    }
}
