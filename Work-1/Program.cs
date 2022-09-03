using System;

namespace Work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool over = true;
            while (over != false)
            {
                WhileForInfinity();
            }
           
        }
        static void WhileForInfinity()
        {
            Console.WriteLine("Etmek istediyiniz emeliyyati daxil edin )");
            Console.WriteLine("1 - Sozdeki herfin sira nomresin tapmaq :");
            Console.WriteLine("2 - En yaxin kvadrat koku tapmaq :");
            Console.WriteLine("3 - Array'deki menfi edeleri  musbete cevirmek :");
            Console.WriteLine("4 - Verilmis sozde reqem olub olmadigini yoxlayan program :");
            string cho = Console.ReadLine();
            int choice = int.Parse(cho);
            switch (choice)
            {
                case 1:
                    Letters();
                    break;
                case 2:
                    SquareRoot();
                    break;
                case 3:
                    ArrayElements();
                    break;
                case 4:
                    NumberSearchInString();
                    break;
                default:
                    break;
            }

        }   
        static void Letters()
        {

            Console.WriteLine("Sozu daxil edin :");
            string Word = Console.ReadLine();
            Console.WriteLine("Axtardiginiz herfi daxil edin :");
            string WordLetter = Console.ReadLine();
            char Letter = char.Parse(WordLetter);

            char[] ArryForString = new char[Word.Length];

            for (int i = 0; i < Word.Length; i++)
            {
                ArryForString[i] = Word[i];
            }
            int m = 1;
            int x = 0;
            while (m != 0)
            {
                for (int j = 0; j < Word.Length; j++)
                {
                    if (ArryForString[j] == Letter)
                    {
                        Console.WriteLine(j + 1 +"\n\n");

                        x++;
                        break;
                    }

                }
                break;
            }
            if (x == 0)
            {
                Console.WriteLine(-1 +"\n\n");
            }


        }
        static void SquareRoot()
        {
            Console.WriteLine("Ededi daxil edin :");
            string num = Console.ReadLine();
            double number = double.Parse(num);
            double root = Math.Sqrt(number);          
            //Bunu arasdirarken yeni oyrendim 
            int res = Convert.ToInt32(root);
            Console.WriteLine(num +" Ededine en yaxin kvadrat eded :");
            int Power = res * res;
            Console.WriteLine(res + " x " + res+" = "+Power +"\n\n");
           
        }
        static void ArrayElements()
        {
            int[] arry = new int[5];
            Console.WriteLine("Ededleri daxil edin :");
            for(int i = 0; i < arry.Length; i++)
            {
                String num = Console.ReadLine();
                int num1 = int.Parse(num);
                arry[i] = num1;
            }
            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] < 0)
                {
                    arry[i] = arry[i] * -1;
                }
            }
            Console.WriteLine("Arrayin yeni Hali :");
            foreach (int c in arry)
            {
                Console.WriteLine(c );
            }
            Console.WriteLine("\n\n");
        }
        static void NumberSearchInString()
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
                    m++;
                    break; 
                }

            }
            if (m == 0)
            {
                Console.WriteLine("Reqem yoxdur :\n\n");
            }

        }
    }
}
