//  www.patika.dev
using System;

namespace Proje
{
    class Program
    {
        static int Fibonacci(int number)
        {
            int first = 0;
            int second = 1;
            int left;
            int sum=0;
            for (int i = 1; i <= number; i++)
            {
                left = first+ second;
                first = second;
                second = left;
                sum += first; 
            }
            Console.WriteLine("Toplam : "+sum+" Ortalaması : "+sum/number);
            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Lütfen Derinlik giriniz : ");
            int deep=int.Parse(Console.ReadLine());
            Fibonacci(deep);
        }
    }
}