using System;
using System.Collections.Generic;
namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Char> sesliHarfler = new List<char> { 'a', 'A', 'e', 'E', 'i', 'İ', 'I', 'ı', 'u', 'U', 'ü', 'Ü', 'o', 'O', 'Ö', 'ö' };
            List<Char> cumledekiHarfler = new List<char>();
            string cumle = Console.ReadLine();
            foreach (var item in sesliHarfler)
            {
                if (cumle.Contains(item))
                {
                    cumledekiHarfler.Add(item);
                }
            }
            cumledekiHarfler.Sort();
            foreach (var item in cumledekiHarfler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
