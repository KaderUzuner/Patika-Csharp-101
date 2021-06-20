using System;

namespace Kolesiyonlar_Ödev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write(i + 1 + ". sayıyı giriniz: ");
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            Array.Sort(numbers);

            int smallestTotal = 0;
            for (int i = 0; i < 3; i++)
            {
                smallestTotal += numbers[i];
            }

            int biggestTotal = 0;
            for (int i = numbers.Length - 1; i > numbers.Length - 4; i--)
            {
                biggestTotal += numbers[i];
            }

            float smallestAvg = (float)smallestTotal / 3;
            float biggestAvg = (float)biggestTotal / 3;
            Console.WriteLine("En küçük 3 sayının ortalaması = {0} En büyük 3 sayının ortalaması = {1} Ortalama toplamları = {2}", smallestAvg, biggestAvg, smallestAvg + biggestAvg);
        }
    }
}
