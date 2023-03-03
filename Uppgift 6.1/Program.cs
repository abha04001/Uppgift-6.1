using System;
namespace Uppgift_6._1
{
    class program
    {
        static void Main(string[]args)
        {
            Addera (2, 3, 5);
            Console.WriteLine("summan är " + Addera(2, 3, 5));
        }
        static int Addera(int tal1, int tal2, int tal3)
        {
           
            return tal1 + tal2 + tal3;
        }
    }
}