using System;

namespace lab1ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Scrieti un program care interschimba valoarea a doua variabile intregi.
             */

            int a;
            int b;

            Console.WriteLine("Introduceti primul numar: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea: ");
            b = int.Parse(Console.ReadLine());
            (a, b) = (b, a);
           
            Console.WriteLine("a={0} b={1}",a,b );
        }
    }
}
