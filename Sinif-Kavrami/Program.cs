using System;

namespace Sinif_Kavrami
{
    class Program
    {
        //Erişim belirleyici
        //*Public : Her yerden erişilebilir.
        //*Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
        //*Internal : Sadece bulunduğu proje içerisinden erişilebilir
        //*Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 23415634;
            calisan1.Departman = "İnsan Kaynakları";

            calisan1.CalisanBiglileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 25646789;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBiglileri();
        }
        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public void CalisanBiglileri()
            {
                Console.WriteLine("Çalışan Adı: {0}", Ad);
                Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
                Console.WriteLine("Çalışan Numarası: {0}", No);
                Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
            }
        }
    }
}
