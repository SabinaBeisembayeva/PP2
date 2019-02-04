using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //create integer - number of lines
            for(int i=0; i<n; i++) //number of rows
            {
                for(int j=0; j<=i+1; j++) //number of columns
                {
                    Console.Write("[*]"); // command to see on a screen needed representation =
                }
                Console.WriteLine(); // switches to the next line 
            }
            Console.ReadKey(); // terminal will not close immediatly 
        }
    }
}
