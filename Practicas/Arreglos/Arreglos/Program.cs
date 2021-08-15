using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Parentesco = new string[4];
            Parentesco[0] = "Papà";
            Parentesco[1] = "Mamà";
            Parentesco[2] = "Sobrina";
            Parentesco[3] = "Hermano";

            string[] nombres = new string[4];
            Parentesco[0] = "Wilian";
            Parentesco[1] = "Haydee";
            Parentesco[2] = "Fatima";
            Parentesco[3] = "William";

            int[] edad = new int[4];
            edad[0] = 46;
            edad[1] = 38;
            edad[2] = 1;
            edad[3] = 16;

            for (int i = 0; i < Parentesco.Length; i++)
            {
                Console.WriteLine(" Parentesco {0}: {1} ", i, Parentesco[i]);
            }
            for (int i = 0; i < Parentesco.Length; i++)
            {
                Console.WriteLine(" Parentesco {0}: {1} ", i, Parentesco[i]);
            }
            Array.Sort(edad);
            for (int i = 0; i < edad.Length; i++)
            {
                Console.WriteLine(" edad {0}: {1} ", i, edad[i]);
            }
            Console.ReadKey();
        }

    }
}
