using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList oddNumbers = new ArrayList();
            ArrayList evenNumbers = new ArrayList();
            int numbersCount = 20;

            for (int i = 0; i < numbersCount; i++)
            {

                Console.WriteLine("Please Type a number");
                int number;

            giveInput:
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong Input !! Please Type a number");
                    goto giveInput;
                }
                Console.WriteLine(number);
                if (number < 0)
                {
                    Console.WriteLine("Wrong Input !! Please Type a number");
                    goto giveInput;
                }

                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
                else oddNumbers.Add(number);

            }
            Console.WriteLine();
            oddNumbers.Sort();
            oddNumbers.Reverse();
            evenNumbers.Sort();
            evenNumbers.Reverse();
            foreach (var item in oddNumbers)
            {
                Console.WriteLine(item);
            }
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n OddNumbersCount: "+oddNumbers.Count+"\n Even Numbers Count: "+evenNumbers.Count);
            int totalValueOfOdds = 0;
            int totalValueOfEvens = 0;
            for (int i = 0; i < oddNumbers.Count; i++)
            {
                totalValueOfOdds += Convert.ToInt32(oddNumbers[i]);
            }
            Console.WriteLine("Avarage Of Odd Numbers "+totalValueOfOdds/oddNumbers.Count);
            for (int i = 0; i < evenNumbers.Count; i++)
            {
                totalValueOfEvens += Convert.ToInt32(evenNumbers[i]);
            }
            Console.WriteLine("Avarage Of Even Numbers " + totalValueOfEvens / evenNumbers.Count);
        }
    }
}
