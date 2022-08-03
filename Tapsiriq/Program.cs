using System;

namespace Tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Add Sentences");
            string sentence = Console.ReadLine();
            int count = 0;
            foreach (var item in sentence)
            {

                if (item == 'a')
                {
                    count++;

                }
            }
            if (count > 0)
            {
                Console.WriteLine("var");
            }
            else
            {
                Console.WriteLine("yoxdur");
            }
        }



    }
}

