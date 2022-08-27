using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int[] bigNumbers = new int[3];
            int[] smallNumbers = new int[3];
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
                numbers[i] = number;
            }
            int biggest=0;
            int bigAvarage = 0;
            int bigSmallest = 0;
            foreach (var number in numbers)
            {
                if (number>=biggest)
                {
                    biggest = number;
                }
            }
            foreach (var number in numbers)
            {
                if (number >= bigAvarage && number<biggest)
                {
                    bigAvarage = number;
                }
            }
            foreach (var number in numbers)
            {
                if (number >= bigSmallest && number < biggest && number < bigAvarage)
                {
                    bigSmallest = number;
                }
            }
            Console.WriteLine(bigSmallest);
            bigNumbers[0] = biggest;
            bigNumbers[1] = bigAvarage;
            bigNumbers[2] = bigSmallest;
            Console.WriteLine();
            foreach (var item in bigNumbers)
            {
                Console.WriteLine(item);
            }

            int smallest = int.MaxValue;
            int smallAvarage = int.MaxValue;
            int smallBiggest = int.MaxValue;
            foreach (var number in numbers)
            {
                if (smallest>number)
                {
                    smallest = number;
                }
            }
            foreach (var number in numbers)
            {
                if (smallAvarage > number && number > smallest)
                {
                    smallAvarage = number;
                }
            }
            foreach (var number in numbers)
            {
                if (smallBiggest > number && number > smallest && number > smallAvarage)
                {
                    smallBiggest = number;
                }
            }

            smallNumbers[0] = smallest;
            smallNumbers[1] = smallAvarage;
            smallNumbers[2] = smallBiggest;

            Console.WriteLine();
            foreach (var item in smallNumbers)
            {
                Console.WriteLine(item);
            }
            int totalOfBiggest = 0;
            foreach (var item in bigNumbers)
            {
                totalOfBiggest += item;
            }
            int avarageOfBiggestNumbers = totalOfBiggest / bigNumbers.Length;
            Console.WriteLine("The Avarage Of 3 Biggest Numbers: "+avarageOfBiggestNumbers);
            int totalOfSmallest = 0;
            foreach (var item in smallNumbers)
            {
                totalOfSmallest += item;
            }
            int avarageOfSmallestNumbers = totalOfSmallest / smallNumbers.Length;
            Console.WriteLine("The Avarage Of 3 Smalles Numbers: " + avarageOfSmallestNumbers);
           
            Console.WriteLine("\n The total of avarages: "+(avarageOfBiggestNumbers+avarageOfSmallestNumbers));

        }
    }
}
