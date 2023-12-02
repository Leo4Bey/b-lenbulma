using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Çarpanları bulunacak sayıyı girer misin: ");
            int sayi = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                if(sayi%i ==0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.Read();
        }
    }
}
