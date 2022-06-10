using System;
using System.IO;
using System.Collections.Generic;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> symbols = new Queue<char>();
            Queue<char> digits = new Queue<char>();


            using (StreamReader sr = new StreamReader("C:\\Users\\Владислав\\Desktop\\uchebnaya_praktika\\18\\zad18\\zad2\\2.txt"))
            {

                while (!sr.EndOfStream)
                {

                    char s = (char)sr.Read();
                    if (char.IsDigit(s)) digits.Enqueue(s);
                    else symbols.Enqueue(s);

                }

            }

            Console.WriteLine(string.Join("", symbols) + string.Join("", digits));
        }
    }
}
