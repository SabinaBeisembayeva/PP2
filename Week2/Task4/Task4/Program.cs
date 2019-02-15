using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string putin = @"C:\Users\Sabina\pp2\PP2\Week2\Task4\putin";
            string russia = "RH";

            string from = Path.Combine(putin, russia);

            FileStream fs = File.Create(from);
            fs.Close(); 

            string nazarbayev = @"C:\Users\Sabina\pp2\PP2\Week2\Task4\nazarbayev";
            string to = Path.Combine(nazarbayev, russia);

            if (File.Exists(from))
            {
                File.Delete(to);  
            }

            File.Copy(from, to);

            File.Delete(from);

            


           



        }
    }
}
