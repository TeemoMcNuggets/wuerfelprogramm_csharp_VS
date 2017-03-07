using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WürfelProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Random numberGen = new Random();

            string Name;
            int Würfel;
            int i = 0;
            int Versuch;
            
            Console.WriteLine("Hallo, wie ist dein Name?");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Okay " + Name + " wie viele Würfel willst du werfen?");
            Würfel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Okay, " + Würfel + " Würfel werden geworfen.");
            while (i <= Würfel) 
            {
                Versuch = numberGen.Next(1, 6);
                i++;
                Console.WriteLine("Du hast eine " + Versuch + " gewürfelt.");

            }
            Console.ReadKey();

            Console.Clear();

            goto start;

            Console.ReadKey();
        }
    }
}
