using Laboratory_work.Classes;
using System;

namespace Laboratory_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 10.1
            Console.WriteLine("Упражнение 10.1");
            Console.WriteLine("Создать класс и конструктор для кодировки строки");
            ACipher line = new ACipher("Упражнение");
            line.Encode();
            Console.WriteLine(line.OutputaLine);
        }
    }
}
