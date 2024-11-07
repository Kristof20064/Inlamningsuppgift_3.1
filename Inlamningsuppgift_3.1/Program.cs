using System;
using System.ComponentModel.Design;

namespace Inlamning_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int år = int.Parse(Console.ReadLine());

            if (år < 16)
            {
                Console.WriteLine("Du är tyvärr för ung för att delta i tävlingen");
            }

            else if (år > 19)
            {
                Console.WriteLine("Du är tyvärr för gammal för att delta i tävlingen");
            }

            else
            {
                Console.WriteLine("Du får delta i tävlingen");
            }

            
        }
    }
}