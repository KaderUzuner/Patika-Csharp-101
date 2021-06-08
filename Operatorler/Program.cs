using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atama ve işlemli atama operatörleri \n");
            int x = 3;
            int y = 3;

            y = y + 2;
            Console.WriteLine(y);

            y += 2;
            Console.WriteLine(y);

            y /= 1;
            Console.WriteLine(y);

            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("\n***** Mantıksal operatörler *****\n");
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("perfect!");
            }

            if (isSuccess || isCompleted)
            {
                Console.WriteLine("great!");
            }

            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("fine!");
            }

            Console.WriteLine("\n***** İlişkisel operatörler *****\n");
            int a = 3;
            int b = 4;

            bool sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("\n***** Aritmek operatörler *****\n");
            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);
        }
    }
}
