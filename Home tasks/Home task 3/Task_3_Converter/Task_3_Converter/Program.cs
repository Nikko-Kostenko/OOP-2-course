using System;

namespace Task_3_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter Translate = new Converter(25,30);
            Console.WriteLine(Translate.ConvertEUR(100));
        }
    }
}
