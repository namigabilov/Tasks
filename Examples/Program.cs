using System;

namespace vurmacedveli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sozu daxil edin :");
            string Word = Console.ReadLine();
            char[] ArryForString = new char[Word.Length];

            for (int i = 0; i < Word.Length; i++)
            {
                ArryForString[i] = Word[i];
            }
            int m = 0;
            for (int i = 0; i < Word.Length; i++)
            {
                if (char.IsDigit(ArryForString[i]))
                {
                    Console.WriteLine("Reqem daxildir :\n\n");
                    break;

                }
                m++;
            }
            if (m != 0)
            {
                Console.WriteLine("Reqem yoxdur :\n\n");
            }
        }
    }
}