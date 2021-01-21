using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici...";
            string kurs2 = "Programlamaya başlangıc";
            string kurs3 = "Java";
            string kurs4 = "Python";
            

            string[] kurslar = new string[] {kurs1,kurs2,kurs3,kurs4 };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti !");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
