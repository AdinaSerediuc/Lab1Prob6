using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Prob6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex6
Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
descrescatoare.
• Exemplu: citim 3,9,0 Afisam : 9 3 0  */
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            

            if (x > y && x > z && y > z)
            { 
                Console.WriteLine("Numerele sunt puse descrescator " + x + "," + y + "," + z);
            }
             else if (x > y && x > z && z > y)
                {
                Console.WriteLine("Numerele sunt puse descrescator " + x + "," + z + "," + y);
                }
                else if (y > x && y > z && x > z)
                 {
                Console.WriteLine("Numerele sunt puse descrescator " + y + "," + x + "," + z);
                 }
                     else if (y > x && y > z && z > x)
                      {
                      Console.WriteLine("Numerele sunt puse descrescator " + y + "," + z + "," + x);
                      }
                      else if (z > x && z > y && y > x)
                       {
                       Console.WriteLine("Numerele sunt puse descrescator " + z + "," + y + "," + x);
                       }
                       else if (z > x && z > y && x > y)
                        {
                        Console.WriteLine("Numerele sunt puse descrescator " + z + "," + x + "," + y);
                        }
        }
    }
}
